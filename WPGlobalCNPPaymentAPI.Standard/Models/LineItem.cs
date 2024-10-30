// <copyright file="LineItem.cs" company="APIMatic">
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
    /// LineItem.
    /// </summary>
    public class LineItem
    {
        private string id;
        private string description;
        private string qtyUnitOfMeasure;
        private string productUrl;
        private string imageUrl;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "id", false },
            { "description", false },
            { "qtyUnitOfMeasure", false },
            { "productUrl", false },
            { "imageUrl", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem"/> class.
        /// </summary>
        public LineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LineItem"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="description">description.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="qtyUnitOfMeasure">qtyUnitOfMeasure.</param>
        /// <param name="unitPrice">unitPrice.</param>
        /// <param name="taxPercentage">taxPercentage.</param>
        /// <param name="taxAmount">taxAmount.</param>
        /// <param name="amountIncludingTax">amountIncludingTax.</param>
        /// <param name="productUrl">productUrl.</param>
        /// <param name="imageUrl">imageUrl.</param>
        public LineItem(
            string id = null,
            string description = null,
            int? quantity = null,
            string qtyUnitOfMeasure = null,
            int? unitPrice = null,
            int? taxPercentage = null,
            int? taxAmount = null,
            int? amountIncludingTax = null,
            string productUrl = null,
            string imageUrl = null)
        {
            if (id != null)
            {
                this.Id = id;
            }

            if (description != null)
            {
                this.Description = description;
            }

            this.Quantity = quantity;
            if (qtyUnitOfMeasure != null)
            {
                this.QtyUnitOfMeasure = qtyUnitOfMeasure;
            }

            this.UnitPrice = unitPrice;
            this.TaxPercentage = taxPercentage;
            this.TaxAmount = taxAmount;
            this.AmountIncludingTax = amountIncludingTax;
            if (productUrl != null)
            {
                this.ProductUrl = productUrl;
            }

            if (imageUrl != null)
            {
                this.ImageUrl = imageUrl;
            }

        }

        /// <summary>
        /// Gets or sets Id.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get
            {
                return this.id;
            }

            set
            {
                this.shouldSerialize["id"] = true;
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets Description.
        /// </summary>
        [JsonProperty("description")]
        public string Description
        {
            get
            {
                return this.description;
            }

            set
            {
                this.shouldSerialize["description"] = true;
                this.description = value;
            }
        }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets QtyUnitOfMeasure.
        /// </summary>
        [JsonProperty("qtyUnitOfMeasure")]
        public string QtyUnitOfMeasure
        {
            get
            {
                return this.qtyUnitOfMeasure;
            }

            set
            {
                this.shouldSerialize["qtyUnitOfMeasure"] = true;
                this.qtyUnitOfMeasure = value;
            }
        }

        /// <summary>
        /// Gets or sets UnitPrice.
        /// </summary>
        [JsonProperty("unitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnitPrice { get; set; }

        /// <summary>
        /// Gets or sets TaxPercentage.
        /// </summary>
        [JsonProperty("taxPercentage", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaxPercentage { get; set; }

        /// <summary>
        /// Gets or sets TaxAmount.
        /// </summary>
        [JsonProperty("taxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public int? TaxAmount { get; set; }

        /// <summary>
        /// Gets or sets AmountIncludingTax.
        /// </summary>
        [JsonProperty("amountIncludingTax", NullValueHandling = NullValueHandling.Ignore)]
        public int? AmountIncludingTax { get; set; }

        /// <summary>
        /// Gets or sets ProductUrl.
        /// </summary>
        [JsonProperty("productUrl")]
        public string ProductUrl
        {
            get
            {
                return this.productUrl;
            }

            set
            {
                this.shouldSerialize["productUrl"] = true;
                this.productUrl = value;
            }
        }

        /// <summary>
        /// Gets or sets ImageUrl.
        /// </summary>
        [JsonProperty("imageUrl")]
        public string ImageUrl
        {
            get
            {
                return this.imageUrl;
            }

            set
            {
                this.shouldSerialize["imageUrl"] = true;
                this.imageUrl = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"LineItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetId()
        {
            this.shouldSerialize["id"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDescription()
        {
            this.shouldSerialize["description"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetQtyUnitOfMeasure()
        {
            this.shouldSerialize["qtyUnitOfMeasure"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductUrl()
        {
            this.shouldSerialize["productUrl"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetImageUrl()
        {
            this.shouldSerialize["imageUrl"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeId()
        {
            return this.shouldSerialize["id"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDescription()
        {
            return this.shouldSerialize["description"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeQtyUnitOfMeasure()
        {
            return this.shouldSerialize["qtyUnitOfMeasure"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductUrl()
        {
            return this.shouldSerialize["productUrl"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeImageUrl()
        {
            return this.shouldSerialize["imageUrl"];
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
            return obj is LineItem other &&                ((this.Id == null && other.Id == null) || (this.Id?.Equals(other.Id) == true)) &&
                ((this.Description == null && other.Description == null) || (this.Description?.Equals(other.Description) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.QtyUnitOfMeasure == null && other.QtyUnitOfMeasure == null) || (this.QtyUnitOfMeasure?.Equals(other.QtyUnitOfMeasure) == true)) &&
                ((this.UnitPrice == null && other.UnitPrice == null) || (this.UnitPrice?.Equals(other.UnitPrice) == true)) &&
                ((this.TaxPercentage == null && other.TaxPercentage == null) || (this.TaxPercentage?.Equals(other.TaxPercentage) == true)) &&
                ((this.TaxAmount == null && other.TaxAmount == null) || (this.TaxAmount?.Equals(other.TaxAmount) == true)) &&
                ((this.AmountIncludingTax == null && other.AmountIncludingTax == null) || (this.AmountIncludingTax?.Equals(other.AmountIncludingTax) == true)) &&
                ((this.ProductUrl == null && other.ProductUrl == null) || (this.ProductUrl?.Equals(other.ProductUrl) == true)) &&
                ((this.ImageUrl == null && other.ImageUrl == null) || (this.ImageUrl?.Equals(other.ImageUrl) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Id = {(this.Id == null ? "null" : this.Id)}");
            toStringOutput.Add($"this.Description = {(this.Description == null ? "null" : this.Description)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.QtyUnitOfMeasure = {(this.QtyUnitOfMeasure == null ? "null" : this.QtyUnitOfMeasure)}");
            toStringOutput.Add($"this.UnitPrice = {(this.UnitPrice == null ? "null" : this.UnitPrice.ToString())}");
            toStringOutput.Add($"this.TaxPercentage = {(this.TaxPercentage == null ? "null" : this.TaxPercentage.ToString())}");
            toStringOutput.Add($"this.TaxAmount = {(this.TaxAmount == null ? "null" : this.TaxAmount.ToString())}");
            toStringOutput.Add($"this.AmountIncludingTax = {(this.AmountIncludingTax == null ? "null" : this.AmountIncludingTax.ToString())}");
            toStringOutput.Add($"this.ProductUrl = {(this.ProductUrl == null ? "null" : this.ProductUrl)}");
            toStringOutput.Add($"this.ImageUrl = {(this.ImageUrl == null ? "null" : this.ImageUrl)}");
        }
    }
}