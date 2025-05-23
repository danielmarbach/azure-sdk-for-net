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

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class FlinkJobProperties : IUtf8JsonSerializable, IJsonModel<FlinkJobProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FlinkJobProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<FlinkJobProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlinkJobProperties)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(RunId))
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId);
            }
            if (Optional.IsDefined(JobName))
            {
                writer.WritePropertyName("jobName"u8);
                writer.WriteStringValue(JobName);
            }
            if (Optional.IsDefined(JobJarDirectory))
            {
                writer.WritePropertyName("jobJarDirectory"u8);
                writer.WriteStringValue(JobJarDirectory);
            }
            if (Optional.IsDefined(JarName))
            {
                writer.WritePropertyName("jarName"u8);
                writer.WriteStringValue(JarName);
            }
            if (Optional.IsDefined(EntryClass))
            {
                writer.WritePropertyName("entryClass"u8);
                writer.WriteStringValue(EntryClass);
            }
            if (Optional.IsDefined(Args))
            {
                writer.WritePropertyName("args"u8);
                writer.WriteStringValue(Args);
            }
            if (Optional.IsDefined(SavePointName))
            {
                writer.WritePropertyName("savePointName"u8);
                writer.WriteStringValue(SavePointName);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            if (Optional.IsCollectionDefined(FlinkConfiguration))
            {
                writer.WritePropertyName("flinkConfiguration"u8);
                writer.WriteStartObject();
                foreach (var item in FlinkConfiguration)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsDefined(JobOutput))
            {
                writer.WritePropertyName("jobOutput"u8);
                writer.WriteStringValue(JobOutput);
            }
            if (options.Format != "W" && Optional.IsDefined(ActionResult))
            {
                writer.WritePropertyName("actionResult"u8);
                writer.WriteStringValue(ActionResult);
            }
            if (options.Format != "W" && Optional.IsDefined(LastSavePoint))
            {
                writer.WritePropertyName("lastSavePoint"u8);
                writer.WriteStringValue(LastSavePoint);
            }
        }

        FlinkJobProperties IJsonModel<FlinkJobProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FlinkJobProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFlinkJobProperties(document.RootElement, options);
        }

        internal static FlinkJobProperties DeserializeFlinkJobProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string runId = default;
            string jobName = default;
            string jobJarDirectory = default;
            string jarName = default;
            string entryClass = default;
            string args = default;
            string savePointName = default;
            FlinkJobAction? action = default;
            IDictionary<string, string> flinkConfiguration = default;
            string jobId = default;
            string status = default;
            string jobOutput = default;
            string actionResult = default;
            string lastSavePoint = default;
            ClusterJobType jobType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobName"u8))
                {
                    jobName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobJarDirectory"u8))
                {
                    jobJarDirectory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jarName"u8))
                {
                    jarName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entryClass"u8))
                {
                    entryClass = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("args"u8))
                {
                    args = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("savePointName"u8))
                {
                    savePointName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new FlinkJobAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("flinkConfiguration"u8))
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
                    flinkConfiguration = dictionary;
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutput"u8))
                {
                    jobOutput = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionResult"u8))
                {
                    actionResult = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastSavePoint"u8))
                {
                    lastSavePoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobType"u8))
                {
                    jobType = new ClusterJobType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new FlinkJobProperties(
                jobType,
                serializedAdditionalRawData,
                runId,
                jobName,
                jobJarDirectory,
                jarName,
                entryClass,
                args,
                savePointName,
                action,
                flinkConfiguration ?? new ChangeTrackingDictionary<string, string>(),
                jobId,
                status,
                jobOutput,
                actionResult,
                lastSavePoint);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RunId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  runId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RunId))
                {
                    builder.Append("  runId: ");
                    if (RunId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{RunId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{RunId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(JobName))
                {
                    builder.Append("  jobName: ");
                    if (JobName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{JobName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{JobName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobJarDirectory), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobJarDirectory: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(JobJarDirectory))
                {
                    builder.Append("  jobJarDirectory: ");
                    if (JobJarDirectory.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{JobJarDirectory}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{JobJarDirectory}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JarName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jarName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(JarName))
                {
                    builder.Append("  jarName: ");
                    if (JarName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{JarName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{JarName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EntryClass), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  entryClass: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EntryClass))
                {
                    builder.Append("  entryClass: ");
                    if (EntryClass.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EntryClass}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EntryClass}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Args), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  args: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Args))
                {
                    builder.Append("  args: ");
                    if (Args.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Args}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Args}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SavePointName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  savePointName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SavePointName))
                {
                    builder.Append("  savePointName: ");
                    if (SavePointName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SavePointName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SavePointName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Action), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  action: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Action))
                {
                    builder.Append("  action: ");
                    builder.AppendLine($"'{Action.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FlinkConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  flinkConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(FlinkConfiguration))
                {
                    if (FlinkConfiguration.Any())
                    {
                        builder.Append("  flinkConfiguration: ");
                        builder.AppendLine("{");
                        foreach (var item in FlinkConfiguration)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(JobId))
                {
                    builder.Append("  jobId: ");
                    if (JobId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{JobId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{JobId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("  status: ");
                    if (Status.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Status}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Status}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobOutput), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobOutput: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(JobOutput))
                {
                    builder.Append("  jobOutput: ");
                    if (JobOutput.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{JobOutput}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{JobOutput}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ActionResult), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  actionResult: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ActionResult))
                {
                    builder.Append("  actionResult: ");
                    if (ActionResult.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ActionResult}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ActionResult}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LastSavePoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  lastSavePoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LastSavePoint))
                {
                    builder.Append("  lastSavePoint: ");
                    if (LastSavePoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LastSavePoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LastSavePoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(JobType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  jobType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  jobType: ");
                builder.AppendLine($"'{JobType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<FlinkJobProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHDInsightContainersContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(FlinkJobProperties)} does not support writing '{options.Format}' format.");
            }
        }

        FlinkJobProperties IPersistableModel<FlinkJobProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FlinkJobProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeFlinkJobProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FlinkJobProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<FlinkJobProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
