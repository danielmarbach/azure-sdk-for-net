// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary> Defines available options for the underlying response format of output translation information. </summary>
    public readonly partial struct AudioTranslationFormat : IEquatable<AudioTranslationFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AudioTranslationFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AudioTranslationFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SimpleValue = "json";
        private const string VerboseValue = "verbose_json";
        private const string InternalPlainTextValue = "text";
        private const string SrtValue = "srt";
        private const string VttValue = "vtt";

        /// <summary> Use a response body that is a JSON object containing a single 'text' field for the translation. </summary>
        public static AudioTranslationFormat Simple { get; } = new AudioTranslationFormat(SimpleValue);
        /// <summary>
        /// Use a response body that is a JSON object containing translation text along with timing, segments, and other
        /// metadata.
        /// </summary>
        public static AudioTranslationFormat Verbose { get; } = new AudioTranslationFormat(VerboseValue);
        /// <summary> Use a response body that is plain text in SubRip (SRT) format that also includes timing information. </summary>
        public static AudioTranslationFormat Srt { get; } = new AudioTranslationFormat(SrtValue);
        /// <summary> Use a response body that is plain text in Web Video Text Tracks (VTT) format that also includes timing information. </summary>
        public static AudioTranslationFormat Vtt { get; } = new AudioTranslationFormat(VttValue);
        /// <summary> Determines if two <see cref="AudioTranslationFormat"/> values are the same. </summary>
        public static bool operator ==(AudioTranslationFormat left, AudioTranslationFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AudioTranslationFormat"/> values are not the same. </summary>
        public static bool operator !=(AudioTranslationFormat left, AudioTranslationFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AudioTranslationFormat"/>. </summary>
        public static implicit operator AudioTranslationFormat(string value) => new AudioTranslationFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AudioTranslationFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AudioTranslationFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
