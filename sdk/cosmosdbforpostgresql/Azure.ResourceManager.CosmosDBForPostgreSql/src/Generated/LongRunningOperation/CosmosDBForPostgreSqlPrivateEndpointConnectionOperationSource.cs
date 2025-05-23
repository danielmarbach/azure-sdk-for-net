// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    internal class CosmosDBForPostgreSqlPrivateEndpointConnectionOperationSource : IOperationSource<CosmosDBForPostgreSqlPrivateEndpointConnectionResource>
    {
        private readonly ArmClient _client;

        internal CosmosDBForPostgreSqlPrivateEndpointConnectionOperationSource(ArmClient client)
        {
            _client = client;
        }

        CosmosDBForPostgreSqlPrivateEndpointConnectionResource IOperationSource<CosmosDBForPostgreSqlPrivateEndpointConnectionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);
            return new CosmosDBForPostgreSqlPrivateEndpointConnectionResource(_client, data);
        }

        async ValueTask<CosmosDBForPostgreSqlPrivateEndpointConnectionResource> IOperationSource<CosmosDBForPostgreSqlPrivateEndpointConnectionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<CosmosDBForPostgreSqlPrivateEndpointConnectionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerCosmosDBForPostgreSqlContext.Default);
            return await Task.FromResult(new CosmosDBForPostgreSqlPrivateEndpointConnectionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
