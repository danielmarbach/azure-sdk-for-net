// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementEmailTemplateCreateOrUpdateContent : IUtf8JsonSerializable, IJsonModel<ApiManagementEmailTemplateCreateOrUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementEmailTemplateCreateOrUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiManagementEmailTemplateCreateOrUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementEmailTemplateCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementEmailTemplateCreateOrUpdateContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("subject"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Body))
            {
                writer.WritePropertyName("body"u8);
                writer.WriteStringValue(Body);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartArray();
                foreach (var item in Parameters)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        ApiManagementEmailTemplateCreateOrUpdateContent IJsonModel<ApiManagementEmailTemplateCreateOrUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementEmailTemplateCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementEmailTemplateCreateOrUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementEmailTemplateCreateOrUpdateContent(document.RootElement, options);
        }

        internal static ApiManagementEmailTemplateCreateOrUpdateContent DeserializeApiManagementEmailTemplateCreateOrUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string subject = default;
            string title = default;
            string description = default;
            string body = default;
            IList<EmailTemplateParametersContractProperties> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("subject"u8))
                        {
                            subject = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("body"u8))
                        {
                            body = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EmailTemplateParametersContractProperties> array = new List<EmailTemplateParametersContractProperties>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EmailTemplateParametersContractProperties.DeserializeEmailTemplateParametersContractProperties(item, options));
                            }
                            parameters = array;
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
            return new ApiManagementEmailTemplateCreateOrUpdateContent(
                subject,
                title,
                description,
                body,
                parameters ?? new ChangeTrackingList<EmailTemplateParametersContractProperties>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementEmailTemplateCreateOrUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementEmailTemplateCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerApiManagementContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementEmailTemplateCreateOrUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementEmailTemplateCreateOrUpdateContent IPersistableModel<ApiManagementEmailTemplateCreateOrUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementEmailTemplateCreateOrUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeApiManagementEmailTemplateCreateOrUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementEmailTemplateCreateOrUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementEmailTemplateCreateOrUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
