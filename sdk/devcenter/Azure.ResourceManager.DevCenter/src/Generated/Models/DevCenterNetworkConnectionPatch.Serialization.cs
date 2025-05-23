// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterNetworkConnectionPatch : IUtf8JsonSerializable, IJsonModel<DevCenterNetworkConnectionPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevCenterNetworkConnectionPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DevCenterNetworkConnectionPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterNetworkConnectionPatch)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(SubnetId))
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (Optional.IsDefined(DomainName))
            {
                writer.WritePropertyName("domainName"u8);
                writer.WriteStringValue(DomainName);
            }
            if (Optional.IsDefined(OrganizationUnit))
            {
                writer.WritePropertyName("organizationUnit"u8);
                writer.WriteStringValue(OrganizationUnit);
            }
            if (Optional.IsDefined(DomainUsername))
            {
                writer.WritePropertyName("domainUsername"u8);
                writer.WriteStringValue(DomainUsername);
            }
            if (Optional.IsDefined(DomainPassword))
            {
                writer.WritePropertyName("domainPassword"u8);
                writer.WriteStringValue(DomainPassword);
            }
            writer.WriteEndObject();
        }

        DevCenterNetworkConnectionPatch IJsonModel<DevCenterNetworkConnectionPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevCenterNetworkConnectionPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterNetworkConnectionPatch(document.RootElement, options);
        }

        internal static DevCenterNetworkConnectionPatch DeserializeDevCenterNetworkConnectionPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation? location = default;
            ResourceIdentifier subnetId = default;
            string domainName = default;
            string organizationUnit = default;
            string domainUsername = default;
            string domainPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("domainName"u8))
                        {
                            domainName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("organizationUnit"u8))
                        {
                            organizationUnit = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainUsername"u8))
                        {
                            domainUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("domainPassword"u8))
                        {
                            domainPassword = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DevCenterNetworkConnectionPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                serializedAdditionalRawData,
                subnetId,
                domainName,
                organizationUnit,
                domainUsername,
                domainPassword);
        }

        BinaryData IPersistableModel<DevCenterNetworkConnectionPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerDevCenterContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DevCenterNetworkConnectionPatch)} does not support writing '{options.Format}' format.");
            }
        }

        DevCenterNetworkConnectionPatch IPersistableModel<DevCenterNetworkConnectionPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevCenterNetworkConnectionPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDevCenterNetworkConnectionPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevCenterNetworkConnectionPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevCenterNetworkConnectionPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
