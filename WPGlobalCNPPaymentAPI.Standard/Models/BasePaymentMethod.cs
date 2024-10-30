// <copyright file="BasePaymentMethod.cs" company="APIMatic">
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
    /// BasePaymentMethod.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(APMFISLoyalty), "apm/fisloyalty")]
    [JsonSubtypes.KnownSubType(typeof(APMGiropay), "apm/giropay")]
    [JsonSubtypes.KnownSubType(typeof(APMIdeal), "apm/ideal")]
    [JsonSubtypes.KnownSubType(typeof(APMKlarna), "apm/klarna")]
    [JsonSubtypes.KnownSubType(typeof(APMPaypal), "apm/paypal")]
    [JsonSubtypes.KnownSubType(typeof(CardMerchantGift), "card/merchant_gift")]
    [JsonSubtypes.KnownSubType(typeof(CardScheme), "card/scheme")]
    [JsonSubtypes.KnownSubType(typeof(CardSchemeEncrypted), "card/scheme_encrypted")]
    [JsonSubtypes.KnownSubType(typeof(DirectDebitACH), "direct_debit/ach")]
    [JsonSubtypes.KnownSubType(typeof(DirectDebitEFT), "direct_debit/eft")]
    [JsonSubtypes.KnownSubType(typeof(DirectDebitSEPA), "direct_debit/sepa")]
    [JsonSubtypes.KnownSubType(typeof(TokenNetwork), "token/network")]
    [JsonSubtypes.KnownSubType(typeof(TokenWPSecurity), "token/wp_security")]
    [JsonSubtypes.KnownSubType(typeof(WalletAmazonPay), "wallet/amazonpay")]
    [JsonSubtypes.KnownSubType(typeof(WalletApplePay), "wallet/applepay")]
    [JsonSubtypes.KnownSubType(typeof(WalletGooglePay), "wallet/googlepay")]
    public class BasePaymentMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BasePaymentMethod"/> class.
        /// </summary>
        public BasePaymentMethod()
        {
            this.Type = "BasePaymentMethod";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasePaymentMethod"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public BasePaymentMethod(
            string type = "BasePaymentMethod")
        {
            this.Type = type;
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"BasePaymentMethod : ({string.Join(", ", toStringOutput)})";
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
            return obj is BasePaymentMethod other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
        }
    }
}