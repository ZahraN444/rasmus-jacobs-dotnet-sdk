// <copyright file="TokenWPSecurity.cs" company="APIMatic">
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
    /// TokenWPSecurity.
    /// </summary>
    public class TokenWPSecurity : BasePaymentMethod
    {
        private string tokenValue;
        private int? expiryMonth;
        private int? expiryYear;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "tokenValue", false },
            { "expiryMonth", false },
            { "expiryYear", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenWPSecurity"/> class.
        /// </summary>
        public TokenWPSecurity()
        {
            this.Type = "token/wp_security";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenWPSecurity"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="tokenValue">tokenValue.</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        public TokenWPSecurity(
            string type = "token/wp_security",
            string tokenValue = null,
            int? expiryMonth = null,
            int? expiryYear = null)
            : base(
                type)
        {
            if (tokenValue != null)
            {
                this.TokenValue = tokenValue;
            }

            if (expiryMonth != null)
            {
                this.ExpiryMonth = expiryMonth;
            }

            if (expiryYear != null)
            {
                this.ExpiryYear = expiryYear;
            }

        }

        /// <summary>
        /// The Worldpay Security Token representing the Card No
        /// </summary>
        [JsonProperty("tokenValue")]
        public string TokenValue
        {
            get
            {
                return this.tokenValue;
            }

            set
            {
                this.shouldSerialize["tokenValue"] = true;
                this.tokenValue = value;
            }
        }

        /// <summary>
        /// The Card Expiry Month (if suppplied will be used in place of the value stored with the token)
        /// </summary>
        [JsonProperty("expiryMonth")]
        public int? ExpiryMonth
        {
            get
            {
                return this.expiryMonth;
            }

            set
            {
                this.shouldSerialize["expiryMonth"] = true;
                this.expiryMonth = value;
            }
        }

        /// <summary>
        /// The Card Expiry Year (if suppplied will be used in place of the value stored with the token)
        /// </summary>
        [JsonProperty("expiryYear")]
        public int? ExpiryYear
        {
            get
            {
                return this.expiryYear;
            }

            set
            {
                this.shouldSerialize["expiryYear"] = true;
                this.expiryYear = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TokenWPSecurity : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTokenValue()
        {
            this.shouldSerialize["tokenValue"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpiryMonth()
        {
            this.shouldSerialize["expiryMonth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetExpiryYear()
        {
            this.shouldSerialize["expiryYear"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTokenValue()
        {
            return this.shouldSerialize["tokenValue"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiryMonth()
        {
            return this.shouldSerialize["expiryMonth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeExpiryYear()
        {
            return this.shouldSerialize["expiryYear"];
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
            return obj is TokenWPSecurity other &&                ((this.TokenValue == null && other.TokenValue == null) || (this.TokenValue?.Equals(other.TokenValue) == true)) &&
                ((this.ExpiryMonth == null && other.ExpiryMonth == null) || (this.ExpiryMonth?.Equals(other.ExpiryMonth) == true)) &&
                ((this.ExpiryYear == null && other.ExpiryYear == null) || (this.ExpiryYear?.Equals(other.ExpiryYear) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TokenValue = {(this.TokenValue == null ? "null" : this.TokenValue)}");
            toStringOutput.Add($"this.ExpiryMonth = {(this.ExpiryMonth == null ? "null" : this.ExpiryMonth.ToString())}");
            toStringOutput.Add($"this.ExpiryYear = {(this.ExpiryYear == null ? "null" : this.ExpiryYear.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}