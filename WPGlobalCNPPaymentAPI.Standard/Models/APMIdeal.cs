// <copyright file="APMIdeal.cs" company="APIMatic">
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
    /// APMIdeal.
    /// </summary>
    public class APMIdeal : BasePaymentMethod
    {
        private string successURL;
        private string failureURL;
        private string cancelURL;
        private string pendingURL;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "successURL", false },
            { "failureURL", false },
            { "cancelURL", false },
            { "pendingURL", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="APMIdeal"/> class.
        /// </summary>
        public APMIdeal()
        {
            this.Type = "apm/ideal";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APMIdeal"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="successURL">successURL.</param>
        /// <param name="failureURL">failureURL.</param>
        /// <param name="cancelURL">cancelURL.</param>
        /// <param name="pendingURL">pendingURL.</param>
        /// <param name="bankCode">bankCode.</param>
        public APMIdeal(
            string type = "apm/ideal",
            string successURL = null,
            string failureURL = null,
            string cancelURL = null,
            string pendingURL = null,
            Models.APMIdealBankCodeEnum? bankCode = null)
            : base(
                type)
        {
            if (successURL != null)
            {
                this.SuccessURL = successURL;
            }

            if (failureURL != null)
            {
                this.FailureURL = failureURL;
            }

            if (cancelURL != null)
            {
                this.CancelURL = cancelURL;
            }

            if (pendingURL != null)
            {
                this.PendingURL = pendingURL;
            }

            this.BankCode = bankCode;
        }

        /// <summary>
        /// Gets or sets SuccessURL.
        /// </summary>
        [JsonProperty("successURL")]
        public string SuccessURL
        {
            get
            {
                return this.successURL;
            }

            set
            {
                this.shouldSerialize["successURL"] = true;
                this.successURL = value;
            }
        }

        /// <summary>
        /// Gets or sets FailureURL.
        /// </summary>
        [JsonProperty("failureURL")]
        public string FailureURL
        {
            get
            {
                return this.failureURL;
            }

            set
            {
                this.shouldSerialize["failureURL"] = true;
                this.failureURL = value;
            }
        }

        /// <summary>
        /// Gets or sets CancelURL.
        /// </summary>
        [JsonProperty("cancelURL")]
        public string CancelURL
        {
            get
            {
                return this.cancelURL;
            }

            set
            {
                this.shouldSerialize["cancelURL"] = true;
                this.cancelURL = value;
            }
        }

        /// <summary>
        /// Gets or sets PendingURL.
        /// </summary>
        [JsonProperty("pendingURL")]
        public string PendingURL
        {
            get
            {
                return this.pendingURL;
            }

            set
            {
                this.shouldSerialize["pendingURL"] = true;
                this.pendingURL = value;
            }
        }

        /// <summary>
        /// Gets or sets BankCode.
        /// </summary>
        [JsonProperty("bankCode", NullValueHandling = NullValueHandling.Ignore)]
        public Models.APMIdealBankCodeEnum? BankCode { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"APMIdeal : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSuccessURL()
        {
            this.shouldSerialize["successURL"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFailureURL()
        {
            this.shouldSerialize["failureURL"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCancelURL()
        {
            this.shouldSerialize["cancelURL"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPendingURL()
        {
            this.shouldSerialize["pendingURL"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSuccessURL()
        {
            return this.shouldSerialize["successURL"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFailureURL()
        {
            return this.shouldSerialize["failureURL"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCancelURL()
        {
            return this.shouldSerialize["cancelURL"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePendingURL()
        {
            return this.shouldSerialize["pendingURL"];
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
            return obj is APMIdeal other &&                ((this.SuccessURL == null && other.SuccessURL == null) || (this.SuccessURL?.Equals(other.SuccessURL) == true)) &&
                ((this.FailureURL == null && other.FailureURL == null) || (this.FailureURL?.Equals(other.FailureURL) == true)) &&
                ((this.CancelURL == null && other.CancelURL == null) || (this.CancelURL?.Equals(other.CancelURL) == true)) &&
                ((this.PendingURL == null && other.PendingURL == null) || (this.PendingURL?.Equals(other.PendingURL) == true)) &&
                ((this.BankCode == null && other.BankCode == null) || (this.BankCode?.Equals(other.BankCode) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.SuccessURL = {(this.SuccessURL == null ? "null" : this.SuccessURL)}");
            toStringOutput.Add($"this.FailureURL = {(this.FailureURL == null ? "null" : this.FailureURL)}");
            toStringOutput.Add($"this.CancelURL = {(this.CancelURL == null ? "null" : this.CancelURL)}");
            toStringOutput.Add($"this.PendingURL = {(this.PendingURL == null ? "null" : this.PendingURL)}");
            toStringOutput.Add($"this.BankCode = {(this.BankCode == null ? "null" : this.BankCode.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}