// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Server response for GetMemberGroups API call. </summary>
    internal partial class GroupGetMemberGroupsResult
    {
        /// <summary> Initializes a new instance of GroupGetMemberGroupsResult. </summary>
        internal GroupGetMemberGroupsResult()
        {
            Value = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of GroupGetMemberGroupsResult. </summary>
        /// <param name="value"> A collection of group IDs of which the group is a member. </param>
        internal GroupGetMemberGroupsResult(IReadOnlyList<string> value)
        {
            Value = value;
        }

        /// <summary> A collection of group IDs of which the group is a member. </summary>
        public IReadOnlyList<string> Value { get; }
    }
}
