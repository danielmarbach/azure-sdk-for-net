// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.WeightsAndBiases.Models
{
    /// <summary> Defines the type of Single Sign-On (SSO) mechanism being used. </summary>
    public readonly partial struct WeightsAndBiasesSingleSignOnType : IEquatable<WeightsAndBiasesSingleSignOnType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WeightsAndBiasesSingleSignOnType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WeightsAndBiasesSingleSignOnType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SamlValue = "Saml";
        private const string OpenIdValue = "OpenId";

        /// <summary> Security Assertion Markup Language (SAML) based Single Sign-On. </summary>
        public static WeightsAndBiasesSingleSignOnType Saml { get; } = new WeightsAndBiasesSingleSignOnType(SamlValue);
        /// <summary> OpenID Connect based Single Sign-On. </summary>
        public static WeightsAndBiasesSingleSignOnType OpenId { get; } = new WeightsAndBiasesSingleSignOnType(OpenIdValue);
        /// <summary> Determines if two <see cref="WeightsAndBiasesSingleSignOnType"/> values are the same. </summary>
        public static bool operator ==(WeightsAndBiasesSingleSignOnType left, WeightsAndBiasesSingleSignOnType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WeightsAndBiasesSingleSignOnType"/> values are not the same. </summary>
        public static bool operator !=(WeightsAndBiasesSingleSignOnType left, WeightsAndBiasesSingleSignOnType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WeightsAndBiasesSingleSignOnType"/>. </summary>
        public static implicit operator WeightsAndBiasesSingleSignOnType(string value) => new WeightsAndBiasesSingleSignOnType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WeightsAndBiasesSingleSignOnType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WeightsAndBiasesSingleSignOnType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
