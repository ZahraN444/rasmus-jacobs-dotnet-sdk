// <copyright file="TokenizeRequest.cs" company="APIMatic">
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
    /// TokenizeRequest.
    /// </summary>
    public class TokenizeRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequest"/> class.
        /// </summary>
        public TokenizeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeRequest"/> class.
        /// </summary>
        /// <param name="merchantCode">merchantCode.</param>
        /// <param name="dataToTokenize">dataToTokenize.</param>
        public TokenizeRequest(
            string merchantCode,
            object dataToTokenize)
        {
            this.MerchantCode = merchantCode;
            this.DataToTokenize = dataToTokenize;
        }

        /// <summary>
        /// The merchant account identifier we geve you under which you want to process this transaction.
        /// </summary>
        [JsonProperty("merchantCode")]
        public string MerchantCode { get; set; }

        /// <summary>
        /// The type and required details of data to tokenize
        /// </summary>
        [JsonProperty("dataToTokenize")]
        public object DataToTokenize { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TokenizeRequest : ({string.Join(", ", toStringOutput)})";
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
            return obj is TokenizeRequest other &&                ((this.MerchantCode == null && other.MerchantCode == null) || (this.MerchantCode?.Equals(other.MerchantCode) == true)) &&
                ((this.DataToTokenize == null && other.DataToTokenize == null) || (this.DataToTokenize?.Equals(other.DataToTokenize) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.MerchantCode = {(this.MerchantCode == null ? "null" : this.MerchantCode)}");
            toStringOutput.Add($"DataToTokenize = {(this.DataToTokenize == null ? "null" : this.DataToTokenize.ToString())}");
        }
    }
}