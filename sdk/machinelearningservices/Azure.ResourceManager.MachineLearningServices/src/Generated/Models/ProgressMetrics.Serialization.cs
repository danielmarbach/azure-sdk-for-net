// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class ProgressMetrics : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static ProgressMetrics DeserializeProgressMetrics(JsonElement element)
        {
            Optional<long> totalDatapointCount = default;
            Optional<long> completedDatapointCount = default;
            Optional<long> skippedDatapointCount = default;
            Optional<DateTimeOffset> incrementalDatasetLastRefreshTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDatapointCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalDatapointCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("completedDatapointCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    completedDatapointCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("skippedDatapointCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skippedDatapointCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("incrementalDatasetLastRefreshTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    incrementalDatasetLastRefreshTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ProgressMetrics(Optional.ToNullable(totalDatapointCount), Optional.ToNullable(completedDatapointCount), Optional.ToNullable(skippedDatapointCount), Optional.ToNullable(incrementalDatasetLastRefreshTime));
        }
    }
}
