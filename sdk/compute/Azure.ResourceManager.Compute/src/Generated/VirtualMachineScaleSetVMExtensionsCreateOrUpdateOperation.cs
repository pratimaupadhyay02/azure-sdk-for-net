// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Compute
{
    /// <summary> The operation to create or update the VMSS VM extension. </summary>
    public partial class VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation : Operation<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet>, IOperationSource<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet>
    {
        private readonly OperationInternals<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet> _operation;

        private readonly ResourceOperationsBase _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation for mocking. </summary>
        protected VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation()
        {
        }

        internal VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation(ResourceOperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineScaleSetVMExtensionsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet IOperationSource<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet(_operationBase, VirtualMachineScaleSetVMExtensionData.DeserializeVirtualMachineScaleSetVMExtensionData(document.RootElement));
        }

        async ValueTask<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet> IOperationSource<VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VirtualMachineScaleSetVMExtensionVirtualMachineScaleSet(_operationBase, VirtualMachineScaleSetVMExtensionData.DeserializeVirtualMachineScaleSetVMExtensionData(document.RootElement));
        }
    }
}
