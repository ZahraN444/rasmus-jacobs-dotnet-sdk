// <copyright file="CustomerData.cs" company="APIMatic">
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
    /// CustomerData.
    /// </summary>
    public class CustomerData
    {
        private string telephoneNumber;
        private DateTime? dateOfBirth;
        private string emailAddress;
        private string ipAddress;
        private string shopperLocale;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "telephoneNumber", false },
            { "dateOfBirth", false },
            { "emailAddress", false },
            { "ipAddress", false },
            { "shopperLocale", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerData"/> class.
        /// </summary>
        public CustomerData()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerData"/> class.
        /// </summary>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="emailAddress">emailAddress.</param>
        /// <param name="ipAddress">ipAddress.</param>
        /// <param name="shopperLocale">shopperLocale.</param>
        public CustomerData(
            Models.Address billingAddress = null,
            Models.Address shippingAddress = null,
            string telephoneNumber = null,
            DateTime? dateOfBirth = null,
            string emailAddress = null,
            string ipAddress = null,
            string shopperLocale = null)
        {
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            if (telephoneNumber != null)
            {
                this.TelephoneNumber = telephoneNumber;
            }

            if (dateOfBirth != null)
            {
                this.DateOfBirth = dateOfBirth;
            }

            if (emailAddress != null)
            {
                this.EmailAddress = emailAddress;
            }

            if (ipAddress != null)
            {
                this.IpAddress = ipAddress;
            }

            if (shopperLocale != null)
            {
                this.ShopperLocale = shopperLocale;
            }

        }

        /// <summary>
        /// Gets or sets BillingAddress.
        /// </summary>
        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address BillingAddress { get; set; }

        /// <summary>
        /// Gets or sets ShippingAddress.
        /// </summary>
        [JsonProperty("shippingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Address ShippingAddress { get; set; }

        /// <summary>
        /// The customer's telephone number.
        /// </summary>
        [JsonProperty("telephoneNumber")]
        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }

            set
            {
                this.shouldSerialize["telephoneNumber"] = true;
                this.telephoneNumber = value;
            }
        }

        /// <summary>
        /// The customer's date of birth in ISO-8601 format (YYYY-MM-DD)
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth")]
        public DateTime? DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            set
            {
                this.shouldSerialize["dateOfBirth"] = true;
                this.dateOfBirth = value;
            }
        }

        /// <summary>
        /// The customer's email address.
        /// </summary>
        [JsonProperty("emailAddress")]
        public string EmailAddress
        {
            get
            {
                return this.emailAddress;
            }

            set
            {
                this.shouldSerialize["emailAddress"] = true;
                this.emailAddress = value;
            }
        }

        /// <summary>
        /// The customer's IP address.
        /// </summary>
        [JsonProperty("ipAddress")]
        public string IpAddress
        {
            get
            {
                return this.ipAddress;
            }

            set
            {
                this.shouldSerialize["ipAddress"] = true;
                this.ipAddress = value;
            }
        }

        /// <summary>
        /// The RFC 1766 language string for this shopper
        /// </summary>
        [JsonProperty("shopperLocale")]
        public string ShopperLocale
        {
            get
            {
                return this.shopperLocale;
            }

            set
            {
                this.shouldSerialize["shopperLocale"] = true;
                this.shopperLocale = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CustomerData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTelephoneNumber()
        {
            this.shouldSerialize["telephoneNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDateOfBirth()
        {
            this.shouldSerialize["dateOfBirth"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetEmailAddress()
        {
            this.shouldSerialize["emailAddress"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIpAddress()
        {
            this.shouldSerialize["ipAddress"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetShopperLocale()
        {
            this.shouldSerialize["shopperLocale"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTelephoneNumber()
        {
            return this.shouldSerialize["telephoneNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDateOfBirth()
        {
            return this.shouldSerialize["dateOfBirth"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeEmailAddress()
        {
            return this.shouldSerialize["emailAddress"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIpAddress()
        {
            return this.shouldSerialize["ipAddress"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShopperLocale()
        {
            return this.shouldSerialize["shopperLocale"];
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
            return obj is CustomerData other &&                ((this.BillingAddress == null && other.BillingAddress == null) || (this.BillingAddress?.Equals(other.BillingAddress) == true)) &&
                ((this.ShippingAddress == null && other.ShippingAddress == null) || (this.ShippingAddress?.Equals(other.ShippingAddress) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.EmailAddress == null && other.EmailAddress == null) || (this.EmailAddress?.Equals(other.EmailAddress) == true)) &&
                ((this.IpAddress == null && other.IpAddress == null) || (this.IpAddress?.Equals(other.IpAddress) == true)) &&
                ((this.ShopperLocale == null && other.ShopperLocale == null) || (this.ShopperLocale?.Equals(other.ShopperLocale) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.BillingAddress = {(this.BillingAddress == null ? "null" : this.BillingAddress.ToString())}");
            toStringOutput.Add($"this.ShippingAddress = {(this.ShippingAddress == null ? "null" : this.ShippingAddress.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.EmailAddress = {(this.EmailAddress == null ? "null" : this.EmailAddress)}");
            toStringOutput.Add($"this.IpAddress = {(this.IpAddress == null ? "null" : this.IpAddress)}");
            toStringOutput.Add($"this.ShopperLocale = {(this.ShopperLocale == null ? "null" : this.ShopperLocale)}");
        }
    }
}