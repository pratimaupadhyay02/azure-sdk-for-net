// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view status.
    /// </summary>
    public partial class InstanceViewStatus : ITransportObjectProvider<Models.InstanceViewStatus>, IPropertyMetadata
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceViewStatus"/> class.
        /// </summary>
        public InstanceViewStatus()
        {
        }

        internal InstanceViewStatus(Models.InstanceViewStatus protocolObject)
        {
            this.Code = protocolObject.Code;
            this.DisplayStatus = protocolObject.DisplayStatus;
            this.Level = UtilitiesInternal.MapEnum<Models.StatusLevelTypes, Common.StatusLevelTypes>(protocolObject.Level);
            this.Message = protocolObject.Message;
            this.time = protocolObject.time;
        }

        #endregion Constructors

        #region InstanceViewStatus

        /// <summary>
        /// Gets the status code.
        /// </summary>
        public string Code { get; }

        /// <summary>
        /// Gets the localized label for the status.
        /// </summary>
        public string DisplayStatus { get; }

        /// <summary>
        /// Gets level code.
        /// </summary>
        public Common.StatusLevelTypes Level { get; }

        /// <summary>
        /// Gets the detailed status message.
        /// </summary>
        public string Message { get; }

        /// <summary>
        /// Gets the time of the status.
        /// </summary>
        public string time { get; }

        #endregion // InstanceViewStatus

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata

        #region Internal/private methods

        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.InstanceViewStatus ITransportObjectProvider<Models.InstanceViewStatus>.GetTransportObject()
        {
            Models.InstanceViewStatus result = new Models.InstanceViewStatus()
            {
                Code = this.Code,
                DisplayStatus = this.DisplayStatus,
                Level = UtilitiesInternal.MapEnum<Common.StatusLevelTypes, Models.StatusLevelTypes>(this.Level),
                Message = this.Message,
                time = this.time,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}