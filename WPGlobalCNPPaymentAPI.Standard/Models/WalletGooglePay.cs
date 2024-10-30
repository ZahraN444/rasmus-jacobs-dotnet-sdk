// <copyright file="WalletGooglePay.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WPGlobalCNPPaymentAPI.Standard;
using WPGlobalCNPPaymentAPI.Standard.Utilities;

namespace WPGlobalCNPPaymentAPI.Standard.Models
{
    /// <summary>
    /// WalletGooglePay.
    /// </summary>
    public class WalletGooglePay : BasePaymentMethod
    {
        private string protocolVersion;
        private string signature;
        private string signedMessage;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "protocolVersion", false },
            { "signature", false },
            { "signedMessage", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletGooglePay"/> class.
        /// </summary>
        public WalletGooglePay()
        {
            this.Type = "wallet/googlepay";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletGooglePay"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="protocolVersion">protocolVersion.</param>
        /// <param name="signature">signature.</param>
        /// <param name="signedMessage">signedMessage.</param>
        public WalletGooglePay(
            string type = "wallet/googlepay",
            string protocolVersion = null,
            string signature = null,
            string signedMessage = null)
            : base(
                type)
        {
            if (protocolVersion != null)
            {
                this.ProtocolVersion = protocolVersion;
            }

            if (signature != null)
            {
                this.Signature = signature;
            }

            if (signedMessage != null)
            {
                this.SignedMessage = signedMessage;
            }

        }

        /// <summary>
        /// Gets or sets ProtocolVersion.
        /// </summary>
        [JsonProperty("protocolVersion")]
        public string ProtocolVersion
        {
            get
            {
                return this.protocolVersion;
            }

            set
            {
                this.shouldSerialize["protocolVersion"] = true;
                this.protocolVersion = value;
            }
        }

        /// <summary>
        /// Gets or sets Signature.
        /// </summary>
        [JsonProperty("signature")]
        public string Signature
        {
            get
            {
                return this.signature;
            }

            set
            {
                this.shouldSerialize["signature"] = true;
                this.signature = value;
            }
        }

        /// <summary>
        /// Gets or sets SignedMessage.
        /// </summary>
        [JsonProperty("signedMessage")]
        public string SignedMessage
        {
            get
            {
                return this.signedMessage;
            }

            set
            {
                this.shouldSerialize["signedMessage"] = true;
                this.signedMessage = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WalletGooglePay : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProtocolVersion()
        {
            this.shouldSerialize["protocolVersion"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSignature()
        {
            this.shouldSerialize["signature"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSignedMessage()
        {
            this.shouldSerialize["signedMessage"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProtocolVersion()
        {
            return this.shouldSerialize["protocolVersion"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSignature()
        {
            return this.shouldSerialize["signature"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSignedMessage()
        {
            return this.shouldSerialize["signedMessage"];
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }
            return obj is WalletGooglePay other &&                ((this.ProtocolVersion == null && other.ProtocolVersion == null) || (this.ProtocolVersion?.Equals(other.ProtocolVersion) == true)) &&
                ((this.Signature == null && other.Signature == null) || (this.Signature?.Equals(other.Signature) == true)) &&
                ((this.SignedMessage == null && other.SignedMessage == null) || (this.SignedMessage?.Equals(other.SignedMessage) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ProtocolVersion = {(this.ProtocolVersion == null ? "null" : this.ProtocolVersion)}");
            toStringOutput.Add($"this.Signature = {(this.Signature == null ? "null" : this.Signature)}");
            toStringOutput.Add($"this.SignedMessage = {(this.SignedMessage == null ? "null" : this.SignedMessage)}");

            base.ToString(toStringOutput);
        }
    }
}