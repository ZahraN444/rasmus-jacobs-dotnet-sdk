// <copyright file="IndustryDataAirlineFlightLeg.cs" company="APIMatic">
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
    /// IndustryDataAirlineFlightLeg.
    /// </summary>
    public class IndustryDataAirlineFlightLeg
    {
        private string carrierCode;
        private string flightNumber;
        private string classOfTravel;
        private string destinationAirportCode;
        private string fareBasisCode;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "carrierCode", false },
            { "flightNumber", false },
            { "classOfTravel", false },
            { "destinationAirportCode", false },
            { "fareBasisCode", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryDataAirlineFlightLeg"/> class.
        /// </summary>
        public IndustryDataAirlineFlightLeg()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndustryDataAirlineFlightLeg"/> class.
        /// </summary>
        /// <param name="carrierCode">carrierCode.</param>
        /// <param name="flightNumber">flightNumber.</param>
        /// <param name="classOfTravel">classOfTravel.</param>
        /// <param name="departureDate">departureDate.</param>
        /// <param name="departureTax">departureTax.</param>
        /// <param name="destinationAirportCode">destinationAirportCode.</param>
        /// <param name="fareBasisCode">fareBasisCode.</param>
        public IndustryDataAirlineFlightLeg(
            string carrierCode = null,
            string flightNumber = null,
            string classOfTravel = null,
            DateTime? departureDate = null,
            int? departureTax = null,
            string destinationAirportCode = null,
            string fareBasisCode = null)
        {
            if (carrierCode != null)
            {
                this.CarrierCode = carrierCode;
            }

            if (flightNumber != null)
            {
                this.FlightNumber = flightNumber;
            }

            if (classOfTravel != null)
            {
                this.ClassOfTravel = classOfTravel;
            }

            this.DepartureDate = departureDate;
            this.DepartureTax = departureTax;
            if (destinationAirportCode != null)
            {
                this.DestinationAirportCode = destinationAirportCode;
            }

            if (fareBasisCode != null)
            {
                this.FareBasisCode = fareBasisCode;
            }

        }

        /// <summary>
        /// IATA 2-letter accounting code that identifies the carrier.
        /// </summary>
        [JsonProperty("carrierCode")]
        public string CarrierCode
        {
            get
            {
                return this.carrierCode;
            }

            set
            {
                this.shouldSerialize["carrierCode"] = true;
                this.carrierCode = value;
            }
        }

        /// <summary>
        /// The carrier's identifier for this flight
        /// </summary>
        [JsonProperty("flightNumber")]
        public string FlightNumber
        {
            get
            {
                return this.flightNumber;
            }

            set
            {
                this.shouldSerialize["flightNumber"] = true;
                this.flightNumber = value;
            }
        }

        /// <summary>
        /// 1-letter travel class identifier
        /// </summary>
        [JsonProperty("classOfTravel")]
        public string ClassOfTravel
        {
            get
            {
                return this.classOfTravel;
            }

            set
            {
                this.shouldSerialize["classOfTravel"] = true;
                this.classOfTravel = value;
            }
        }

        /// <summary>
        /// Departure Date and Time of this leg
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("departureDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DepartureDate { get; set; }

        /// <summary>
        /// Amount charged by a country to an individual upon their leaving in minor units
        /// </summary>
        [JsonProperty("departureTax", NullValueHandling = NullValueHandling.Ignore)]
        public int? DepartureTax { get; set; }

        /// <summary>
        /// Alphabetical identifier of the destination/arrival airport
        /// </summary>
        [JsonProperty("destinationAirportCode")]
        public string DestinationAirportCode
        {
            get
            {
                return this.destinationAirportCode;
            }

            set
            {
                this.shouldSerialize["destinationAirportCode"] = true;
                this.destinationAirportCode = value;
            }
        }

        /// <summary>
        /// alphabetic or alpha-numeric code used by airlines to identify a fare type
        /// </summary>
        [JsonProperty("fareBasisCode")]
        public string FareBasisCode
        {
            get
            {
                return this.fareBasisCode;
            }

            set
            {
                this.shouldSerialize["fareBasisCode"] = true;
                this.fareBasisCode = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"IndustryDataAirlineFlightLeg : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCarrierCode()
        {
            this.shouldSerialize["carrierCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFlightNumber()
        {
            this.shouldSerialize["flightNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetClassOfTravel()
        {
            this.shouldSerialize["classOfTravel"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDestinationAirportCode()
        {
            this.shouldSerialize["destinationAirportCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFareBasisCode()
        {
            this.shouldSerialize["fareBasisCode"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCarrierCode()
        {
            return this.shouldSerialize["carrierCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFlightNumber()
        {
            return this.shouldSerialize["flightNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeClassOfTravel()
        {
            return this.shouldSerialize["classOfTravel"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDestinationAirportCode()
        {
            return this.shouldSerialize["destinationAirportCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFareBasisCode()
        {
            return this.shouldSerialize["fareBasisCode"];
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
            return obj is IndustryDataAirlineFlightLeg other &&                ((this.CarrierCode == null && other.CarrierCode == null) || (this.CarrierCode?.Equals(other.CarrierCode) == true)) &&
                ((this.FlightNumber == null && other.FlightNumber == null) || (this.FlightNumber?.Equals(other.FlightNumber) == true)) &&
                ((this.ClassOfTravel == null && other.ClassOfTravel == null) || (this.ClassOfTravel?.Equals(other.ClassOfTravel) == true)) &&
                ((this.DepartureDate == null && other.DepartureDate == null) || (this.DepartureDate?.Equals(other.DepartureDate) == true)) &&
                ((this.DepartureTax == null && other.DepartureTax == null) || (this.DepartureTax?.Equals(other.DepartureTax) == true)) &&
                ((this.DestinationAirportCode == null && other.DestinationAirportCode == null) || (this.DestinationAirportCode?.Equals(other.DestinationAirportCode) == true)) &&
                ((this.FareBasisCode == null && other.FareBasisCode == null) || (this.FareBasisCode?.Equals(other.FareBasisCode) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CarrierCode = {(this.CarrierCode == null ? "null" : this.CarrierCode)}");
            toStringOutput.Add($"this.FlightNumber = {(this.FlightNumber == null ? "null" : this.FlightNumber)}");
            toStringOutput.Add($"this.ClassOfTravel = {(this.ClassOfTravel == null ? "null" : this.ClassOfTravel)}");
            toStringOutput.Add($"this.DepartureDate = {(this.DepartureDate == null ? "null" : this.DepartureDate.ToString())}");
            toStringOutput.Add($"this.DepartureTax = {(this.DepartureTax == null ? "null" : this.DepartureTax.ToString())}");
            toStringOutput.Add($"this.DestinationAirportCode = {(this.DestinationAirportCode == null ? "null" : this.DestinationAirportCode)}");
            toStringOutput.Add($"this.FareBasisCode = {(this.FareBasisCode == null ? "null" : this.FareBasisCode)}");
        }
    }
}