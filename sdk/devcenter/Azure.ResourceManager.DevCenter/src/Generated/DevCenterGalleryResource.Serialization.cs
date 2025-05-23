// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevCenter
{
    public partial class DevCenterGalleryResource : IJsonModel<DevCenterGalleryData>
    {
        void IJsonModel<DevCenterGalleryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevCenterGalleryData>)Data).Write(writer, options);

        DevCenterGalleryData IJsonModel<DevCenterGalleryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevCenterGalleryData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DevCenterGalleryData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<DevCenterGalleryData>(Data, options, AzureResourceManagerDevCenterContext.Default);

        DevCenterGalleryData IPersistableModel<DevCenterGalleryData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevCenterGalleryData>(data, options, AzureResourceManagerDevCenterContext.Default);

        string IPersistableModel<DevCenterGalleryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevCenterGalleryData>)Data).GetFormatFromOptions(options);
    }
}
