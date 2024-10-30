// <copyright file="TokenDataDirectDebitACH.cs" company="APIMatic">
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
    /// TokenDataDirectDebitACH.
    /// </summary>
    public class TokenDataDirectDebitACH : BaseDataToTokenize
    {
        private string accountNumber;
        private string routingNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "accountNumber", false },
            { "routingNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDataDirectDebitACH"/> class.
        /// </summary>
        public TokenDataDirectDebitACH()
        {
            this.Type = "direct_debit/ach";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenDataDirectDebitACH"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="routingNumber">routingNumber.</param>
        public TokenDataDirectDebitACH(
            string type = "direct_debit/ach",
            Models.DirectDebitACHAccountTypeEnum? accountType = null,
            string accountNumber = null,
            string routingNumber = null)
            : base(
                type)
        {
            this.AccountType = accountType;
            if (accountNumber != null)
            {
                this.AccountNumber = accountNumber;
            }

            if (routingNumber != null)
            {
                this.RoutingNumber = routingNumber;
            }

        }

        /// <summary>
        /// Gets or sets AccountType.
        /// </summary>
        [JsonProperty("accountType", NullValueHandling = NullValueHandling.Ignore)]
        public Models.DirectDebitACHAccountTypeEnum? AccountType { get; set; }

        /// <summary>
        /// Gets or sets AccountNumber.
        /// </summary>
        [JsonProperty("accountNumber")]
        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }

            set
            {
                this.shouldSerialize["accountNumber"] = true;
                this.accountNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets RoutingNumber.
        /// </summary>
        [JsonProperty("routingNumber")]
        public string RoutingNumber
        {
            get
            {
                return this.routingNumber;
            }

            set
            {
                this.shouldSerialize["routingNumber"] = true;
                this.routingNumber = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"TokenDataDirectDebitACH : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAccountNumber()
        {
            this.shouldSerialize["accountNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetRoutingNumber()
        {
            this.shouldSerialize["routingNumber"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAccountNumber()
        {
            return this.shouldSerialize["accountNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeRoutingNumber()
        {
            return this.shouldSerialize["routingNumber"];
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
            return obj is TokenDataDirectDebitACH other &&                ((this.AccountType == null && other.AccountType == null) || (this.AccountType?.Equals(other.AccountType) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.RoutingNumber == null && other.RoutingNumber == null) || (this.RoutingNumber?.Equals(other.RoutingNumber) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AccountType = {(this.AccountType == null ? "null" : this.AccountType.ToString())}");
            toStringOutput.Add($"this.AccountNumber = {(this.AccountNumber == null ? "null" : this.AccountNumber)}");
            toStringOutput.Add($"this.RoutingNumber = {(this.RoutingNumber == null ? "null" : this.RoutingNumber)}");

            base.ToString(toStringOutput);
        }
    }
}