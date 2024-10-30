// <copyright file="BaseDataToTokenize.cs" company="APIMatic">
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
    /// BaseDataToTokenize.
    /// </summary>
    [JsonConverter(typeof(JsonSubtypes), "type")]
    [JsonSubtypes.KnownSubType(typeof(TokenDataCardScheme), "card/scheme")]
    [JsonSubtypes.KnownSubType(typeof(TokenDataDirectDebitACH), "direct_debit/ach")]
    public class BaseDataToTokenize
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDataToTokenize"/> class.
        /// </summary>
        public BaseDataToTokenize()
        {
            this.Type = "BaseDataToTokenize";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDataToTokenize"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        public BaseDataToTokenize(
            string type = "BaseDataToTokenize")
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

            return $"BaseDataToTokenize : ({string.Join(", ", toStringOutput)})";
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
            return obj is BaseDataToTokenize other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true));
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