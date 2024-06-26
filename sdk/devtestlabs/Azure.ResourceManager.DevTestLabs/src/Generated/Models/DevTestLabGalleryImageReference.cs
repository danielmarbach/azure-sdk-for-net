// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> The reference information for an Azure Marketplace image. </summary>
    public partial class DevTestLabGalleryImageReference
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabGalleryImageReference"/>. </summary>
        public DevTestLabGalleryImageReference()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabGalleryImageReference"/>. </summary>
        /// <param name="offer"> The offer of the gallery image. </param>
        /// <param name="publisher"> The publisher of the gallery image. </param>
        /// <param name="sku"> The SKU of the gallery image. </param>
        /// <param name="osType"> The OS type of the gallery image. </param>
        /// <param name="version"> The version of the gallery image. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabGalleryImageReference(string offer, string publisher, string sku, string osType, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            OSType = osType;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The offer of the gallery image. </summary>
        public string Offer { get; set; }
        /// <summary> The publisher of the gallery image. </summary>
        public string Publisher { get; set; }
        /// <summary> The SKU of the gallery image. </summary>
        public string Sku { get; set; }
        /// <summary> The OS type of the gallery image. </summary>
        public string OSType { get; set; }
        /// <summary> The version of the gallery image. </summary>
        public string Version { get; set; }
    }
}
