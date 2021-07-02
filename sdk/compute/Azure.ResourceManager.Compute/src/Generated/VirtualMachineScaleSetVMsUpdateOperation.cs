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
    /// <summary> Updates a virtual machine of a VM scale set. </summary>
    public partial class VirtualMachineScaleSetVMsUpdateOperation : Operation<VirtualMachineScaleSetVM>, IOperationSource<VirtualMachineScaleSetVM>
    {
        private readonly OperationInternals<VirtualMachineScaleSetVM> _operation;

        private readonly ResourceOperationsBase _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVMsUpdateOperation for mocking. </summary>
        protected VirtualMachineScaleSetVMsUpdateOperation()
        {
        }

        internal VirtualMachineScaleSetVMsUpdateOperation(ResourceOperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineScaleSetVM>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineScaleSetVMsUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineScaleSetVM Value => _operation.Value;

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
        public override ValueTask<Response<VirtualMachineScaleSetVM>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSetVM>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineScaleSetVM IOperationSource<VirtualMachineScaleSetVM>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VirtualMachineScaleSetVM(_operationBase, VirtualMachineScaleSetVMData.DeserializeVirtualMachineScaleSetVMData(document.RootElement));
        }

        async ValueTask<VirtualMachineScaleSetVM> IOperationSource<VirtualMachineScaleSetVM>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VirtualMachineScaleSetVM(_operationBase, VirtualMachineScaleSetVMData.DeserializeVirtualMachineScaleSetVMData(document.RootElement));
        }
    }
}
