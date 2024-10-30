// <copyright file="WalletAmazonPay.cs" company="APIMatic">
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
    /// WalletAmazonPay.
    /// </summary>
    public class WalletAmazonPay : BasePaymentMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletAmazonPay"/> class.
        /// </summary>
        public WalletAmazonPay()
        {
            this.Type = "wallet/amazonpay";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WalletAmazonPay"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="amazonPayChargeID">amazonPayChargeID.</param>
        /// <param name="amazonPayToken">amazonPayToken.</param>
        /// <param name="amazonPayBillingDescriptor">amazonPayBillingDescriptor.</param>
        /// <param name="amazonPayMerchantOrderNumber">amazonPayMerchantOrderNumber.</param>
        /// <param name="amazonPayMerchantID">amazonPayMerchantID.</param>
        public WalletAmazonPay(
            string type = "wallet/amazonpay",
            int? amazonPayChargeID = null,
            int? amazonPayToken = null,
            int? amazonPayBillingDescriptor = null,
            int? amazonPayMerchantOrderNumber = null,
            int? amazonPayMerchantID = null)
            : base(
                type)
        {
            this.AmazonPayChargeID = amazonPayChargeID;
            this.AmazonPayToken = amazonPayToken;
            this.AmazonPayBillingDescriptor = amazonPayBillingDescriptor;
            this.AmazonPayMerchantOrderNumber = amazonPayMerchantOrderNumber;
            this.AmazonPayMerchantID = amazonPayMerchantID;
        }

        /// <summary>
        /// ID of the Charge object created at Amazon Pay. It should be passed on every subsequent request for this transaction.
        /// </summary>
        [JsonProperty("amazonPayChargeID", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmazonPayChargeID { get; set; }

        /// <summary>
        /// This field represents the high value token for the transaction.
        /// </summary>
        [JsonProperty("amazonPayToken", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmazonPayToken { get; set; }

        /// <summary>
        /// The description to be shown on the buyer's payment statement. For a payment, it should be passed either during authorization or capture.
        /// </summary>
        [JsonProperty("amazonPayBillingDescriptor", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmazonPayBillingDescriptor { get; set; }

        /// <summary>
        /// This field contains the order number associated with the transaction. Any inquiries regarding the transactions should use this value.
        /// </summary>
        [JsonProperty("amazonPayMerchantOrderNumber", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmazonPayMerchantOrderNumber { get; set; }

        /// <summary>
        /// Gets or sets my property.
        /// </summary>
        [JsonProperty("amazonPayMerchantID", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmazonPayMerchantID { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"WalletAmazonPay : ({string.Join(", ", toStringOutput)})";
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
            return obj is WalletAmazonPay other &&                ((this.AmazonPayChargeID == null && other.AmazonPayChargeID == null) || (this.AmazonPayChargeID?.Equals(other.AmazonPayChargeID) == true)) &&
                ((this.AmazonPayToken == null && other.AmazonPayToken == null) || (this.AmazonPayToken?.Equals(other.AmazonPayToken) == true)) &&
                ((this.AmazonPayBillingDescriptor == null && other.AmazonPayBillingDescriptor == null) || (this.AmazonPayBillingDescriptor?.Equals(other.AmazonPayBillingDescriptor) == true)) &&
                ((this.AmazonPayMerchantOrderNumber == null && other.AmazonPayMerchantOrderNumber == null) || (this.AmazonPayMerchantOrderNumber?.Equals(other.AmazonPayMerchantOrderNumber) == true)) &&
                ((this.AmazonPayMerchantID == null && other.AmazonPayMerchantID == null) || (this.AmazonPayMerchantID?.Equals(other.AmazonPayMerchantID) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AmazonPayChargeID = {(this.AmazonPayChargeID == null ? "null" : this.AmazonPayChargeID.ToString())}");
            toStringOutput.Add($"this.AmazonPayToken = {(this.AmazonPayToken == null ? "null" : this.AmazonPayToken.ToString())}");
            toStringOutput.Add($"this.AmazonPayBillingDescriptor = {(this.AmazonPayBillingDescriptor == null ? "null" : this.AmazonPayBillingDescriptor.ToString())}");
            toStringOutput.Add($"this.AmazonPayMerchantOrderNumber = {(this.AmazonPayMerchantOrderNumber == null ? "null" : this.AmazonPayMerchantOrderNumber.ToString())}");
            toStringOutput.Add($"this.AmazonPayMerchantID = {(this.AmazonPayMerchantID == null ? "null" : this.AmazonPayMerchantID.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}