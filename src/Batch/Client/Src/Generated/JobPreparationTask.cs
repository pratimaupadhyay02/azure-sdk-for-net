// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
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
    /// A Job Preparation task to run before any tasks of the job on any given compute node.
    /// </summary>
    public partial class JobPreparationTask : ITransportObjectProvider<Models.JobPreparationTask>, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<string> CommandLineProperty;
            public readonly PropertyAccessor<TaskConstraints> ConstraintsProperty;
            public readonly PropertyAccessor<IList<EnvironmentSetting>> EnvironmentSettingsProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<bool?> RerunOnComputeNodeRebootAfterSuccessProperty;
            public readonly PropertyAccessor<IList<ResourceFile>> ResourceFilesProperty;
            public readonly PropertyAccessor<UserIdentity> UserIdentityProperty;
            public readonly PropertyAccessor<bool?> WaitForSuccessProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.CommandLineProperty = this.CreatePropertyAccessor<string>("CommandLine", BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor<TaskConstraints>("Constraints", BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>("EnvironmentSettings", BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor<string>("Id", BindingAccess.Read | BindingAccess.Write);
                this.RerunOnComputeNodeRebootAfterSuccessProperty = this.CreatePropertyAccessor<bool?>("RerunOnComputeNodeRebootAfterSuccess", BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>("ResourceFiles", BindingAccess.Read | BindingAccess.Write);
                this.UserIdentityProperty = this.CreatePropertyAccessor<UserIdentity>("UserIdentity", BindingAccess.Read | BindingAccess.Write);
                this.WaitForSuccessProperty = this.CreatePropertyAccessor<bool?>("WaitForSuccess", BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.JobPreparationTask protocolObject) : base(BindingState.Bound)
            {
                this.CommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CommandLine,
                    "CommandLine",
                    BindingAccess.Read | BindingAccess.Write);
                this.ConstraintsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Constraints, o => new TaskConstraints(o)),
                    "Constraints",
                    BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollection(protocolObject.EnvironmentSettings),
                    "EnvironmentSettings",
                    BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    "Id",
                    BindingAccess.Read | BindingAccess.Write);
                this.RerunOnComputeNodeRebootAfterSuccessProperty = this.CreatePropertyAccessor(
                    protocolObject.RerunOnNodeRebootAfterSuccess,
                    "RerunOnComputeNodeRebootAfterSuccess",
                    BindingAccess.Read | BindingAccess.Write);
                this.ResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollection(protocolObject.ResourceFiles),
                    "ResourceFiles",
                    BindingAccess.Read | BindingAccess.Write);
                this.UserIdentityProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.UserIdentity, o => new UserIdentity(o).Freeze()),
                    "UserIdentity",
                    BindingAccess.Read);
                this.WaitForSuccessProperty = this.CreatePropertyAccessor(
                    protocolObject.WaitForSuccess,
                    "WaitForSuccess",
                    BindingAccess.Read | BindingAccess.Write);
            }
        }

        private readonly PropertyContainer propertyContainer;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="JobPreparationTask"/> class.
        /// </summary>
        /// <param name='commandLine'>The command line of the task.</param>
        public JobPreparationTask(
            string commandLine)
        {
            this.propertyContainer = new PropertyContainer();
            this.CommandLine = commandLine;
        }

        internal JobPreparationTask(Models.JobPreparationTask protocolObject)
        {
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region JobPreparationTask

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment 
        /// variable expansion. If you want to take advantage of such features, you should invoke the shell in the command 
        /// line, for example using "cmd /c MyCommand" in Windows or "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        public string CommandLine
        {
            get { return this.propertyContainer.CommandLineProperty.Value; }
            set { this.propertyContainer.CommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the execution constraints provided by the user for this Job Preparation task.
        /// </summary>
        public TaskConstraints Constraints
        {
            get { return this.propertyContainer.ConstraintsProperty.Value; }
            set { this.propertyContainer.ConstraintsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the collection of EnvironmentSetting instances.
        /// </summary>
        public IList<EnvironmentSetting> EnvironmentSettings
        {
            get { return this.propertyContainer.EnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.EnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the id of the task.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the Batch service should rerun the Job Preparation task after a compute node reboots.
        /// </summary>
        /// <remarks>
        /// The Job Preparation task is always rerun if a compute node is reimaged, or if the Job Preparation task did not 
        /// complete (e.g. because the reboot occurred while the task was running). Therefore, you should always write a 
        /// Job Preparation task to be idempotent and to behave correctly if run multiple times. If this property is not 
        /// specified, a default value of true is assigned by the Batch service.
        /// </remarks>
        public bool? RerunOnComputeNodeRebootAfterSuccess
        {
            get { return this.propertyContainer.RerunOnComputeNodeRebootAfterSuccessProperty.Value; }
            set { this.propertyContainer.RerunOnComputeNodeRebootAfterSuccessProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download to the compute node before running the command 
        /// line.
        /// </summary>
        public IList<ResourceFile> ResourceFiles
        {
            get { return this.propertyContainer.ResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.ResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the user identity under which the task runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to the task
        /// </remarks>
        public UserIdentity UserIdentity
        {
            get { return this.propertyContainer.UserIdentityProperty.Value; }
            set { this.propertyContainer.UserIdentityProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets whether the Batch service should wait for the successful completion of the Job Preparation task 
        /// before scheduling any tasks on the compute node.
        /// </summary>
        /// <remarks>
        /// A Job Preparation task execution is considered successful if its ExitCode is 0. If this property is not specified, 
        /// a default value of true is assigned by the Batch service.
        /// </remarks>
        public bool? WaitForSuccess
        {
            get { return this.propertyContainer.WaitForSuccessProperty.Value; }
            set { this.propertyContainer.WaitForSuccessProperty.Value = value; }
        }

        #endregion // JobPreparationTask

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.JobPreparationTask ITransportObjectProvider<Models.JobPreparationTask>.GetTransportObject()
        {
            Models.JobPreparationTask result = new Models.JobPreparationTask()
            {
                CommandLine = this.CommandLine,
                Constraints = UtilitiesInternal.CreateObjectWithNullCheck(this.Constraints, (o) => o.GetTransportObject()),
                EnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.EnvironmentSettings),
                Id = this.Id,
                RerunOnNodeRebootAfterSuccess = this.RerunOnComputeNodeRebootAfterSuccess,
                ResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.ResourceFiles),
                UserIdentity = UtilitiesInternal.CreateObjectWithNullCheck(this.UserIdentity, (o) => o.GetTransportObject()),
                WaitForSuccess = this.WaitForSuccess,
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}