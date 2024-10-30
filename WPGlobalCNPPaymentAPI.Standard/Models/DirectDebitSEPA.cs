// <copyright file="DirectDebitSEPA.cs" company="APIMatic">
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
    /// DirectDebitSEPA.
    /// </summary>
    public class DirectDebitSEPA : BasePaymentMethod
    {
        private string iban;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "iban", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitSEPA"/> class.
        /// </summary>
        public DirectDebitSEPA()
        {
            this.Type = "direct_debit/sepa";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitSEPA"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="iban">iban.</param>
        public DirectDebitSEPA(
            string type = "direct_debit/sepa",
            string iban = null)
            : base(
                type)
        {
            if (iban != null)
            {
                this.Iban = iban;
            }

        }

        /// <summary>
        /// International Bank Account Number
        /// </summary>
        [JsonProperty("iban")]
        public string Iban
        {
            get
            {
                return this.iban;
            }

            set
            {
                this.shouldSerialize["iban"] = true;
                this.iban = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitSEPA : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIban()
        {
            this.shouldSerialize["iban"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIban()
        {
            return this.shouldSerialize["iban"];
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
            return obj is DirectDebitSEPA other &&                ((this.Iban == null && other.Iban == null) || (this.Iban?.Equals(other.Iban) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Iban = {(this.Iban == null ? "null" : this.Iban)}");

            base.ToString(toStringOutput);
        }
    }
}