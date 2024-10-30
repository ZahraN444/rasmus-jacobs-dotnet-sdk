// <copyright file="AuthorizePaymentResponse.cs" company="APIMatic">
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
    /// AuthorizePaymentResponse.
    /// </summary>
    public class AuthorizePaymentResponse
    {
        private string wpTransactionId;
        private string message;
        private string callersReferenceId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "wpTransactionId", false },
            { "message", false },
            { "callersReferenceId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizePaymentResponse"/> class.
        /// </summary>
        public AuthorizePaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizePaymentResponse"/> class.
        /// </summary>
        /// <param name="wpTransactionId">wpTransactionId.</param>
        /// <param name="resultCode">resultCode.</param>
        /// <param name="message">message.</param>
        /// <param name="refusalReason">refusalReason.</param>
        /// <param name="amount">amount.</param>
        /// <param name="callersReferenceId">callersReferenceId.</param>
        /// <param name="additionalData">additionalData.</param>
        public AuthorizePaymentResponse(
            string wpTransactionId = null,
            Models.ResultCodeEnum? resultCode = null,
            string message = null,
            Models.RefusalReasonEnum? refusalReason = null,
            Models.Amount amount = null,
            string callersReferenceId = null,
            object additionalData = null)
        {
            if (wpTransactionId != null)
            {
                this.WpTransactionId = wpTransactionId;
            }

            this.ResultCode = resultCode;
            if (message != null)
            {
                this.Message = message;
            }

            this.RefusalReason = refusalReason;
            this.Amount = amount;
            if (callersReferenceId != null)
            {
                this.CallersReferenceId = callersReferenceId;
            }

            this.AdditionalData = additionalData;
        }

        /// <summary>
        /// WorldPay's globally unique reference for this transaction/request.  You will use this value on all follow-up requests.
        /// </summary>
        [JsonProperty("wpTransactionId")]
        public string WpTransactionId
        {
            get
            {
                return this.wpTransactionId;
            }

            set
            {
                this.shouldSerialize["wpTransactionId"] = true;
                this.wpTransactionId = value;
            }
        }

        /// <summary>
        /// Gets or sets ResultCode.
        /// </summary>
        [JsonProperty("resultCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.ResultCodeEnum? ResultCode { get; set; }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.shouldSerialize["message"] = true;
                this.message = value;
            }
        }

        /// <summary>
        /// Gets or sets RefusalReason.
        /// </summary>
        [JsonProperty("refusalReason", NullValueHandling = NullValueHandling.Ignore)]
        public Models.RefusalReasonEnum? RefusalReason { get; set; }

        /// <summary>
        /// Gets or sets Amount.
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount Amount { get; set; }

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
        /// Gets or sets AdditionalData.
        /// </summary>
        [JsonProperty("additionalData", NullValueHandling = NullValueHandling.Ignore)]
        public object AdditionalData { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AuthorizePaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetWpTransactionId()
        {
            this.shouldSerialize["wpTransactionId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMessage()
        {
            this.shouldSerialize["message"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCallersReferenceId()
        {
            this.shouldSerialize["callersReferenceId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeWpTransactionId()
        {
            return this.shouldSerialize["wpTransactionId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMessage()
        {
            return this.shouldSerialize["message"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCallersReferenceId()
        {
            return this.shouldSerialize["callersReferenceId"];
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
            return obj is AuthorizePaymentResponse other &&                ((this.WpTransactionId == null && other.WpTransactionId == null) || (this.WpTransactionId?.Equals(other.WpTransactionId) == true)) &&
                ((this.ResultCode == null && other.ResultCode == null) || (this.ResultCode?.Equals(other.ResultCode) == true)) &&
                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true)) &&
                ((this.RefusalReason == null && other.RefusalReason == null) || (this.RefusalReason?.Equals(other.RefusalReason) == true)) &&
                ((this.Amount == null && other.Amount == null) || (this.Amount?.Equals(other.Amount) == true)) &&
                ((this.CallersReferenceId == null && other.CallersReferenceId == null) || (this.CallersReferenceId?.Equals(other.CallersReferenceId) == true)) &&
                ((this.AdditionalData == null && other.AdditionalData == null) || (this.AdditionalData?.Equals(other.AdditionalData) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.WpTransactionId = {(this.WpTransactionId == null ? "null" : this.WpTransactionId)}");
            toStringOutput.Add($"this.ResultCode = {(this.ResultCode == null ? "null" : this.ResultCode.ToString())}");
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
            toStringOutput.Add($"this.RefusalReason = {(this.RefusalReason == null ? "null" : this.RefusalReason.ToString())}");
            toStringOutput.Add($"this.Amount = {(this.Amount == null ? "null" : this.Amount.ToString())}");
            toStringOutput.Add($"this.CallersReferenceId = {(this.CallersReferenceId == null ? "null" : this.CallersReferenceId)}");
            toStringOutput.Add($"AdditionalData = {(this.AdditionalData == null ? "null" : this.AdditionalData.ToString())}");
        }
    }
}