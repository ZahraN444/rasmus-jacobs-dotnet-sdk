// <copyright file="AvailablePaymentMethod.cs" company="APIMatic">
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
    /// AvailablePaymentMethod.
    /// </summary>
    public class AvailablePaymentMethod
    {
        private string paymentMethod;
        private List<Models.CurrencyCodeEnum> currencyCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "paymentMethod", false },
            { "currencyCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePaymentMethod"/> class.
        /// </summary>
        public AvailablePaymentMethod()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvailablePaymentMethod"/> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="currencyCode">currencyCode.</param>
        public AvailablePaymentMethod(
            string paymentMethod = null,
            List<Models.CurrencyCodeEnum> currencyCode = null)
        {
            if (paymentMethod != null)
            {
                this.PaymentMethod = paymentMethod;
            }

            if (currencyCode != null)
            {
                this.CurrencyCode = currencyCode;
            }

        }

        /// <summary>
        /// Gets or sets PaymentMethod.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod
        {
            get
            {
                return this.paymentMethod;
            }

            set
            {
                this.shouldSerialize["paymentMethod"] = true;
                this.paymentMethod = value;
            }
        }

        /// <summary>
        /// Gets or sets CurrencyCode.
        /// </summary>
        [JsonProperty("currencyCode")]
        public List<Models.CurrencyCodeEnum> CurrencyCode
        {
            get
            {
                return this.currencyCode;
            }

            set
            {
                this.shouldSerialize["currencyCode"] = true;
                this.currencyCode = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AvailablePaymentMethod : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPaymentMethod()
        {
            this.shouldSerialize["paymentMethod"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCurrencyCode()
        {
            this.shouldSerialize["currencyCode"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePaymentMethod()
        {
            return this.shouldSerialize["paymentMethod"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCurrencyCode()
        {
            return this.shouldSerialize["currencyCode"];
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
            return obj is AvailablePaymentMethod other &&                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod)}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : $"[{string.Join(", ", this.CurrencyCode)} ]")}");
        }
    }
}