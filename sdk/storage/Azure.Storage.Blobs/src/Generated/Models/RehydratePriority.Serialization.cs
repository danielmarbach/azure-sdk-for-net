// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    internal static partial class RehydratePriorityExtensions
    {
        public static string ToSerialString(this RehydratePriority value) => value switch
        {
            RehydratePriority.High => "High",
            RehydratePriority.Standard => "Standard",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RehydratePriority value.")
        };

        public static RehydratePriority ToRehydratePriority(this string value)
        {
            if (string.Equals(value, "High", StringComparison.InvariantCultureIgnoreCase)) return RehydratePriority.High;
            if (string.Equals(value, "Standard", StringComparison.InvariantCultureIgnoreCase)) return RehydratePriority.Standard;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown RehydratePriority value.");
        }
    }
}
