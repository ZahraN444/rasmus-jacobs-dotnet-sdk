// <copyright file="Level2and3Data.cs" company="APIMatic">
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
    /// Level2and3Data.
    /// </summary>
    public class Level2and3Data : BaseIndustryData
    {
        private string customerReference;
        private string invoiceReferenceNo;
        private string shipFromCountryCode;
        private string shipFromPostalCode;
        private string destinationCountryCode;
        private string destinationPostalCode;
        private List<Models.Level2and3LineItem> lineItems;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "customerReference", false },
            { "invoiceReferenceNo", false },
            { "shipFromCountryCode", false },
            { "shipFromPostalCode", false },
            { "destinationCountryCode", false },
            { "destinationPostalCode", false },
            { "lineItems", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Level2and3Data"/> class.
        /// </summary>
        public Level2and3Data()
        {
            this.Type = "industry/level2_3";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Level2and3Data"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="customerReference">customerReference.</param>
        /// <param name="invoiceReferenceNo">invoiceReferenceNo.</param>
        /// <param name="orderDate">orderDate.</param>
        /// <param name="shipFromCountryCode">shipFromCountryCode.</param>
        /// <param name="shipFromPostalCode">shipFromPostalCode.</param>
        /// <param name="destinationCountryCode">destinationCountryCode.</param>
        /// <param name="destinationPostalCode">destinationPostalCode.</param>
        /// <param name="lineItems">lineItems.</param>
        public Level2and3Data(
            string type = "industry/level2_3",
            string customerReference = null,
            string invoiceReferenceNo = null,
            DateTime? orderDate = null,
            string shipFromCountryCode = null,
            string shipFromPostalCode = null,
            string destinationCountryCode = null,
            string destinationPostalCode = null,
            List<Models.Level2and3LineItem> lineItems = null)
            : base(
                type)
        {
            if (customerReference != null)
            {
                this.CustomerReference = customerReference;
            }

            if (invoiceReferenceNo != null)
            {
                this.InvoiceReferenceNo = invoiceReferenceNo;
            }

            this.OrderDate = orderDate;
            if (shipFromCountryCode != null)
            {
                this.ShipFromCountryCode = shipFromCountryCode;
            }

            if (shipFromPostalCode != null)
            {
                this.ShipFromPostalCode = shipFromPostalCode;
            }

            if (destinationCountryCode != null)
            {
                this.DestinationCountryCode = destinationCountryCode;
            }

            if (destinationPostalCode != null)
            {
                this.DestinationPostalCode = destinationPostalCode;
            }

            if (lineItems != null)
            {
                this.LineItems = lineItems;
            }

        }

        /// <summary>
        /// Card acceptor’s internal invoice or billing ID reference number.
        /// </summary>
        [JsonProperty("customerReference")]
        public string CustomerReference
        {
            get
            {
                return this.customerReference;
            }

            set
            {
                this.shouldSerialize["customerReference"] = true;
                this.customerReference = value;
            }
        }

        /// <summary>
        /// Gets or sets InvoiceReferenceNo.
        /// </summary>
        [JsonProperty("invoiceReferenceNo")]
        public string InvoiceReferenceNo
        {
            get
            {
                return this.invoiceReferenceNo;
            }

            set
            {
                this.shouldSerialize["invoiceReferenceNo"] = true;
                this.invoiceReferenceNo = value;
            }
        }

        /// <summary>
        /// Gets or sets OrderDate.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("orderDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? OrderDate { get; set; }

        /// <summary>
        /// Gets or sets ShipFromCountryCode.
        /// </summary>
        [JsonProperty("shipFromCountryCode")]
        public string ShipFromCountryCode
        {
            get
            {
                return this.shipFromCountryCode;
            }

            set
            {
                this.shouldSerialize["shipFromCountryCode"] = true;
                this.shipFromCountryCode = value;
            }
        }

        /// <summary>
        /// Gets or sets ShipFromPostalCode.
        /// </summary>
        [JsonProperty("shipFromPostalCode")]
        public string ShipFromPostalCode
        {
            get
            {
                return this.shipFromPostalCode;
            }

            set
            {
                this.shouldSerialize["shipFromPostalCode"] = true;
                this.shipFromPostalCode = value;
            }
        }

        /// <summary>
        /// Gets or sets DestinationCountryCode.
        /// </summary>
        [JsonProperty("destinationCountryCode")]
        public string DestinationCountryCode
        {
            get
            {
                return this.destinationCountryCode;
            }

            set
            {
                this.shouldSerialize["destinationCountryCode"] = true;
                this.destinationCountryCode = value;
            }
        }

        /// <summary>
        /// Gets or sets DestinationPostalCode.
        /// </summary>
        [JsonProperty("destinationPostalCode")]
        public string DestinationPostalCode
        {
            get
            {
                return this.destinationPostalCode;
            }

            set
            {
                this.shouldSerialize["destinationPostalCode"] = true;
                this.destinationPostalCode = value;
            }
        }

        /// <summary>
        /// Line items associated with this order
        /// </summary>
        [JsonProperty("lineItems")]
        public List<Models.Level2and3LineItem> LineItems
        {
            get
            {
                return this.lineItems;
            }

            set
            {
                this.shouldSerialize["lineItems"] = true;
                this.lineItems = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Level2and3Data : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCustomerReference()
        {
            this.shouldSerialize["customerReference"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInvoiceReferenceNo()
        {
            this.shouldSerialize["invoiceReferenceNo"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetShipFromCountryCode()
        {
            this.shouldSerialize["shipFromCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetShipFromPostalCode()
        {
            this.shouldSerialize["shipFromPostalCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDestinationCountryCode()
        {
            this.shouldSerialize["destinationCountryCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDestinationPostalCode()
        {
            this.shouldSerialize["destinationPostalCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetLineItems()
        {
            this.shouldSerialize["lineItems"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCustomerReference()
        {
            return this.shouldSerialize["customerReference"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInvoiceReferenceNo()
        {
            return this.shouldSerialize["invoiceReferenceNo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShipFromCountryCode()
        {
            return this.shouldSerialize["shipFromCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeShipFromPostalCode()
        {
            return this.shouldSerialize["shipFromPostalCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDestinationCountryCode()
        {
            return this.shouldSerialize["destinationCountryCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDestinationPostalCode()
        {
            return this.shouldSerialize["destinationPostalCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeLineItems()
        {
            return this.shouldSerialize["lineItems"];
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
            return obj is Level2and3Data other &&                ((this.CustomerReference == null && other.CustomerReference == null) || (this.CustomerReference?.Equals(other.CustomerReference) == true)) &&
                ((this.InvoiceReferenceNo == null && other.InvoiceReferenceNo == null) || (this.InvoiceReferenceNo?.Equals(other.InvoiceReferenceNo) == true)) &&
                ((this.OrderDate == null && other.OrderDate == null) || (this.OrderDate?.Equals(other.OrderDate) == true)) &&
                ((this.ShipFromCountryCode == null && other.ShipFromCountryCode == null) || (this.ShipFromCountryCode?.Equals(other.ShipFromCountryCode) == true)) &&
                ((this.ShipFromPostalCode == null && other.ShipFromPostalCode == null) || (this.ShipFromPostalCode?.Equals(other.ShipFromPostalCode) == true)) &&
                ((this.DestinationCountryCode == null && other.DestinationCountryCode == null) || (this.DestinationCountryCode?.Equals(other.DestinationCountryCode) == true)) &&
                ((this.DestinationPostalCode == null && other.DestinationPostalCode == null) || (this.DestinationPostalCode?.Equals(other.DestinationPostalCode) == true)) &&
                ((this.LineItems == null && other.LineItems == null) || (this.LineItems?.Equals(other.LineItems) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.CustomerReference = {(this.CustomerReference == null ? "null" : this.CustomerReference)}");
            toStringOutput.Add($"this.InvoiceReferenceNo = {(this.InvoiceReferenceNo == null ? "null" : this.InvoiceReferenceNo)}");
            toStringOutput.Add($"this.OrderDate = {(this.OrderDate == null ? "null" : this.OrderDate.ToString())}");
            toStringOutput.Add($"this.ShipFromCountryCode = {(this.ShipFromCountryCode == null ? "null" : this.ShipFromCountryCode)}");
            toStringOutput.Add($"this.ShipFromPostalCode = {(this.ShipFromPostalCode == null ? "null" : this.ShipFromPostalCode)}");
            toStringOutput.Add($"this.DestinationCountryCode = {(this.DestinationCountryCode == null ? "null" : this.DestinationCountryCode)}");
            toStringOutput.Add($"this.DestinationPostalCode = {(this.DestinationPostalCode == null ? "null" : this.DestinationPostalCode)}");
            toStringOutput.Add($"this.LineItems = {(this.LineItems == null ? "null" : $"[{string.Join(", ", this.LineItems)} ]")}");

            base.ToString(toStringOutput);
        }
    }
}