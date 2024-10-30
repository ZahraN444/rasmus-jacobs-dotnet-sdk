// <copyright file="TokenizeResponse.cs" company="APIMatic">
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
    /// TokenizeResponse.
    /// </summary>
    public class TokenizeResponse
    {
        private string tokenValue;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "tokenValue", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse"/> class.
        /// </summary>
        public TokenizeResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizeResponse"/> class.
        /// </summary>
        /// <param name="tokenValue">tokenValue.</param>
        public TokenizeResponse(
            string tokenValue = null)
        {
            if (tokenValue != null)
            {
                this.TokenValue = tokenValue;
            }

        }

        /// <summary>
        /// Gets or sets TokenValue.
        /// </summary>
        [JsonProperty("tokenValue")]
        public string TokenValue
        {
            get
            {
                return this.tokenValue;
            }

            set
            {
                this.shouldSerialize["tokenValue"] = true;
                this.tokenValue = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TokenizeResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTokenValue()
        {
            this.shouldSerialize["tokenValue"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTokenValue()
        {
            return this.shouldSerialize["tokenValue"];
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
            return obj is TokenizeResponse other &&                ((this.TokenValue == null && other.TokenValue == null) || (this.TokenValue?.Equals(other.TokenValue) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.TokenValue = {(this.TokenValue == null ? "null" : this.TokenValue)}");
        }
    }
}