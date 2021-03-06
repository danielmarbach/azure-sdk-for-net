// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearningServices.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The AzureMachineLearningWorkspaces service client. </summary>
    public partial class AzureMachineLearningWorkspacesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal AzureMachineLearningWorkspacesRestOperations RestClient { get; }

        /// <summary> Initializes a new instance of AzureMachineLearningWorkspacesOperations for mocking. </summary>
        protected AzureMachineLearningWorkspacesOperations()
        {
        }

        /// <summary> Initializes a new instance of AzureMachineLearningWorkspacesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Azure subscription identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        internal AzureMachineLearningWorkspacesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-09-01-preview")
        {
            RestClient = new AzureMachineLearningWorkspacesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Lists all skus with associated features. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<WorkspaceSku> ListSkusAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkspaceSku>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureMachineLearningWorkspacesOperations.ListSkus");
                scope.Start();
                try
                {
                    var response = await RestClient.ListSkusAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkspaceSku>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureMachineLearningWorkspacesOperations.ListSkus");
                scope.Start();
                try
                {
                    var response = await RestClient.ListSkusNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all skus with associated features. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<WorkspaceSku> ListSkus(CancellationToken cancellationToken = default)
        {
            Page<WorkspaceSku> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureMachineLearningWorkspacesOperations.ListSkus");
                scope.Start();
                try
                {
                    var response = RestClient.ListSkus(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkspaceSku> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AzureMachineLearningWorkspacesOperations.ListSkus");
                scope.Start();
                try
                {
                    var response = RestClient.ListSkusNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
