// <copyright file="Amount.cs" company="APIMatic">
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
    /// Amount.
    /// </summary>
    public class Amount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        public Amount()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="mValue">value.</param>
        /// <param name="currencyCode">currencyCode.</param>
        public Amount(
            int? mValue = null,
            Models.CurrencyCodeEnum? currencyCode = null)
        {
            this.MValue = mValue;
            this.CurrencyCode = currencyCode;
        }

        /// <summary>
        /// The amount of money, in the smallest denomination of the currency indicated by CurrencyCode.
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public int? MValue { get; set; }

        /// <summary>
        /// Gets or sets CurrencyCode.
        /// </summary>
        [JsonProperty("currencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CurrencyCodeEnum? CurrencyCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Amount : ({string.Join(", ", toStringOutput)})";
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
            return obj is Amount other &&                ((this.MValue == null && other.MValue == null) || (this.MValue?.Equals(other.MValue) == true)) &&
                ((this.CurrencyCode == null && other.CurrencyCode == null) || (this.CurrencyCode?.Equals(other.CurrencyCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MValue = {(this.MValue == null ? "null" : this.MValue.ToString())}");
            toStringOutput.Add($"this.CurrencyCode = {(this.CurrencyCode == null ? "null" : this.CurrencyCode.ToString())}");
        }
    }
}