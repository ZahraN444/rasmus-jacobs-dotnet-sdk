// <copyright file="WalletApplePay.cs" company="APIMatic">
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
    /// WalletApplePay.
    /// </summary>
    public class WalletApplePay : BasePaymentMethod
    {
        private string signature;
        private string version;
        private string data;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "signature", false },
            { "version", false },
            { "data", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApplePay"/> class.
        /// </summary>
        public WalletApplePay()
        {
            this.Type = "wallet/applepay";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApplePay"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="header">header.</param>
        /// <param name="signature">signature.</param>
        /// <param name="version">version.</param>
        /// <param name="data">data.</param>
        public WalletApplePay(
            string type = "wallet/applepay",
            Models.WalletApplePayWalletHeader header = null,
            string signature = null,
            string version = null,
            string data = null)
            : base(
                type)
        {
            this.Header = header;
            if (signature != null)
            {
                this.Signature = signature;
            }

            if (version != null)
            {
                this.Version = version;
            }

            if (data != null)
            {
                this.Data = data;
            }

        }

        /// <summary>
        /// Gets or sets Header.
        /// </summary>
        [JsonProperty("header", NullValueHandling = NullValueHandling.Ignore)]
        public Models.WalletApplePayWalletHeader Header { get; set; }

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
        /// Gets or sets Version.
        /// </summary>
        [JsonProperty("version")]
        public string Version
        {
            get
            {
                return this.version;
            }

            set
            {
                this.shouldSerialize["version"] = true;
                this.version = value;
            }
        }

        /// <summary>
        /// Gets or sets Data.
        /// </summary>
        [JsonProperty("data")]
        public string Data
        {
            get
            {
                return this.data;
            }

            set
            {
                this.shouldSerialize["data"] = true;
                this.data = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WalletApplePay : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetVersion()
        {
            this.shouldSerialize["version"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetData()
        {
            this.shouldSerialize["data"] = false;
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
        public bool ShouldSerializeVersion()
        {
            return this.shouldSerialize["version"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeData()
        {
            return this.shouldSerialize["data"];
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
            return obj is WalletApplePay other &&                ((this.Header == null && other.Header == null) || (this.Header?.Equals(other.Header) == true)) &&
                ((this.Signature == null && other.Signature == null) || (this.Signature?.Equals(other.Signature) == true)) &&
                ((this.Version == null && other.Version == null) || (this.Version?.Equals(other.Version) == true)) &&
                ((this.Data == null && other.Data == null) || (this.Data?.Equals(other.Data) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Header = {(this.Header == null ? "null" : this.Header.ToString())}");
            toStringOutput.Add($"this.Signature = {(this.Signature == null ? "null" : this.Signature)}");
            toStringOutput.Add($"this.Version = {(this.Version == null ? "null" : this.Version)}");
            toStringOutput.Add($"this.Data = {(this.Data == null ? "null" : this.Data)}");

            base.ToString(toStringOutput);
        }
    }
}