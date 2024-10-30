// <copyright file="SalePaymentRequest.cs" company="APIMatic">
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
    /// SalePaymentRequest.
    /// </summary>
    public class SalePaymentRequest
    {
        private string merchantCode;
        private string callersReferenceId;
        private string dynamicMCC;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "merchantCode", false },
            { "callersReferenceId", false },
            { "dynamicMCC", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="SalePaymentRequest"/> class.
        /// </summary>
        public SalePaymentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalePaymentRequest"/> class.
        /// </summary>
        /// <param name="merchantCode">merchantCode.</param>
        /// <param name="callersReferenceId">callersReferenceId.</param>
        /// <param name="amount">amount.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="customerData">customerData.</param>
        /// <param name="additionalData">additionalData.</param>
        /// <param name="dynamicMCC">dynamicMCC.</param>
        /// <param name="customerInteractionType">customerInteractionType.</param>
        public SalePaymentRequest(
            string merchantCode = null,
            string callersReferenceId = null,
            Models.Amount amount = null,
            object paymentMethod = null,
            Models.CustomerData customerData = null,
            object additionalData = null,
            string dynamicMCC = null,
            Models.CustomerInteractionTypeEnum? customerInteractionType = null)
        {
            if (merchantCode != null)
            {
                this.MerchantCode = merchantCode;
            }

            if (callersReferenceId != null)
            {
                this.CallersReferenceId = callersReferenceId;
            }

            this.Amount = amount;
            this.PaymentMethod = paymentMethod;
            this.CustomerData = customerData;
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
        public string MerchantCode
        {
            get
            {
                return this.merchantCode;
            }

            set
            {
                this.shouldSerialize["merchantCode"] = true;
                this.merchantCode = value;
            }
        }

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
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount Amount { get; set; }

        /// <summary>
        /// The type and required details of a payment method to use.
        /// </summary>
        [JsonProperty("paymentMethod", NullValueHandling = NullValueHandling.Ignore)]
        public object PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets CustomerData.
        /// </summary>
        [JsonProperty("customerData", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CustomerData CustomerData { get; set; }

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

            return $"SalePaymentRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMerchantCode()
        {
            this.shouldSerialize["merchantCode"] = false;
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
        public bool ShouldSerializeMerchantCode()
        {
            return this.shouldSerialize["merchantCode"];
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
            return obj is SalePaymentRequest other &&                ((this.MerchantCode == null && other.MerchantCode == null) || (this.MerchantCode?.Equals(other.MerchantCode) == true)) &&
                ((this.CallersReferenceId == null && other.CallersReferenceId == null) || (this.CallersReferenceId?.Equals(other.CallersReferenceId) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.PaymentMethod == null && other.PaymentMethod == null) || (this.PaymentMethod?.Equals(other.PaymentMethod) == true)) &&
                ((this.CustomerData == null && other.CustomerData == null) || (this.CustomerData?.Equals(other.CustomerData) == true)) &&
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
            toStringOutput.Add($"this.CustomerData = {(this.CustomerData == null ? "null" : this.CustomerData.ToString())}");
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
            toStringOutput.Add($"this.DynamicMCC = {(this.DynamicMCC == null ? "null" : this.DynamicMCC)}");
            toStringOutput.Add($"this.CustomerInteractionType = {(this.CustomerInteractionType == null ? "null" : this.CustomerInteractionType.ToString())}");
        }
    }
}