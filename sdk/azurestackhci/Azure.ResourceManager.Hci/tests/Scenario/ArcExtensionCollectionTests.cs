// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.Hci.Tests
{
    public class ArcExtensionCollectionTests: HciManagementTestBase
    {
        public ArcExtensionCollectionTests(bool isAsync)
            : base(isAsync)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateGetList()
        {
            var location = AzureLocation.EastUS;
            var resourceGroup = await CreateResourceGroupAsync(Subscription, "hci-cluster-rg", location);
            var clusterName = Recording.GenerateAssetName("hci-cluster");
            var cluster = await CreateHciClusterAsync(resourceGroup, clusterName);
            var arcSetting = await CreateArcSettingAsync(cluster, "default");

            var arcExtensionCollection = arcSetting.GetArcExtensions();
            var arcExtensionName = "MicrosoftMonitoringAgent";
            var arcExtension = await CreateArcExtensionAsync(arcSetting, arcExtensionName);
            Assert.AreEqual(arcExtension.Data.Name, arcExtensionName);

            ArcExtensionResource arcExtensionFromGet = await arcExtensionCollection.GetAsync(arcExtensionName);
            Assert.AreEqual(arcExtensionFromGet.Data.Name, arcExtensionName);

            await foreach (ArcExtensionResource arcExtensionFromList in arcExtensionCollection)
            {
                Assert.AreEqual(arcExtensionFromList.Data.Name, arcExtensionName);
            }
        }
    }
}
