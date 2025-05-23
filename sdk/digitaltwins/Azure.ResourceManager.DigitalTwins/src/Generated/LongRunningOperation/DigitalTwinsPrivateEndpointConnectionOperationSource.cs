// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins
{
    internal class DigitalTwinsPrivateEndpointConnectionOperationSource : IOperationSource<DigitalTwinsPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal DigitalTwinsPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        DigitalTwinsPrivateEndpointConnectionResource IOperationSource<DigitalTwinsPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DigitalTwinsPrivateEndpointConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDigitalTwinsContext.Default);
            return new DigitalTwinsPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<DigitalTwinsPrivateEndpointConnectionResource> IOperationSource<DigitalTwinsPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DigitalTwinsPrivateEndpointConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerDigitalTwinsContext.Default);
            return await Task.FromResult(new DigitalTwinsPrivateEndpointConnectionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
