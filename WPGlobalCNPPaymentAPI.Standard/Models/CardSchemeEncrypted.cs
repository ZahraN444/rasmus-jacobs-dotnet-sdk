// <copyright file="CardSchemeEncrypted.cs" company="APIMatic">
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
    /// CardSchemeEncrypted.
    /// </summary>
    public class CardSchemeEncrypted : BasePaymentMethod
    {
        private string encryptedCardNumber;
        private string encryptedCardVerificationCode;
        private string encryptedExpiryMonth;
        private string encryptedExpiryYear;
        private string cardHolderName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "encryptedCardNumber", false },
            { "encryptedCardVerificationCode", false },
            { "encryptedExpiryMonth", false },
            { "encryptedExpiryYear", false },
            { "CardHolderName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CardSchemeEncrypted"/> class.
        /// </summary>
        public CardSchemeEncrypted()
        {
            this.Type = "card/scheme_encrypted";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardSchemeEncrypted"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="encryptedCardNumber">encryptedCardNumber.</param>
        /// <param name="encryptedCardVerificationCode">encryptedCardVerificationCode.</param>
        /// <param name="encryptedExpiryMonth">encryptedExpiryMonth.</param>
        /// <param name="encryptedExpiryYear">encryptedExpiryYear.</param>
        /// <param name="cardHolderName">CardHolderName.</param>
        public CardSchemeEncrypted(
            string type = "card/scheme_encrypted",
            string encryptedCardNumber = null,
            string encryptedCardVerificationCode = null,
            string encryptedExpiryMonth = null,
            string encryptedExpiryYear = null,
            string cardHolderName = null)
            : base(
                type)
        {
            if (encryptedCardNumber != null)
            {
                this.EncryptedCardNumber = encryptedCardNumber;
            }

            if (encryptedCardVerificationCode != null)
            {
                this.EncryptedCardVerificationCode = encryptedCardVerificationCode;
            }

            if (encryptedExpiryMonth != null)
            {
                this.EncryptedExpiryMonth = encryptedExpiryMonth;
            }

            if (encryptedExpiryYear != null)
            {
                this.EncryptedExpiryYear = encryptedExpiryYear;
            }

            if (cardHolderName != null)
            {
                this.CardHolderName = cardHolderName;
            }

        }

        /// <summary>
        /// The encrypted Card Number
        /// </summary>
        [JsonProperty("encryptedCardNumber")]
        public string EncryptedCardNumber
        {
            get
            {
                return this.encryptedCardNumber;
            }

            set
            {
                this.shouldSerialize["encryptedCardNumber"] = true;
                this.encryptedCardNumber = value;
            }
        }

        /// <summary>
        /// The encrypted card verification code (same as CVV or CID)
        /// </summary>
        [JsonProperty("encryptedCardVerificationCode")]
        public string EncryptedCardVerificationCode
        {
            get
            {
                return this.encryptedCardVerificationCode;
            }

            set
            {
                this.shouldSerialize["encryptedCardVerificationCode"] = true;
                this.encryptedCardVerificationCode = value;
            }
        }

        /// <summary>
        /// The encrypted Card Expiry Month
        /// </summary>
        [JsonProperty("encryptedExpiryMonth")]
        public string EncryptedExpiryMonth
        {
            get
            {
                return this.encryptedExpiryMonth;
            }

            set
            {
                this.shouldSerialize["encryptedExpiryMonth"] = true;
                this.encryptedExpiryMonth = value;
            }
        }

        /// <summary>
        /// The encrypted Card Expiry Year
        /// </summary>
        [JsonProperty("encryptedExpiryYear")]
        public string EncryptedExpiryYear
        {
            get
            {
                return this.encryptedExpiryYear;
            }

            set
            {
                this.shouldSerialize["encryptedExpiryYear"] = true;
                this.encryptedExpiryYear = value;
            }
        }

        /// <summary>
        /// The name of the CardHolder
        /// </summary>
        [JsonProperty("CardHolderName")]
        public string CardHolderName
        {
            get
            {
                return this.cardHolderName;
            }

            set
            {
                this.shouldSerialize["CardHolderName"] = true;
                this.cardHolderName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CardSchemeEncrypted : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEncryptedCardNumber()
        {
            this.shouldSerialize["encryptedCardNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEncryptedCardVerificationCode()
        {
            this.shouldSerialize["encryptedCardVerificationCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEncryptedExpiryMonth()
        {
            this.shouldSerialize["encryptedExpiryMonth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEncryptedExpiryYear()
        {
            this.shouldSerialize["encryptedExpiryYear"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCardHolderName()
        {
            this.shouldSerialize["CardHolderName"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEncryptedCardNumber()
        {
            return this.shouldSerialize["encryptedCardNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEncryptedCardVerificationCode()
        {
            return this.shouldSerialize["encryptedCardVerificationCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEncryptedExpiryMonth()
        {
            return this.shouldSerialize["encryptedExpiryMonth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEncryptedExpiryYear()
        {
            return this.shouldSerialize["encryptedExpiryYear"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCardHolderName()
        {
            return this.shouldSerialize["CardHolderName"];
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
            return obj is CardSchemeEncrypted other &&                ((this.EncryptedCardNumber == null && other.EncryptedCardNumber == null) || (this.EncryptedCardNumber?.Equals(other.EncryptedCardNumber) == true)) &&
                ((this.EncryptedCardVerificationCode == null && other.EncryptedCardVerificationCode == null) || (this.EncryptedCardVerificationCode?.Equals(other.EncryptedCardVerificationCode) == true)) &&
                ((this.EncryptedExpiryMonth == null && other.EncryptedExpiryMonth == null) || (this.EncryptedExpiryMonth?.Equals(other.EncryptedExpiryMonth) == true)) &&
                ((this.EncryptedExpiryYear == null && other.EncryptedExpiryYear == null) || (this.EncryptedExpiryYear?.Equals(other.EncryptedExpiryYear) == true)) &&
                ((this.CardHolderName == null && other.CardHolderName == null) || (this.CardHolderName?.Equals(other.CardHolderName) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.EncryptedCardNumber = {(this.EncryptedCardNumber == null ? "null" : this.EncryptedCardNumber)}");
            toStringOutput.Add($"this.EncryptedCardVerificationCode = {(this.EncryptedCardVerificationCode == null ? "null" : this.EncryptedCardVerificationCode)}");
            toStringOutput.Add($"this.EncryptedExpiryMonth = {(this.EncryptedExpiryMonth == null ? "null" : this.EncryptedExpiryMonth)}");
            toStringOutput.Add($"this.EncryptedExpiryYear = {(this.EncryptedExpiryYear == null ? "null" : this.EncryptedExpiryYear)}");
            toStringOutput.Add($"this.CardHolderName = {(this.CardHolderName == null ? "null" : this.CardHolderName)}");

            base.ToString(toStringOutput);
        }
    }
}