// <copyright file="IndustryDataAirlinePassenger.cs" company="APIMatic">
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
    /// IndustryDataAirlinePassenger.
    /// </summary>
    public class IndustryDataAirlinePassenger
    {
        private string firstName;
        private string lastName;
        private string telephoneNumber;
        private string travelerType;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "firstName", false },
            { "lastName", false },
            { "telephoneNumber", false },
            { "travelerType", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryDataAirlinePassenger"/> class.
        /// </summary>
        public IndustryDataAirlinePassenger()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryDataAirlinePassenger"/> class.
        /// </summary>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="dateOfBirth">dateOfBirth.</param>
        /// <param name="telephoneNumber">telephoneNumber.</param>
        /// <param name="travelerType">travelerType.</param>
        public IndustryDataAirlinePassenger(
            string firstName = null,
            string lastName = null,
            DateTime? dateOfBirth = null,
            string telephoneNumber = null,
            string travelerType = null)
        {
            if (firstName != null)
            {
                this.FirstName = firstName;
            }

            if (lastName != null)
            {
                this.LastName = lastName;
            }

            this.DateOfBirth = dateOfBirth;
            if (telephoneNumber != null)
            {
                this.TelephoneNumber = telephoneNumber;
            }

            if (travelerType != null)
            {
                this.TravelerType = travelerType;
            }

        }

        /// <summary>
        /// Passenger's first name/given name.
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
        /// Passenger's last name/family name.
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
        /// Passenger's Date of Birth
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("dateOfBirth", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Passenger's Telephone Number
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
        /// IATA PTC (Passenger type code)
        /// </summary>
        [JsonProperty("travelerType")]
        public string TravelerType
        {
            get
            {
                return this.travelerType;
            }

            set
            {
                this.shouldSerialize["travelerType"] = true;
                this.travelerType = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IndustryDataAirlinePassenger : ({string.Join(", ", toStringOutput)})";
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
        public void UnsetTelephoneNumber()
        {
            this.shouldSerialize["telephoneNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTravelerType()
        {
            this.shouldSerialize["travelerType"] = false;
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
        public bool ShouldSerializeTelephoneNumber()
        {
            return this.shouldSerialize["telephoneNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTravelerType()
        {
            return this.shouldSerialize["travelerType"];
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
            return obj is IndustryDataAirlinePassenger other &&                ((this.FirstName == null && other.FirstName == null) || (this.FirstName?.Equals(other.FirstName) == true)) &&
                ((this.LastName == null && other.LastName == null) || (this.LastName?.Equals(other.LastName) == true)) &&
                ((this.DateOfBirth == null && other.DateOfBirth == null) || (this.DateOfBirth?.Equals(other.DateOfBirth) == true)) &&
                ((this.TelephoneNumber == null && other.TelephoneNumber == null) || (this.TelephoneNumber?.Equals(other.TelephoneNumber) == true)) &&
                ((this.TravelerType == null && other.TravelerType == null) || (this.TravelerType?.Equals(other.TravelerType) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FirstName = {(this.FirstName == null ? "null" : this.FirstName)}");
            toStringOutput.Add($"this.LastName = {(this.LastName == null ? "null" : this.LastName)}");
            toStringOutput.Add($"this.DateOfBirth = {(this.DateOfBirth == null ? "null" : this.DateOfBirth.ToString())}");
            toStringOutput.Add($"this.TelephoneNumber = {(this.TelephoneNumber == null ? "null" : this.TelephoneNumber)}");
            toStringOutput.Add($"this.TravelerType = {(this.TravelerType == null ? "null" : this.TravelerType)}");
        }
    }
}