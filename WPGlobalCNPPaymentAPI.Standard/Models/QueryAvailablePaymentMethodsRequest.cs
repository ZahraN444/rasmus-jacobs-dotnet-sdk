// <copyright file="QueryAvailablePaymentMethodsRequest.cs" company="APIMatic">
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
    /// QueryAvailablePaymentMethodsRequest.
    /// </summary>
    public class QueryAvailablePaymentMethodsRequest
    {
        private string merchantCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "merchantCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailablePaymentMethodsRequest"/> class.
        /// </summary>
        public QueryAvailablePaymentMethodsRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryAvailablePaymentMethodsRequest"/> class.
        /// </summary>
        /// <param name="merchantCode">merchantCode.</param>
        public QueryAvailablePaymentMethodsRequest(
            string merchantCode = null)
        {
            if (merchantCode != null)
            {
                this.MerchantCode = merchantCode;
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

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"QueryAvailablePaymentMethodsRequest : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMerchantCode()
        {
            this.shouldSerialize["merchantCode"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMerchantCode()
        {
            return this.shouldSerialize["merchantCode"];
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
            return obj is QueryAvailablePaymentMethodsRequest other &&                ((this.MerchantCode == null && other.MerchantCode == null) || (this.MerchantCode?.Equals(other.MerchantCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantCode = {(this.MerchantCode == null ? "null" : this.MerchantCode)}");
        }
    }
}