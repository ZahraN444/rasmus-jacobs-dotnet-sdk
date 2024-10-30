// <copyright file="AirlineData.cs" company="APIMatic">
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
    /// AirlineData.
    /// </summary>
    public class AirlineData : BaseIndustryData
    {
        private string airlineCode;
        private string ticketNumber;
        private List<Models.IndustryDataAirlineFlightLeg> tripLegs;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "airlineCode", false },
            { "ticketNumber", false },
            { "tripLegs", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineData"/> class.
        /// </summary>
        public AirlineData()
        {
            this.Type = "industry/airline";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AirlineData"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="airlineCode">airlineCode.</param>
        /// <param name="ticketNumber">ticketNumber.</param>
        /// <param name="departureDate">departureDate.</param>
        /// <param name="passenger">passenger.</param>
        /// <param name="tripLegs">tripLegs.</param>
        /// <param name="travelAgency">travelAgency.</param>
        public AirlineData(
            string type = "industry/airline",
            string airlineCode = null,
            string ticketNumber = null,
            DateTime? departureDate = null,
            Models.IndustryDataAirlinePassenger passenger = null,
            List<Models.IndustryDataAirlineFlightLeg> tripLegs = null,
            Models.IndustryDataAirlineTravelAgency travelAgency = null)
            : base(
                type)
        {
            if (airlineCode != null)
            {
                this.AirlineCode = airlineCode;
            }

            if (ticketNumber != null)
            {
                this.TicketNumber = ticketNumber;
            }

            this.DepartureDate = departureDate;
            this.Passenger = passenger;
            if (tripLegs != null)
            {
                this.TripLegs = tripLegs;
            }

            this.TravelAgency = travelAgency;
        }

        /// <summary>
        /// IATA 3 digit code that identifies the carrier
        /// </summary>
        [JsonProperty("airlineCode")]
        public string AirlineCode
        {
            get
            {
                return this.airlineCode;
            }

            set
            {
                this.shouldSerialize["airlineCode"] = true;
                this.airlineCode = value;
            }
        }

        /// <summary>
        /// The ticket's unique identifier
        /// </summary>
        [JsonProperty("ticketNumber")]
        public string TicketNumber
        {
            get
            {
                return this.ticketNumber;
            }

            set
            {
                this.shouldSerialize["ticketNumber"] = true;
                this.ticketNumber = value;
            }
        }

        /// <summary>
        /// Flight departure date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("departureDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? DepartureDate { get; set; }

        /// <summary>
        /// Gets or sets Passenger.
        /// </summary>
        [JsonProperty("passenger", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IndustryDataAirlinePassenger Passenger { get; set; }

        /// <summary>
        /// Information about each leg of the flight
        /// </summary>
        [JsonProperty("tripLegs")]
        public List<Models.IndustryDataAirlineFlightLeg> TripLegs
        {
            get
            {
                return this.tripLegs;
            }

            set
            {
                this.shouldSerialize["tripLegs"] = true;
                this.tripLegs = value;
            }
        }

        /// <summary>
        /// Gets or sets TravelAgency.
        /// </summary>
        [JsonProperty("travelAgency", NullValueHandling = NullValueHandling.Ignore)]
        public Models.IndustryDataAirlineTravelAgency TravelAgency { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"AirlineData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetAirlineCode()
        {
            this.shouldSerialize["airlineCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTicketNumber()
        {
            this.shouldSerialize["ticketNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTripLegs()
        {
            this.shouldSerialize["tripLegs"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeAirlineCode()
        {
            return this.shouldSerialize["airlineCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTicketNumber()
        {
            return this.shouldSerialize["ticketNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTripLegs()
        {
            return this.shouldSerialize["tripLegs"];
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
            return obj is AirlineData other &&                ((this.AirlineCode == null && other.AirlineCode == null) || (this.AirlineCode?.Equals(other.AirlineCode) == true)) &&
                ((this.TicketNumber == null && other.TicketNumber == null) || (this.TicketNumber?.Equals(other.TicketNumber) == true)) &&
                ((this.DepartureDate == null && other.DepartureDate == null) || (this.DepartureDate?.Equals(other.DepartureDate) == true)) &&
                ((this.Passenger == null && other.Passenger == null) || (this.Passenger?.Equals(other.Passenger) == true)) &&
                ((this.TripLegs == null && other.TripLegs == null) || (this.TripLegs?.Equals(other.TripLegs) == true)) &&
                ((this.TravelAgency == null && other.TravelAgency == null) || (this.TravelAgency?.Equals(other.TravelAgency) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.AirlineCode = {(this.AirlineCode == null ? "null" : this.AirlineCode)}");
            toStringOutput.Add($"this.TicketNumber = {(this.TicketNumber == null ? "null" : this.TicketNumber)}");
            toStringOutput.Add($"this.DepartureDate = {(this.DepartureDate == null ? "null" : this.DepartureDate.ToString())}");
            toStringOutput.Add($"this.Passenger = {(this.Passenger == null ? "null" : this.Passenger.ToString())}");
            toStringOutput.Add($"this.TripLegs = {(this.TripLegs == null ? "null" : $"[{string.Join(", ", this.TripLegs)} ]")}");
            toStringOutput.Add($"this.TravelAgency = {(this.TravelAgency == null ? "null" : this.TravelAgency.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}