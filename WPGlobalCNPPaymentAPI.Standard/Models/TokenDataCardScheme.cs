// <copyright file="TokenDataCardScheme.cs" company="APIMatic">
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
    /// TokenDataCardScheme.
    /// </summary>
    public class TokenDataCardScheme : BaseDataToTokenize
    {
        private string cardNumber;
        private string cardVerificationCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cardNumber", false },
            { "cardVerificationCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDataCardScheme"/> class.
        /// </summary>
        public TokenDataCardScheme()
        {
            this.Type = "card/scheme";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDataCardScheme"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="cardVerificationCode">cardVerificationCode.</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        public TokenDataCardScheme(
            string type = "card/scheme",
            string cardNumber = null,
            string cardVerificationCode = null,
            int? expiryMonth = null,
            int? expiryYear = null)
            : base(
                type)
        {
            if (cardNumber != null)
            {
                this.CardNumber = cardNumber;
            }

            if (cardVerificationCode != null)
            {
                this.CardVerificationCode = cardVerificationCode;
            }

            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
        }

        /// <summary>
        /// The Card Number
        /// </summary>
        [JsonProperty("cardNumber")]
        public string CardNumber
        {
            get
            {
                return this.cardNumber;
            }

            set
            {
                this.shouldSerialize["cardNumber"] = true;
                this.cardNumber = value;
            }
        }

        /// <summary>
        /// The card verification code (same as CVV or CID)
        /// </summary>
        [JsonProperty("cardVerificationCode")]
        public string CardVerificationCode
        {
            get
            {
                return this.cardVerificationCode;
            }

            set
            {
                this.shouldSerialize["cardVerificationCode"] = true;
                this.cardVerificationCode = value;
            }
        }

        /// <summary>
        /// The Card Expiry Month
        /// </summary>
        [JsonProperty("expiryMonth", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiryMonth { get; set; }

        /// <summary>
        /// The Card Expiry Year
        /// </summary>
        [JsonProperty("expiryYear", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExpiryYear { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TokenDataCardScheme : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardNumber()
        {
            this.shouldSerialize["cardNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardVerificationCode()
        {
            this.shouldSerialize["cardVerificationCode"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardNumber()
        {
            return this.shouldSerialize["cardNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardVerificationCode()
        {
            return this.shouldSerialize["cardVerificationCode"];
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
            return obj is TokenDataCardScheme other &&                ((this.CardNumber == null && other.CardNumber == null) || (this.CardNumber?.Equals(other.CardNumber) == true)) &&
                ((this.CardVerificationCode == null && other.CardVerificationCode == null) || (this.CardVerificationCode?.Equals(other.CardVerificationCode) == true)) &&
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
            toStringOutput.Add($"this.CardNumber = {(this.CardNumber == null ? "null" : this.CardNumber)}");
            toStringOutput.Add($"this.CardVerificationCode = {(this.CardVerificationCode == null ? "null" : this.CardVerificationCode)}");
            toStringOutput.Add($"this.ExpiryMonth = {(this.ExpiryMonth == null ? "null" : this.ExpiryMonth.ToString())}");
            toStringOutput.Add($"this.ExpiryYear = {(this.ExpiryYear == null ? "null" : this.ExpiryYear.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}