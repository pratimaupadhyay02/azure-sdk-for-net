// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> The OSVersionListResult. </summary>
    internal partial class OSVersionListResult
    {
        /// <summary> Initializes a new instance of OSVersionListResult. </summary>
        /// <param name="value"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal OSVersionListResult(IEnumerable<OSVersion> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of OSVersionListResult. </summary>
        /// <param name="value"> . </param>
        /// <param name="nextLink"> . </param>
        internal OSVersionListResult(IReadOnlyList<OSVersion> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IReadOnlyList<OSVersion> Value { get; }
        public string NextLink { get; }
    }
}
