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
    /// <summary> The operation to update an extension. </summary>
    public partial class VirtualMachineScaleSetExtensionsUpdateOperation : Operation<VirtualMachineScaleSetExtension>, IOperationSource<VirtualMachineScaleSetExtension>
    {
        private readonly OperationInternals<VirtualMachineScaleSetExtension> _operation;

        private readonly ResourceOperationsBase _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineScaleSetExtensionsUpdateOperation for mocking. </summary>
        protected VirtualMachineScaleSetExtensionsUpdateOperation()
        {
        }

        internal VirtualMachineScaleSetExtensionsUpdateOperation(ResourceOperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineScaleSetExtension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualMachineScaleSetExtensionsUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineScaleSetExtension Value => _operation.Value;

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
        public override ValueTask<Response<VirtualMachineScaleSetExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineScaleSetExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineScaleSetExtension IOperationSource<VirtualMachineScaleSetExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VirtualMachineScaleSetExtension(_operationBase, VirtualMachineScaleSetExtensionData.DeserializeVirtualMachineScaleSetExtensionData(document.RootElement));
        }

        async ValueTask<VirtualMachineScaleSetExtension> IOperationSource<VirtualMachineScaleSetExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VirtualMachineScaleSetExtension(_operationBase, VirtualMachineScaleSetExtensionData.DeserializeVirtualMachineScaleSetExtensionData(document.RootElement));
        }
    }
}
