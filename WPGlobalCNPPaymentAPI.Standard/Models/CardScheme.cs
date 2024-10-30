// <copyright file="CardScheme.cs" company="APIMatic">
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
    /// CardScheme.
    /// </summary>
    public class CardScheme : BasePaymentMethod
    {
        private string cardHolderName;
        private bool? returnSecurityToken;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cardHolderName", false },
            { "returnSecurityToken", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardScheme"/> class.
        /// </summary>
        public CardScheme()
        {
            this.Type = "card/scheme";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardScheme"/> class.
        /// </summary>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="cardVerificationCode">cardVerificationCode.</param>
        /// <param name="expiryMonth">expiryMonth.</param>
        /// <param name="expiryYear">expiryYear.</param>
        /// <param name="type">type.</param>
        /// <param name="cardHolderName">cardHolderName.</param>
        /// <param name="returnSecurityToken">returnSecurityToken.</param>
        public CardScheme(
            string cardNumber,
            string cardVerificationCode,
            int expiryMonth,
            int expiryYear,
            string type = "card/scheme",
            string cardHolderName = null,
            bool? returnSecurityToken = null)
            : base(
                type)
        {
            if (cardHolderName != null)
            {
                this.CardHolderName = cardHolderName;
            }

            this.CardNumber = cardNumber;
            this.CardVerificationCode = cardVerificationCode;
            this.ExpiryMonth = expiryMonth;
            this.ExpiryYear = expiryYear;
            if (returnSecurityToken != null)
            {
                this.ReturnSecurityToken = returnSecurityToken;
            }

        }

        /// <summary>
        /// The name of the CardHolder
        /// </summary>
        [JsonProperty("cardHolderName")]
        public string CardHolderName
        {
            get
            {
                return this.cardHolderName;
            }

            set
            {
                this.shouldSerialize["cardHolderName"] = true;
                this.cardHolderName = value;
            }
        }

        /// <summary>
        /// The Card Number
        /// </summary>
        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// The card verification code (same as CVV or CID)
        /// </summary>
        [JsonProperty("cardVerificationCode")]
        public string CardVerificationCode { get; set; }

        /// <summary>
        /// The Card Expiry Month (1-12)
        /// </summary>
        [JsonProperty("expiryMonth")]
        public int ExpiryMonth { get; set; }

        /// <summary>
        /// The Card Expiry Year
        /// </summary>
        [JsonProperty("expiryYear")]
        public int ExpiryYear { get; set; }

        /// <summary>
        /// If true, return a new or existing Security Token for this Card Number
        /// </summary>
        [JsonProperty("returnSecurityToken")]
        public bool? ReturnSecurityToken
        {
            get
            {
                return this.returnSecurityToken;
            }

            set
            {
                this.shouldSerialize["returnSecurityToken"] = true;
                this.returnSecurityToken = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardScheme : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardHolderName()
        {
            this.shouldSerialize["cardHolderName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetReturnSecurityToken()
        {
            this.shouldSerialize["returnSecurityToken"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardHolderName()
        {
            return this.shouldSerialize["cardHolderName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeReturnSecurityToken()
        {
            return this.shouldSerialize["returnSecurityToken"];
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
            return obj is CardScheme other &&                ((this.CardHolderName == null && other.CardHolderName == null) || (this.CardHolderName?.Equals(other.CardHolderName) == true)) &&
                ((this.CardNumber == null && other.CardNumber == null) || (this.CardNumber?.Equals(other.CardNumber) == true)) &&
                ((this.CardVerificationCode == null && other.CardVerificationCode == null) || (this.CardVerificationCode?.Equals(other.CardVerificationCode) == true)) &&
                this.ExpiryMonth.Equals(other.ExpiryMonth) &&
                this.ExpiryYear.Equals(other.ExpiryYear) &&
                ((this.ReturnSecurityToken == null && other.ReturnSecurityToken == null) || (this.ReturnSecurityToken?.Equals(other.ReturnSecurityToken) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CardHolderName = {(this.CardHolderName == null ? "null" : this.CardHolderName)}");
            toStringOutput.Add($"this.CardNumber = {(this.CardNumber == null ? "null" : this.CardNumber)}");
            toStringOutput.Add($"this.CardVerificationCode = {(this.CardVerificationCode == null ? "null" : this.CardVerificationCode)}");
            toStringOutput.Add($"this.ExpiryMonth = {this.ExpiryMonth}");
            toStringOutput.Add($"this.ExpiryYear = {this.ExpiryYear}");
            toStringOutput.Add($"this.ReturnSecurityToken = {(this.ReturnSecurityToken == null ? "null" : this.ReturnSecurityToken.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}