// <copyright file="Address.cs" company="APIMatic">
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
    /// Address.
    /// </summary>
    public class Address
    {
        private string firstName;
        private string lastName;
        private string street;
        private string streetLine2;
        private string city;
        private string stateOrProvince;
        private string postalCode;
        private string country;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "firstName", false },
            { "lastName", false },
            { "street", false },
            { "streetLine2", false },
            { "city", false },
            { "stateOrProvince", false },
            { "postalCode", false },
            { "country", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="street">street.</param>
        /// <param name="streetLine2">streetLine2.</param>
        /// <param name="city">city.</param>
        /// <param name="stateOrProvince">stateOrProvince.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="country">country.</param>
        public Address(
            string firstName = null,
            string lastName = null,
            string street = null,
            string streetLine2 = null,
            string city = null,
            string stateOrProvince = null,
            string postalCode = null,
            string country = null)
        {
            if (firstName != null)
            {
                this.FirstName = firstName;
            }

            if (lastName != null)
            {
                this.LastName = lastName;
            }

            if (street != null)
            {
                this.Street = street;
            }

            if (streetLine2 != null)
            {
                this.StreetLine2 = streetLine2;
            }

            if (city != null)
            {
                this.City = city;
            }

            if (stateOrProvince != null)
            {
                this.StateOrProvince = stateOrProvince;
            }

            if (postalCode != null)
            {
                this.PostalCode = postalCode;
            }

            if (country != null)
            {
                this.Country = country;
            }

        }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.shouldSerialize["firstName"] = true;
                this.firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.shouldSerialize["lastName"] = true;
                this.lastName = value;
            }
        }

        /// <summary>
        /// The name of the street.
        /// </summary>
        [JsonProperty("street")]
        public string Street
        {
            get
            {
                return this.street;
            }

            set
            {
                this.shouldSerialize["street"] = true;
                this.street = value;
            }
        }

        /// <summary>
        /// Gets or sets StreetLine2.
        /// </summary>
        [JsonProperty("streetLine2")]
        public string StreetLine2
        {
            get
            {
                return this.streetLine2;
            }

            set
            {
                this.shouldSerialize["streetLine2"] = true;
                this.streetLine2 = value;
            }
        }

        /// <summary>
        /// The name of the city
        /// </summary>
        [JsonProperty("city")]
        public string City
        {
            get
            {
                return this.city;
            }

            set
            {
                this.shouldSerialize["city"] = true;
                this.city = value;
            }
        }

        /// <summary>
        /// The two-character ISO 3166-2 state or province code.
        /// </summary>
        [JsonProperty("stateOrProvince")]
        public string StateOrProvince
        {
            get
            {
                return this.stateOrProvince;
            }

            set
            {
                this.shouldSerialize["stateOrProvince"] = true;
                this.stateOrProvince = value;
            }
        }

        /// <summary>
        /// The Postal Code associated with the address
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode
        {
            get
            {
                return this.postalCode;
            }

            set
            {
                this.shouldSerialize["postalCode"] = true;
                this.postalCode = value;
            }
        }

        /// <summary>
        /// The three-character ISO-3166-1 country code
        /// </summary>
        [JsonProperty("country")]
        public string Country
        {
            get
            {
                return this.country;
            }

            set
            {
                this.shouldSerialize["country"] = true;
                this.country = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Address : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFirstName()
        {
            this.shouldSerialize["firstName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLastName()
        {
            this.shouldSerialize["lastName"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStreet()
        {
            this.shouldSerialize["street"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStreetLine2()
        {
            this.shouldSerialize["streetLine2"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCity()
        {
            this.shouldSerialize["city"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStateOrProvince()
        {
            this.shouldSerialize["stateOrProvince"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPostalCode()
        {
            this.shouldSerialize["postalCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCountry()
        {
            this.shouldSerialize["country"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFirstName()
        {
            return this.shouldSerialize["firstName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLastName()
        {
            return this.shouldSerialize["lastName"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStreet()
        {
            return this.shouldSerialize["street"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStreetLine2()
        {
            return this.shouldSerialize["streetLine2"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCity()
        {
            return this.shouldSerialize["city"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStateOrProvince()
        {
            return this.shouldSerialize["stateOrProvince"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePostalCode()
        {
            return this.shouldSerialize["postalCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCountry()
        {
            return this.shouldSerialize["country"];
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
            return obj is Address other &&                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.Street == null && other.Street == null) || (this.Street?.Equals(other.Street) == true)) &&
                ((this.StreetLine2 == null && other.StreetLine2 == null) || (this.StreetLine2?.Equals(other.StreetLine2) == true)) &&
                ((this.City == null && other.City == null) || (this.City?.Equals(other.City) == true)) &&
                ((this.StateOrProvince == null && other.StateOrProvince == null) || (this.StateOrProvince?.Equals(other.StateOrProvince) == true)) &&
                ((this.PostalCode == null && other.PostalCode == null) || (this.PostalCode?.Equals(other.PostalCode) == true)) &&
                ((this.Country == null && other.Country == null) || (this.Country?.Equals(other.Country) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.Street = {(this.Street == null ? "null" : this.Street)}");
            toStringOutput.Add($"this.StreetLine2 = {(this.StreetLine2 == null ? "null" : this.StreetLine2)}");
            toStringOutput.Add($"this.City = {(this.City == null ? "null" : this.City)}");
            toStringOutput.Add($"this.StateOrProvince = {(this.StateOrProvince == null ? "null" : this.StateOrProvince)}");
            toStringOutput.Add($"this.PostalCode = {(this.PostalCode == null ? "null" : this.PostalCode)}");
            toStringOutput.Add($"this.Country = {(this.Country == null ? "null" : this.Country)}");
        }
    }
}