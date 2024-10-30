// <copyright file="ScaData2.cs" company="APIMatic">
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
    /// ScaData2.
    /// </summary>
    public class ScaData2
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScaData2"/> class.
        /// </summary>
        public ScaData2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScaData2"/> class.
        /// </summary>
        /// <param name="authenticationRiskData">authenticationRiskData.</param>
        /// <param name="shopperAccountRiskData">shopperAccountRiskData.</param>
        /// <param name="transactionRiskData">transactionRiskData.</param>
        public ScaData2(
            object authenticationRiskData = null,
            object shopperAccountRiskData = null,
            object transactionRiskData = null)
        {
            this.AuthenticationRiskData = authenticationRiskData;
            this.ShopperAccountRiskData = shopperAccountRiskData;
            this.TransactionRiskData = transactionRiskData;
        }

        /// <summary>
        /// Information about the shopper and how they are authenticating with Worldpay.
        /// </summary>
        [JsonProperty("authenticationRiskData", NullValueHandling = NullValueHandling.Ignore)]
        public object AuthenticationRiskData { get; set; }

        /// <summary>
        /// Information about the shopper's account with you.
        /// </summary>
        [JsonProperty("shopperAccountRiskData", NullValueHandling = NullValueHandling.Ignore)]
        public object ShopperAccountRiskData { get; set; }

        /// <summary>
        /// Information about the order.
        /// </summary>
        [JsonProperty("transactionRiskData", NullValueHandling = NullValueHandling.Ignore)]
        public object TransactionRiskData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ScaData2 : ({string.Join(", ", toStringOutput)})";
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
            return obj is ScaData2 other &&                ((this.AuthenticationRiskData == null && other.AuthenticationRiskData == null) || (this.AuthenticationRiskData?.Equals(other.AuthenticationRiskData) == true)) &&
                ((this.ShopperAccountRiskData == null && other.ShopperAccountRiskData == null) || (this.ShopperAccountRiskData?.Equals(other.ShopperAccountRiskData) == true)) &&
                ((this.TransactionRiskData == null && other.TransactionRiskData == null) || (this.TransactionRiskData?.Equals(other.TransactionRiskData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"AuthenticationRiskData = {(this.AuthenticationRiskData == null ? "null" : this.AuthenticationRiskData.ToString())}");
            toStringOutput.Add($"ShopperAccountRiskData = {(this.ShopperAccountRiskData == null ? "null" : this.ShopperAccountRiskData.ToString())}");
            toStringOutput.Add($"TransactionRiskData = {(this.TransactionRiskData == null ? "null" : this.TransactionRiskData.ToString())}");
        }
    }
}