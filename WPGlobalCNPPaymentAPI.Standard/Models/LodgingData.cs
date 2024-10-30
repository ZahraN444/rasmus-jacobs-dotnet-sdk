// <copyright file="LodgingData.cs" company="APIMatic">
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
    /// LodgingData.
    /// </summary>
    public class LodgingData : BaseIndustryData
    {
        private string hotelFolioNumber;
        private string customerServiceTollFreeNumber;
        private string propertyLocalPhoneNumber;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "hotelFolioNumber", false },
            { "customerServiceTollFreeNumber", false },
            { "propertyLocalPhoneNumber", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingData"/> class.
        /// </summary>
        public LodgingData()
        {
            this.Type = "industry/lodging";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LodgingData"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="hotelFolioNumber">hotelFolioNumber.</param>
        /// <param name="checkInDate">checkInDate.</param>
        /// <param name="checkOutDate">checkOutDate.</param>
        /// <param name="numberOfDays">numberOfDays.</param>
        /// <param name="numberOfAdults">numberOfAdults.</param>
        /// <param name="customerServiceTollFreeNumber">customerServiceTollFreeNumber.</param>
        /// <param name="propertyLocalPhoneNumber">propertyLocalPhoneNumber.</param>
        /// <param name="fireSafetyIndicator">fireSafetyIndicator.</param>
        /// <param name="roomRate">roomRate.</param>
        /// <param name="roomTax">roomTax.</param>
        public LodgingData(
            string type = "industry/lodging",
            string hotelFolioNumber = null,
            DateTime? checkInDate = null,
            DateTime? checkOutDate = null,
            int? numberOfDays = null,
            int? numberOfAdults = null,
            string customerServiceTollFreeNumber = null,
            string propertyLocalPhoneNumber = null,
            bool? fireSafetyIndicator = null,
            Models.Amount roomRate = null,
            Models.Amount roomTax = null)
            : base(
                type)
        {
            if (hotelFolioNumber != null)
            {
                this.HotelFolioNumber = hotelFolioNumber;
            }

            this.CheckInDate = checkInDate;
            this.CheckOutDate = checkOutDate;
            this.NumberOfDays = numberOfDays;
            this.NumberOfAdults = numberOfAdults;
            if (customerServiceTollFreeNumber != null)
            {
                this.CustomerServiceTollFreeNumber = customerServiceTollFreeNumber;
            }

            if (propertyLocalPhoneNumber != null)
            {
                this.PropertyLocalPhoneNumber = propertyLocalPhoneNumber;
            }

            this.FireSafetyIndicator = fireSafetyIndicator;
            this.RoomRate = roomRate;
            this.RoomTax = roomTax;
        }

        /// <summary>
        /// Card acceptor’s internal invoice or billing ID reference number.
        /// </summary>
        [JsonProperty("hotelFolioNumber")]
        public string HotelFolioNumber
        {
            get
            {
                return this.hotelFolioNumber;
            }

            set
            {
                this.shouldSerialize["hotelFolioNumber"] = true;
                this.hotelFolioNumber = value;
            }
        }

        /// <summary>
        /// The Date you are checking in
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("checkInDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CheckInDate { get; set; }

        /// <summary>
        /// The Date you are checking out
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("checkOutDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CheckOutDate { get; set; }

        /// <summary>
        /// Total number of nights the room will be rented.
        /// </summary>
        [JsonProperty("numberOfDays", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfDays { get; set; }

        /// <summary>
        /// The total amount of adults staying in the room
        /// </summary>
        [JsonProperty("numberOfAdults", NullValueHandling = NullValueHandling.Ignore)]
        public int? NumberOfAdults { get; set; }

        /// <summary>
        /// The toll free phone number for customer service
        /// </summary>
        [JsonProperty("customerServiceTollFreeNumber")]
        public string CustomerServiceTollFreeNumber
        {
            get
            {
                return this.customerServiceTollFreeNumber;
            }

            set
            {
                this.shouldSerialize["customerServiceTollFreeNumber"] = true;
                this.customerServiceTollFreeNumber = value;
            }
        }

        /// <summary>
        /// The local phone number for the property
        /// </summary>
        [JsonProperty("propertyLocalPhoneNumber")]
        public string PropertyLocalPhoneNumber
        {
            get
            {
                return this.propertyLocalPhoneNumber;
            }

            set
            {
                this.shouldSerialize["propertyLocalPhoneNumber"] = true;
                this.propertyLocalPhoneNumber = value;
            }
        }

        /// <summary>
        /// Does the facility complies with the Hotel and Motel Fire Safety Act of 1990
        /// </summary>
        [JsonProperty("fireSafetyIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FireSafetyIndicator { get; set; }

        /// <summary>
        /// Gets or sets RoomRate.
        /// </summary>
        [JsonProperty("roomRate", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount RoomRate { get; set; }

        /// <summary>
        /// Gets or sets RoomTax.
        /// </summary>
        [JsonProperty("roomTax", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount RoomTax { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LodgingData : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetHotelFolioNumber()
        {
            this.shouldSerialize["hotelFolioNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerServiceTollFreeNumber()
        {
            this.shouldSerialize["customerServiceTollFreeNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetPropertyLocalPhoneNumber()
        {
            this.shouldSerialize["propertyLocalPhoneNumber"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeHotelFolioNumber()
        {
            return this.shouldSerialize["hotelFolioNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerServiceTollFreeNumber()
        {
            return this.shouldSerialize["customerServiceTollFreeNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializePropertyLocalPhoneNumber()
        {
            return this.shouldSerialize["propertyLocalPhoneNumber"];
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
            return obj is LodgingData other &&                ((this.HotelFolioNumber == null && other.HotelFolioNumber == null) || (this.HotelFolioNumber?.Equals(other.HotelFolioNumber) == true)) &&
                ((this.CheckInDate == null && other.CheckInDate == null) || (this.CheckInDate?.Equals(other.CheckInDate) == true)) &&
                ((this.CheckOutDate == null && other.CheckOutDate == null) || (this.CheckOutDate?.Equals(other.CheckOutDate) == true)) &&
                ((this.NumberOfDays == null && other.NumberOfDays == null) || (this.NumberOfDays?.Equals(other.NumberOfDays) == true)) &&
                ((this.NumberOfAdults == null && other.NumberOfAdults == null) || (this.NumberOfAdults?.Equals(other.NumberOfAdults) == true)) &&
                ((this.CustomerServiceTollFreeNumber == null && other.CustomerServiceTollFreeNumber == null) || (this.CustomerServiceTollFreeNumber?.Equals(other.CustomerServiceTollFreeNumber) == true)) &&
                ((this.PropertyLocalPhoneNumber == null && other.PropertyLocalPhoneNumber == null) || (this.PropertyLocalPhoneNumber?.Equals(other.PropertyLocalPhoneNumber) == true)) &&
                ((this.FireSafetyIndicator == null && other.FireSafetyIndicator == null) || (this.FireSafetyIndicator?.Equals(other.FireSafetyIndicator) == true)) &&
                ((this.RoomRate == null && other.RoomRate == null) || (this.RoomRate?.Equals(other.RoomRate) == true)) &&
                ((this.RoomTax == null && other.RoomTax == null) || (this.RoomTax?.Equals(other.RoomTax) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.HotelFolioNumber = {(this.HotelFolioNumber == null ? "null" : this.HotelFolioNumber)}");
            toStringOutput.Add($"this.CheckInDate = {(this.CheckInDate == null ? "null" : this.CheckInDate.ToString())}");
            toStringOutput.Add($"this.CheckOutDate = {(this.CheckOutDate == null ? "null" : this.CheckOutDate.ToString())}");
            toStringOutput.Add($"this.NumberOfDays = {(this.NumberOfDays == null ? "null" : this.NumberOfDays.ToString())}");
            toStringOutput.Add($"this.NumberOfAdults = {(this.NumberOfAdults == null ? "null" : this.NumberOfAdults.ToString())}");
            toStringOutput.Add($"this.CustomerServiceTollFreeNumber = {(this.CustomerServiceTollFreeNumber == null ? "null" : this.CustomerServiceTollFreeNumber)}");
            toStringOutput.Add($"this.PropertyLocalPhoneNumber = {(this.PropertyLocalPhoneNumber == null ? "null" : this.PropertyLocalPhoneNumber)}");
            toStringOutput.Add($"this.FireSafetyIndicator = {(this.FireSafetyIndicator == null ? "null" : this.FireSafetyIndicator.ToString())}");
            toStringOutput.Add($"this.RoomRate = {(this.RoomRate == null ? "null" : this.RoomRate.ToString())}");
            toStringOutput.Add($"this.RoomTax = {(this.RoomTax == null ? "null" : this.RoomTax.ToString())}");

            base.ToString(toStringOutput);
        }
    }
}