// <copyright file="DirectDebitACH.cs" company="APIMatic">
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
    /// DirectDebitACH.
    /// </summary>
    public class DirectDebitACH : BasePaymentMethod
    {
        private string accountNumber;
        private string routingNumber;
        private string checkNumber;
        private string companyName;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "accountNumber", false },
            { "routingNumber", false },
            { "checkNumber", false },
            { "companyName", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitACH"/> class.
        /// </summary>
        public DirectDebitACH()
        {
            this.Type = "direct_debit/ach";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectDebitACH"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="routingNumber">routingNumber.</param>
        /// <param name="checkNumber">checkNumber.</param>
        /// <param name="companyName">companyName.</param>
        public DirectDebitACH(
            string type = "direct_debit/ach",
            Models.DirectDebitACHAccountTypeEnum? accountType = null,
            string accountNumber = null,
            string routingNumber = null,
            string checkNumber = null,
            string companyName = null)
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

            if (checkNumber != null)
            {
                this.CheckNumber = checkNumber;
            }

            if (companyName != null)
            {
                this.CompanyName = companyName;
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

        /// <summary>
        /// Gets or sets CheckNumber.
        /// </summary>
        [JsonProperty("checkNumber")]
        public string CheckNumber
        {
            get
            {
                return this.checkNumber;
            }

            set
            {
                this.shouldSerialize["checkNumber"] = true;
                this.checkNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets CompanyName.
        /// </summary>
        [JsonProperty("companyName")]
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            set
            {
                this.shouldSerialize["companyName"] = true;
                this.companyName = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"DirectDebitACH : ({string.Join(", ", toStringOutput)})";
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
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCheckNumber()
        {
            this.shouldSerialize["checkNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCompanyName()
        {
            this.shouldSerialize["companyName"] = false;
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

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCheckNumber()
        {
            return this.shouldSerialize["checkNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCompanyName()
        {
            return this.shouldSerialize["companyName"];
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
            return obj is DirectDebitACH other &&                ((this.AccountType == null && other.AccountType == null) || (this.AccountType?.Equals(other.AccountType) == true)) &&
                ((this.AccountNumber == null && other.AccountNumber == null) || (this.AccountNumber?.Equals(other.AccountNumber) == true)) &&
                ((this.RoutingNumber == null && other.RoutingNumber == null) || (this.RoutingNumber?.Equals(other.RoutingNumber) == true)) &&
                ((this.CheckNumber == null && other.CheckNumber == null) || (this.CheckNumber?.Equals(other.CheckNumber) == true)) &&
                ((this.CompanyName == null && other.CompanyName == null) || (this.CompanyName?.Equals(other.CompanyName) == true)) &&
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
            toStringOutput.Add($"this.CheckNumber = {(this.CheckNumber == null ? "null" : this.CheckNumber)}");
            toStringOutput.Add($"this.CompanyName = {(this.CompanyName == null ? "null" : this.CompanyName)}");

            base.ToString(toStringOutput);
        }
    }
}