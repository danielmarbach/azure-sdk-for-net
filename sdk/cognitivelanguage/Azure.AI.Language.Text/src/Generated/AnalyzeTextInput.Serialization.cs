// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    [PersistableModelProxy(typeof(UnknownAnalyzeTextInput))]
    public partial class AnalyzeTextInput : IUtf8JsonSerializable, IJsonModel<AnalyzeTextInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AnalyzeTextInput>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AnalyzeTextInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextInput)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        AnalyzeTextInput IJsonModel<AnalyzeTextInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AnalyzeTextInput)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAnalyzeTextInput(document.RootElement, options);
        }

        internal static AnalyzeTextInput DeserializeAnalyzeTextInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "EntityLinking": return TextEntityLinkingInput.DeserializeTextEntityLinkingInput(element, options);
                    case "EntityRecognition": return TextEntityRecognitionInput.DeserializeTextEntityRecognitionInput(element, options);
                    case "KeyPhraseExtraction": return TextKeyPhraseExtractionInput.DeserializeTextKeyPhraseExtractionInput(element, options);
                    case "LanguageDetection": return TextLanguageDetectionInput.DeserializeTextLanguageDetectionInput(element, options);
                    case "PiiEntityRecognition": return TextPiiEntitiesRecognitionInput.DeserializeTextPiiEntitiesRecognitionInput(element, options);
                    case "SentimentAnalysis": return TextSentimentAnalysisInput.DeserializeTextSentimentAnalysisInput(element, options);
                }
            }
            return UnknownAnalyzeTextInput.DeserializeUnknownAnalyzeTextInput(element, options);
        }

        BinaryData IPersistableModel<AnalyzeTextInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextInput)} does not support writing '{options.Format}' format.");
            }
        }

        AnalyzeTextInput IPersistableModel<AnalyzeTextInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AnalyzeTextInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAnalyzeTextInput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AnalyzeTextInput)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AnalyzeTextInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AnalyzeTextInput FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAnalyzeTextInput(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
