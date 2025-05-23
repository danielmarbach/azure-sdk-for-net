// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Network
{
    internal class ConnectionMonitorOperationSource : IOperationSource<ConnectionMonitorResource>
    {
        private readonly ArmClient _client;

        internal ConnectionMonitorOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConnectionMonitorResource IOperationSource<ConnectionMonitorResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ConnectionMonitorData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return new ConnectionMonitorResource(_client, data);
        }

        async ValueTask<ConnectionMonitorResource> IOperationSource<ConnectionMonitorResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<ConnectionMonitorData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerNetworkContext.Default);
            return await Task.FromResult(new ConnectionMonitorResource(_client, data)).ConfigureAwait(false);
        }
    }
}
