// <copyright file="QueryAvailablePaymentMethodsResponse.cs" company="APIMatic">
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
    /// QueryAvailablePaymentMethodsResponse.
    /// </summary>
    public class QueryAvailablePaymentMethodsResponse
    {
        private string merchantCode;
        private List<Models.AvailablePaymentMethod> availablePaymentMethods;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "merchantCode", false },
            { "availablePaymentMethods", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailablePaymentMethodsResponse"/> class.
        /// </summary>
        public QueryAvailablePaymentMethodsResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailablePaymentMethodsResponse"/> class.
        /// </summary>
        /// <param name="merchantCode">merchantCode.</param>
        /// <param name="availablePaymentMethods">availablePaymentMethods.</param>
        public QueryAvailablePaymentMethodsResponse(
            string merchantCode = null,
            List<Models.AvailablePaymentMethod> availablePaymentMethods = null)
        {
            if (merchantCode != null)
            {
                this.MerchantCode = merchantCode;
            }

            if (availablePaymentMethods != null)
            {
                this.AvailablePaymentMethods = availablePaymentMethods;
            }

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
        /// Gets or sets AvailablePaymentMethods.
        /// </summary>
        [JsonProperty("availablePaymentMethods")]
        public List<Models.AvailablePaymentMethod> AvailablePaymentMethods
        {
            get
            {
                return this.availablePaymentMethods;
            }

            set
            {
                this.shouldSerialize["availablePaymentMethods"] = true;
                this.availablePaymentMethods = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryAvailablePaymentMethodsResponse : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetAvailablePaymentMethods()
        {
            this.shouldSerialize["availablePaymentMethods"] = false;
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
        public bool ShouldSerializeAvailablePaymentMethods()
        {
            return this.shouldSerialize["availablePaymentMethods"];
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
            return obj is QueryAvailablePaymentMethodsResponse other &&                ((this.MerchantCode == null && other.MerchantCode == null) || (this.MerchantCode?.Equals(other.MerchantCode) == true)) &&
                ((this.AvailablePaymentMethods == null && other.AvailablePaymentMethods == null) || (this.AvailablePaymentMethods?.Equals(other.AvailablePaymentMethods) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantCode = {(this.MerchantCode == null ? "null" : this.MerchantCode)}");
            toStringOutput.Add($"this.AvailablePaymentMethods = {(this.AvailablePaymentMethods == null ? "null" : $"[{string.Join(", ", this.AvailablePaymentMethods)} ]")}");
        }
    }
}