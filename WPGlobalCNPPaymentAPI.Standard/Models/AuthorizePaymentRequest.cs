// <copyright file="AuthorizePaymentRequest.cs" company="APIMatic">
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
    /// AuthorizePaymentRequest.
    /// </summary>
    public class AuthorizePaymentRequest
    {
        private string callersReferenceId;
        private string dynamicMCC;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "callersReferenceId", false },
            { "dynamicMCC", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizePaymentRequest"/> class.
        /// </summary>
        public AuthorizePaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizePaymentRequest"/> class.
        /// </summary>
        /// <param name="merchantCode">merchantCode.</param>
        /// <param name="amount">amount.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="callersReferenceId">callersReferenceId.</param>
        /// <param name="industryData">industryData.</param>
        /// <param name="customerData">customerData.</param>
        /// <param name="scaData">scaData.</param>
        /// <param name="payfacData">payfacData.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="dynamicMCC">dynamicMCC.</param>
        /// <param name="customerInteractionType">customerInteractionType.</param>
        public AuthorizePaymentRequest(
            string merchantCode,
            Models.Amount amount,
            object paymentMethod,
            string callersReferenceId = null,
            object industryData = null,
            Models.CustomerData customerData = null,
            Models.ScaData2 scaData = null,
            Models.PayfacData2 payfacData = null,
            object additionalData = null,
            string dynamicMCC = null,
            Models.CustomerInteractionTypeEnum? customerInteractionType = null)
        {
            this.MerchantCode = merchantCode;
            if (callersReferenceId != null)
            {
                this.CallersReferenceId = callersReferenceId;
            }

            this.Amount = amount;
            this.PaymentMethod = paymentMethod;
            this.IndustryData = industryData;
            this.CustomerData = customerData;
            this.ScaData = scaData;
            this.PayfacData = payfacData;
            this.AdditionalData = additionalData;
            if (dynamicMCC != null)
            {
                this.DynamicMCC = dynamicMCC;
            }

            this.CustomerInteractionType = customerInteractionType;
        }

        /// <summary>
        /// The merchant account identifier we geve you under which you want to process this transaction.
        /// </summary>
        [JsonProperty("merchantCode")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// Your reference value for this payment that is carried thru to reporting.
        /// </summary>
        [JsonProperty("callersReferenceId")]
        public string CallersReferenceId
        {
            get
            {
                return this.callersReferenceId;
            }

            set
            {
                this.shouldSerialize["callersReferenceId"] = true;
                this.callersReferenceId = value;
            }
        }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount")]
        public Models.Amount Amount { get; set; }

        /// <summary>
        /// The type and required details of a payment method to use.
        /// </summary>
        [JsonProperty("paymentMethod")]
        public object PaymentMethod { get; set; }

        /// <summary>
        /// Additional Industry Specific Data
        /// </summary>
        [JsonProperty("industryData", NullValueHandling = NullValueHandling.Ignore)]
        public object IndustryData { get; set; }

        /// <summary>
        /// Gets or sets CustomerData.
        /// </summary>
        [JsonProperty("customerData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerData CustomerData { get; set; }

        /// <summary>
        /// Gets or sets ScaData.
        /// </summary>
        [JsonProperty("scaData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ScaData2 ScaData { get; set; }

        /// <summary>
        /// Gets or sets PayfacData.
        /// </summary>
        [JsonProperty("payfacData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.PayfacData2 PayfacData { get; set; }

        /// <summary>
        /// Gets or sets AdditionalData.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public object AdditionalData { get; set; }

        /// <summary>
        /// The merchant category code (MCC) is a four-digit number, which relates to a particular market segment.
        /// </summary>
        [JsonProperty("dynamicMCC")]
        public string DynamicMCC
        {
            get
            {
                return this.dynamicMCC;
            }

            set
            {
                this.shouldSerialize["dynamicMCC"] = true;
                this.dynamicMCC = value;
            }
        }

        /// <summary>
        /// Gets or sets CustomerInteractionType.
        /// </summary>
        [JsonProperty("customerInteractionType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerInteractionTypeEnum? CustomerInteractionType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthorizePaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallersReferenceId()
        {
            this.shouldSerialize["callersReferenceId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDynamicMCC()
        {
            this.shouldSerialize["dynamicMCC"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallersReferenceId()
        {
            return this.shouldSerialize["callersReferenceId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDynamicMCC()
        {
            return this.shouldSerialize["dynamicMCC"];
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
            return obj is AuthorizePaymentRequest other &&                ((this.MerchantCode == null && other.MerchantCode == null) || (this.MerchantCode?.Equals(other.MerchantCode) == true)) &&
                ((this.CallersReferenceId == null && other.CallersReferenceId == null) || (this.CallersReferenceId?.Equals(other.CallersReferenceId) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.IndustryData == null && other.IndustryData == null) || (this.IndustryData?.Equals(other.IndustryData) == true)) &&
                ((this.CustomerData == null && other.CustomerData == null) || (this.CustomerData?.Equals(other.CustomerData) == true)) &&
                ((this.ScaData == null && other.ScaData == null) || (this.ScaData?.Equals(other.ScaData) == true)) &&
                ((this.PayfacData == null && other.PayfacData == null) || (this.PayfacData?.Equals(other.PayfacData) == true)) &&
                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true)) &&
                ((this.DynamicMCC == null && other.DynamicMCC == null) || (this.DynamicMCC?.Equals(other.DynamicMCC) == true)) &&
                ((this.CustomerInteractionType == null && other.CustomerInteractionType == null) || (this.CustomerInteractionType?.Equals(other.CustomerInteractionType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantCode = {(this.MerchantCode == null ? "null" : this.MerchantCode)}");
            toStringOutput.Add($"this.CallersReferenceId = {(this.CallersReferenceId == null ? "null" : this.CallersReferenceId)}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"PaymentMethod = {(this.PaymentMethod == null ? "null" : this.PaymentMethod.ToString())}");
            toStringOutput.Add($"IndustryData = {(this.IndustryData == null ? "null" : this.IndustryData.ToString())}");
            toStringOutput.Add($"this.CustomerData = {(this.CustomerData == null ? "null" : this.CustomerData.ToString())}");
            toStringOutput.Add($"this.ScaData = {(this.ScaData == null ? "null" : this.ScaData.ToString())}");
            toStringOutput.Add($"this.PayfacData = {(this.PayfacData == null ? "null" : this.PayfacData.ToString())}");
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.DynamicMCC = {(this.DynamicMCC == null ? "null" : this.DynamicMCC)}");
            toStringOutput.Add($"this.CustomerInteractionType = {(this.CustomerInteractionType == null ? "null" : this.CustomerInteractionType.ToString())}");
        }
    }
}