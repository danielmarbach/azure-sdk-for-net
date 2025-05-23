// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Chaos
{
    /// <summary>
    /// A class representing a collection of <see cref="ChaosExperimentExecutionResource"/> and their operations.
    /// Each <see cref="ChaosExperimentExecutionResource"/> in the collection will belong to the same instance of <see cref="ChaosExperimentResource"/>.
    /// To get a <see cref="ChaosExperimentExecutionCollection"/> instance call the GetChaosExperimentExecutions method from an instance of <see cref="ChaosExperimentResource"/>.
    /// </summary>
    public partial class ChaosExperimentExecutionCollection : ArmCollection, IEnumerable<ChaosExperimentExecutionResource>, IAsyncEnumerable<ChaosExperimentExecutionResource>
    {
        private readonly ClientDiagnostics _chaosExperimentExecutionExperimentExecutionsClientDiagnostics;
        private readonly ExperimentExecutionsRestOperations _chaosExperimentExecutionExperimentExecutionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ChaosExperimentExecutionCollection"/> class for mocking. </summary>
        protected ChaosExperimentExecutionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ChaosExperimentExecutionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ChaosExperimentExecutionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _chaosExperimentExecutionExperimentExecutionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Chaos", ChaosExperimentExecutionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ChaosExperimentExecutionResource.ResourceType, out string chaosExperimentExecutionExperimentExecutionsApiVersion);
            _chaosExperimentExecutionExperimentExecutionsRestClient = new ExperimentExecutionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, chaosExperimentExecutionExperimentExecutionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ChaosExperimentResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ChaosExperimentResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an execution of an Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions/{executionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_GetExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionId"/> is null. </exception>
        public virtual async Task<Response<ChaosExperimentExecutionResource>> GetAsync(string executionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionId, nameof(executionId));

            using var scope = _chaosExperimentExecutionExperimentExecutionsClientDiagnostics.CreateScope("ChaosExperimentExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = await _chaosExperimentExecutionExperimentExecutionsRestClient.GetExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ChaosExperimentExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an execution of an Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions/{executionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_GetExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionId"/> is null. </exception>
        public virtual Response<ChaosExperimentExecutionResource> Get(string executionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionId, nameof(executionId));

            using var scope = _chaosExperimentExecutionExperimentExecutionsClientDiagnostics.CreateScope("ChaosExperimentExecutionCollection.Get");
            scope.Start();
            try
            {
                var response = _chaosExperimentExecutionExperimentExecutionsRestClient.GetExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ChaosExperimentExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of executions of an Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_ListAllExecutions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ChaosExperimentExecutionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ChaosExperimentExecutionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosExperimentExecutionExperimentExecutionsRestClient.CreateListAllExecutionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosExperimentExecutionExperimentExecutionsRestClient.CreateListAllExecutionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ChaosExperimentExecutionResource(Client, ChaosExperimentExecutionData.DeserializeChaosExperimentExecutionData(e)), _chaosExperimentExecutionExperimentExecutionsClientDiagnostics, Pipeline, "ChaosExperimentExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of executions of an Experiment resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_ListAllExecutions</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ChaosExperimentExecutionResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ChaosExperimentExecutionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _chaosExperimentExecutionExperimentExecutionsRestClient.CreateListAllExecutionsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _chaosExperimentExecutionExperimentExecutionsRestClient.CreateListAllExecutionsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ChaosExperimentExecutionResource(Client, ChaosExperimentExecutionData.DeserializeChaosExperimentExecutionData(e)), _chaosExperimentExecutionExperimentExecutionsClientDiagnostics, Pipeline, "ChaosExperimentExecutionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions/{executionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_GetExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string executionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionId, nameof(executionId));

            using var scope = _chaosExperimentExecutionExperimentExecutionsClientDiagnostics.CreateScope("ChaosExperimentExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _chaosExperimentExecutionExperimentExecutionsRestClient.GetExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions/{executionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_GetExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionId"/> is null. </exception>
        public virtual Response<bool> Exists(string executionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionId, nameof(executionId));

            using var scope = _chaosExperimentExecutionExperimentExecutionsClientDiagnostics.CreateScope("ChaosExperimentExecutionCollection.Exists");
            scope.Start();
            try
            {
                var response = _chaosExperimentExecutionExperimentExecutionsRestClient.GetExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions/{executionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_GetExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionId"/> is null. </exception>
        public virtual async Task<NullableResponse<ChaosExperimentExecutionResource>> GetIfExistsAsync(string executionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionId, nameof(executionId));

            using var scope = _chaosExperimentExecutionExperimentExecutionsClientDiagnostics.CreateScope("ChaosExperimentExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _chaosExperimentExecutionExperimentExecutionsRestClient.GetExecutionAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ChaosExperimentExecutionResource>(response.GetRawResponse());
                return Response.FromValue(new ChaosExperimentExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Chaos/experiments/{experimentName}/executions/{executionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExperimentExecution_GetExecution</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-01-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ChaosExperimentExecutionResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="executionId"> GUID that represents a Experiment execution detail. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="executionId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="executionId"/> is null. </exception>
        public virtual NullableResponse<ChaosExperimentExecutionResource> GetIfExists(string executionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(executionId, nameof(executionId));

            using var scope = _chaosExperimentExecutionExperimentExecutionsClientDiagnostics.CreateScope("ChaosExperimentExecutionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _chaosExperimentExecutionExperimentExecutionsRestClient.GetExecution(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, executionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ChaosExperimentExecutionResource>(response.GetRawResponse());
                return Response.FromValue(new ChaosExperimentExecutionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ChaosExperimentExecutionResource> IEnumerable<ChaosExperimentExecutionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ChaosExperimentExecutionResource> IAsyncEnumerable<ChaosExperimentExecutionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
