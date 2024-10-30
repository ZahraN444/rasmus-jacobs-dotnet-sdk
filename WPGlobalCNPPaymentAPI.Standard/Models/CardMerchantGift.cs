// <copyright file="CardMerchantGift.cs" company="APIMatic">
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
    /// CardMerchantGift.
    /// </summary>
    public class CardMerchantGift : BasePaymentMethod
    {
        private string cardNumber;
        private string cardVerificationCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "cardNumber", false },
            { "cardVerificationCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMerchantGift"/> class.
        /// </summary>
        public CardMerchantGift()
        {
            this.Type = "card/merchant_gift";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardMerchantGift"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="cardVerificationCode">cardVerificationCode.</param>
        public CardMerchantGift(
            string type = "card/merchant_gift",
            string cardNumber = null,
            string cardVerificationCode = null)
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardMerchantGift : ({string.Join(", ", toStringOutput)})";
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
            return obj is CardMerchantGift other &&                ((this.CardNumber == null && other.CardNumber == null) || (this.CardNumber?.Equals(other.CardNumber) == true)) &&
                ((this.CardVerificationCode == null && other.CardVerificationCode == null) || (this.CardVerificationCode?.Equals(other.CardVerificationCode) == true)) &&
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

            base.ToString(toStringOutput);
        }
    }
}