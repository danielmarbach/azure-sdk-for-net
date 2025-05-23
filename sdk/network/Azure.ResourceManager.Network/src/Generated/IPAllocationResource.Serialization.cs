// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class IPAllocationResource : IJsonModel<IPAllocationData>
    {
        void IJsonModel<IPAllocationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<IPAllocationData>)Data).Write(writer, options);

        IPAllocationData IJsonModel<IPAllocationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<IPAllocationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<IPAllocationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<IPAllocationData>(Data, options, AzureResourceManagerNetworkContext.Default);

        IPAllocationData IPersistableModel<IPAllocationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<IPAllocationData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<IPAllocationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<IPAllocationData>)Data).GetFormatFromOptions(options);
    }
}
