// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of VirtualMachineScaleSetVM and their operations over a VirtualMachineScaleSet. </summary>
    public partial class VirtualMachineScaleSetVMContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, VirtualMachineScaleSetVM, VirtualMachineScaleSetVMData>
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualMachineScaleSetVMContainer"/> class for mocking. </summary>
        protected VirtualMachineScaleSetVMContainer()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualMachineScaleSetVMContainer(ResourceOperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualMachineScaleSetVMsRestOperations _restClient => new VirtualMachineScaleSetVMsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualMachineScaleSetOperations.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update a VirtualMachineScaleSetVM. Please note some properties can be set only during creation. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Update Virtual Machine Scale Sets VM operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<VirtualMachineScaleSetVM> CreateOrUpdate(string instanceId, VirtualMachineScaleSetVMData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                return StartCreateOrUpdate(instanceId, parameters, cancellationToken: cancellationToken).WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a VirtualMachineScaleSetVM. Please note some properties can be set only during creation. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Update Virtual Machine Scale Sets VM operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<VirtualMachineScaleSetVM>> CreateOrUpdateAsync(string instanceId, VirtualMachineScaleSetVMData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var operation = await StartCreateOrUpdateAsync(instanceId, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a VirtualMachineScaleSetVM. Please note some properties can be set only during creation. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Update Virtual Machine Scale Sets VM operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public VirtualMachineScaleSetVMsUpdateOperation StartCreateOrUpdate(string instanceId, VirtualMachineScaleSetVMData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = _restClient.Update(Id.ResourceGroupName, Id.Name, instanceId, parameters, cancellationToken: cancellationToken);
                return new VirtualMachineScaleSetVMsUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Name, instanceId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update a VirtualMachineScaleSetVM. Please note some properties can be set only during creation. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Update Virtual Machine Scale Sets VM operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<VirtualMachineScaleSetVMsUpdateOperation> StartCreateOrUpdateAsync(string instanceId, VirtualMachineScaleSetVMData parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }
                if (parameters == null)
                {
                    throw new ArgumentNullException(nameof(parameters));
                }

                var originalResponse = await _restClient.UpdateAsync(Id.ResourceGroupName, Id.Name, instanceId, parameters, cancellationToken: cancellationToken).ConfigureAwait(false);
                return new VirtualMachineScaleSetVMsUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateUpdateRequest(Id.ResourceGroupName, Id.Name, instanceId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public Response<VirtualMachineScaleSetVM> Get(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.Get");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken);
                return Response.FromValue(new VirtualMachineScaleSetVM(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. &apos;InstanceView&apos; will retrieve the instance view of the virtual machine. &apos;UserData&apos; will retrieve the UserData of the virtual machine. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async Task<Response<VirtualMachineScaleSetVM>> GetAsync(string instanceId, InstanceViewTypes? expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.Get");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualMachineScaleSetVM(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of all virtual machines in a VM scale sets. </summary>
        /// <param name="filter"> The filter to apply to the operation. Allowed values are &apos;startswith(instanceView/statuses/code, &apos;PowerState&apos;) eq true&apos;, &apos;properties/latestModelApplied eq true&apos;, &apos;properties/latestModelApplied eq false&apos;. </param>
        /// <param name="select"> The list parameters. Allowed values are &apos;instanceView&apos;, &apos;instanceView/statuses&apos;. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetVM" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualMachineScaleSetVM> List(string filter = null, string select = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetVM> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.List(Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSetVM> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListNextPage(nextLink, Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of all virtual machines in a VM scale sets. </summary>
        /// <param name="filter"> The filter to apply to the operation. Allowed values are &apos;startswith(instanceView/statuses/code, &apos;PowerState&apos;) eq true&apos;, &apos;properties/latestModelApplied eq true&apos;, &apos;properties/latestModelApplied eq false&apos;. </param>
        /// <param name="select"> The list parameters. Allowed values are &apos;instanceView&apos;, &apos;instanceView/statuses&apos;. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetVM" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualMachineScaleSetVM> ListAsync(string filter = null, string select = null, string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetVM>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAsync(Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSetVM>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, filter, select, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetVM(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of VirtualMachineScaleSetVM for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineScaleSetVMOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of VirtualMachineScaleSetVM for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualMachineScaleSetVMContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualMachineScaleSetVMOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, VirtualMachineScaleSetVM, VirtualMachineScaleSetVMData> Construct() { }
    }
}
