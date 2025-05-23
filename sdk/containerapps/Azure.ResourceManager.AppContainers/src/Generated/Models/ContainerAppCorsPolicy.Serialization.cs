// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppCorsPolicy : IUtf8JsonSerializable, IJsonModel<ContainerAppCorsPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppCorsPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppCorsPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("allowedOrigins"u8);
            writer.WriteStartArray();
            foreach (var item in AllowedOrigins)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(AllowedMethods))
            {
                writer.WritePropertyName("allowedMethods"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedMethods)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AllowedHeaders))
            {
                writer.WritePropertyName("allowedHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedHeaders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExposeHeaders))
            {
                writer.WritePropertyName("exposeHeaders"u8);
                writer.WriteStartArray();
                foreach (var item in ExposeHeaders)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MaxAge))
            {
                writer.WritePropertyName("maxAge"u8);
                writer.WriteNumberValue(MaxAge.Value);
            }
            if (Optional.IsDefined(AllowCredentials))
            {
                writer.WritePropertyName("allowCredentials"u8);
                writer.WriteBooleanValue(AllowCredentials.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        ContainerAppCorsPolicy IJsonModel<ContainerAppCorsPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppCorsPolicy(document.RootElement, options);
        }

        internal static ContainerAppCorsPolicy DeserializeContainerAppCorsPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> allowedOrigins = default;
            IList<string> allowedMethods = default;
            IList<string> allowedHeaders = default;
            IList<string> exposeHeaders = default;
            int? maxAge = default;
            bool? allowCredentials = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedOrigins"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedOrigins = array;
                    continue;
                }
                if (property.NameEquals("allowedMethods"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedMethods = array;
                    continue;
                }
                if (property.NameEquals("allowedHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    allowedHeaders = array;
                    continue;
                }
                if (property.NameEquals("exposeHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    exposeHeaders = array;
                    continue;
                }
                if (property.NameEquals("maxAge"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAge = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowCredentials = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppCorsPolicy(
                allowedOrigins,
                allowedMethods ?? new ChangeTrackingList<string>(),
                allowedHeaders ?? new ChangeTrackingList<string>(),
                exposeHeaders ?? new ChangeTrackingList<string>(),
                maxAge,
                allowCredentials,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedOrigins), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowedOrigins: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AllowedOrigins))
                {
                    if (AllowedOrigins.Any())
                    {
                        builder.Append("  allowedOrigins: ");
                        builder.AppendLine("[");
                        foreach (var item in AllowedOrigins)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedMethods), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowedMethods: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AllowedMethods))
                {
                    if (AllowedMethods.Any())
                    {
                        builder.Append("  allowedMethods: ");
                        builder.AppendLine("[");
                        foreach (var item in AllowedMethods)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowedHeaders), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowedHeaders: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AllowedHeaders))
                {
                    if (AllowedHeaders.Any())
                    {
                        builder.Append("  allowedHeaders: ");
                        builder.AppendLine("[");
                        foreach (var item in AllowedHeaders)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ExposeHeaders), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  exposeHeaders: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ExposeHeaders))
                {
                    if (ExposeHeaders.Any())
                    {
                        builder.Append("  exposeHeaders: ");
                        builder.AppendLine("[");
                        foreach (var item in ExposeHeaders)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxAge), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxAge: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxAge))
                {
                    builder.Append("  maxAge: ");
                    builder.AppendLine($"{MaxAge.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowCredentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowCredentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllowCredentials))
                {
                    builder.Append("  allowCredentials: ");
                    var boolValue = AllowCredentials.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppCorsPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerAppContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppCorsPolicy IPersistableModel<ContainerAppCorsPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppCorsPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerAppCorsPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppCorsPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppCorsPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
