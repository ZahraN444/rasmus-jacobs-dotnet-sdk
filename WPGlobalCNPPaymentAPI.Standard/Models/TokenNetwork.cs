// <copyright file="TokenNetwork.cs" company="APIMatic">
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
    /// TokenNetwork.
    /// </summary>
    public class TokenNetwork : BasePaymentMethod
    {
        private string token;
        private string eci;
        private string cryptogram;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "token", false },
            { "eci", false },
            { "cryptogram", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenNetwork"/> class.
        /// </summary>
        public TokenNetwork()
        {
            this.Type = "token/network";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenNetwork"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="token">token.</param>
        /// <param name="tokenType">tokenType.</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        /// <param name="eci">eci.</param>
        /// <param name="cryptogram">cryptogram.</param>
        public TokenNetwork(
            string type = "token/network",
            string token = null,
            Models.NetworkTokenTypeEnum? tokenType = null,
            int? expiryMonth = null,
            int? expiryYear = null,
            string eci = null,
            string cryptogram = null)
            : base(
                type)
        {
            if (token != null)
            {
                this.Token = token;
            }

            this.TokenType = tokenType;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            if (eci != null)
            {
                this.Eci = eci;
            }

            if (cryptogram != null)
            {
                this.Cryptogram = cryptogram;
            }

        }

        /// <summary>
        /// The token issued by the card brand.
        /// </summary>
        [JsonProperty("token")]
        public string Token
        {
            get
            {
                return this.token;
            }

            set
            {
                this.shouldSerialize["token"] = true;
                this.token = value;
            }
        }

        /// <summary>
        /// Gets or sets TokenType.
        /// </summary>
        [JsonProperty("tokenType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.NetworkTokenTypeEnum? TokenType { get; set; }

        /// <summary>
        /// The expiry month of the network token.
        /// </summary>
        [JsonProperty("expiryMonth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiryMonth { get; set; }

        /// <summary>
        /// The expiry year of the network token.
        /// </summary>
        [JsonProperty("expiryYear", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiryYear { get; set; }

        /// <summary>
        /// The electronic commerce indicator you get from the issuer.
        /// </summary>
        [JsonProperty("eci")]
        public string Eci
        {
            get
            {
                return this.eci;
            }

            set
            {
                this.shouldSerialize["eci"] = true;
                this.eci = value;
            }
        }

        /// <summary>
        /// Unique value to the token, merchant, and individual transaction generated by the card network
        /// </summary>
        [JsonProperty("cryptogram")]
        public string Cryptogram
        {
            get
            {
                return this.cryptogram;
            }

            set
            {
                this.shouldSerialize["cryptogram"] = true;
                this.cryptogram = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TokenNetwork : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetToken()
        {
            this.shouldSerialize["token"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEci()
        {
            this.shouldSerialize["eci"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCryptogram()
        {
            this.shouldSerialize["cryptogram"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeToken()
        {
            return this.shouldSerialize["token"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEci()
        {
            return this.shouldSerialize["eci"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCryptogram()
        {
            return this.shouldSerialize["cryptogram"];
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
            return obj is TokenNetwork other &&                ((this.Token == null && other.Token == null) || (this.Token?.Equals(other.Token) == true)) &&
                ((this.TokenType == null && other.TokenType == null) || (this.TokenType?.Equals(other.TokenType) == true)) &&
                ((this.ExpiryMonth == null && other.ExpiryMonth == null) || (this.ExpiryMonth?.Equals(other.ExpiryMonth) == true)) &&
                ((this.ExpiryYear == null && other.ExpiryYear == null) || (this.ExpiryYear?.Equals(other.ExpiryYear) == true)) &&
                ((this.Eci == null && other.Eci == null) || (this.Eci?.Equals(other.Eci) == true)) &&
                ((this.Cryptogram == null && other.Cryptogram == null) || (this.Cryptogram?.Equals(other.Cryptogram) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Token = {(this.Token == null ? "null" : this.Token)}");
            toStringOutput.Add($"this.TokenType = {(this.TokenType == null ? "null" : this.TokenType.ToString())}");
            toStringOutput.Add($"this.ExpiryMonth = {(this.ExpiryMonth == null ? "null" : this.ExpiryMonth.ToString())}");
            toStringOutput.Add($"this.ExpiryYear = {(this.ExpiryYear == null ? "null" : this.ExpiryYear.ToString())}");
            toStringOutput.Add($"this.Eci = {(this.Eci == null ? "null" : this.Eci)}");
            toStringOutput.Add($"this.Cryptogram = {(this.Cryptogram == null ? "null" : this.Cryptogram)}");

            base.ToString(toStringOutput);
        }
    }
}