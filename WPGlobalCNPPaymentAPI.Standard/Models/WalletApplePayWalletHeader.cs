// <copyright file="WalletApplePayWalletHeader.cs" company="APIMatic">
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
    /// WalletApplePayWalletHeader.
    /// </summary>
    public class WalletApplePayWalletHeader
    {
        private string ephemeralPublicKey;
        private string publicKeyHash;
        private string transactionId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "ephemeralPublicKey", false },
            { "publicKeyHash", false },
            { "transactionId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApplePayWalletHeader"/> class.
        /// </summary>
        public WalletApplePayWalletHeader()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletApplePayWalletHeader"/> class.
        /// </summary>
        /// <param name="ephemeralPublicKey">ephemeralPublicKey.</param>
        /// <param name="publicKeyHash">publicKeyHash.</param>
        /// <param name="transactionId">transactionId.</param>
        public WalletApplePayWalletHeader(
            string ephemeralPublicKey = null,
            string publicKeyHash = null,
            string transactionId = null)
        {
            if (ephemeralPublicKey != null)
            {
                this.EphemeralPublicKey = ephemeralPublicKey;
            }

            if (publicKeyHash != null)
            {
                this.PublicKeyHash = publicKeyHash;
            }

            if (transactionId != null)
            {
                this.TransactionId = transactionId;
            }

        }

        /// <summary>
        /// Gets or sets EphemeralPublicKey.
        /// </summary>
        [JsonProperty("ephemeralPublicKey")]
        public string EphemeralPublicKey
        {
            get
            {
                return this.ephemeralPublicKey;
            }

            set
            {
                this.shouldSerialize["ephemeralPublicKey"] = true;
                this.ephemeralPublicKey = value;
            }
        }

        /// <summary>
        /// Gets or sets PublicKeyHash.
        /// </summary>
        [JsonProperty("publicKeyHash")]
        public string PublicKeyHash
        {
            get
            {
                return this.publicKeyHash;
            }

            set
            {
                this.shouldSerialize["publicKeyHash"] = true;
                this.publicKeyHash = value;
            }
        }

        /// <summary>
        /// Gets or sets TransactionId.
        /// </summary>
        [JsonProperty("transactionId")]
        public string TransactionId
        {
            get
            {
                return this.transactionId;
            }

            set
            {
                this.shouldSerialize["transactionId"] = true;
                this.transactionId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WalletApplePayWalletHeader : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEphemeralPublicKey()
        {
            this.shouldSerialize["ephemeralPublicKey"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPublicKeyHash()
        {
            this.shouldSerialize["publicKeyHash"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTransactionId()
        {
            this.shouldSerialize["transactionId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEphemeralPublicKey()
        {
            return this.shouldSerialize["ephemeralPublicKey"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePublicKeyHash()
        {
            return this.shouldSerialize["publicKeyHash"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTransactionId()
        {
            return this.shouldSerialize["transactionId"];
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
            return obj is WalletApplePayWalletHeader other &&                ((this.EphemeralPublicKey == null && other.EphemeralPublicKey == null) || (this.EphemeralPublicKey?.Equals(other.EphemeralPublicKey) == true)) &&
                ((this.PublicKeyHash == null && other.PublicKeyHash == null) || (this.PublicKeyHash?.Equals(other.PublicKeyHash) == true)) &&
                ((this.TransactionId == null && other.TransactionId == null) || (this.TransactionId?.Equals(other.TransactionId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EphemeralPublicKey = {(this.EphemeralPublicKey == null ? "null" : this.EphemeralPublicKey)}");
            toStringOutput.Add($"this.PublicKeyHash = {(this.PublicKeyHash == null ? "null" : this.PublicKeyHash)}");
            toStringOutput.Add($"this.TransactionId = {(this.TransactionId == null ? "null" : this.TransactionId)}");
        }
    }
}