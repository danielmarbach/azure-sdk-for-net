// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The properties of File services in storage account. </summary>
    public partial class FileServiceProperties : Resource
    {
        /// <summary> Initializes a new instance of FileServiceProperties. </summary>
        public FileServiceProperties()
        {
        }

        /// <summary> Initializes a new instance of FileServiceProperties. </summary>
        /// <param name="id"> Fully qualified resource Id for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}. </param>
        /// <param name="name"> The name of the resource. </param>
        /// <param name="type"> The type of the resource. Ex- Microsoft.Compute/virtualMachines or Microsoft.Storage/storageAccounts. </param>
        /// <param name="sku"> Sku name and tier. </param>
        /// <param name="cors"> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </param>
        /// <param name="shareDeleteRetentionPolicy"> The file service properties for share soft delete. </param>
        internal FileServiceProperties(string id, string name, string type, Sku sku, CorsRules cors, DeleteRetentionPolicy shareDeleteRetentionPolicy) : base(id, name, type)
        {
            Sku = sku;
            Cors = cors;
            ShareDeleteRetentionPolicy = shareDeleteRetentionPolicy;
        }

        /// <summary> Sku name and tier. </summary>
        public Sku Sku { get; }
        /// <summary> Specifies CORS rules for the File service. You can include up to five CorsRule elements in the request. If no CorsRule elements are included in the request body, all CORS rules will be deleted, and CORS will be disabled for the File service. </summary>
        public CorsRules Cors { get; set; }
        /// <summary> The file service properties for share soft delete. </summary>
        public DeleteRetentionPolicy ShareDeleteRetentionPolicy { get; set; }
    }
}
