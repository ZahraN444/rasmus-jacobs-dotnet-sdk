// <copyright file="Level2and3LineItem.cs" company="APIMatic">
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
    /// Level2and3LineItem.
    /// </summary>
    public class Level2and3LineItem
    {
        private string itemSequenceNo;
        private string commodityCode;
        private string itemDescription;
        private string productCode;
        private string uom;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "itemSequenceNo", false },
            { "commodityCode", false },
            { "itemDescription", false },
            { "productCode", false },
            { "uom", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="Level2and3LineItem"/> class.
        /// </summary>
        public Level2and3LineItem()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Level2and3LineItem"/> class.
        /// </summary>
        /// <param name="itemSequenceNo">itemSequenceNo.</param>
        /// <param name="commodityCode">commodityCode.</param>
        /// <param name="itemDescription">itemDescription.</param>
        /// <param name="productCode">productCode.</param>
        /// <param name="quantity">quantity.</param>
        /// <param name="uom">uom.</param>
        /// <param name="unitCost">unitCost.</param>
        /// <param name="itemDiscountAmount">itemDiscountAmount.</param>
        /// <param name="lineItemTotal">lineItemTotal.</param>
        public Level2and3LineItem(
            string itemSequenceNo = null,
            string commodityCode = null,
            string itemDescription = null,
            string productCode = null,
            int? quantity = null,
            string uom = null,
            Models.Amount unitCost = null,
            Models.Amount itemDiscountAmount = null,
            Models.Amount lineItemTotal = null)
        {
            if (itemSequenceNo != null)
            {
                this.ItemSequenceNo = itemSequenceNo;
            }

            if (commodityCode != null)
            {
                this.CommodityCode = commodityCode;
            }

            if (itemDescription != null)
            {
                this.ItemDescription = itemDescription;
            }

            if (productCode != null)
            {
                this.ProductCode = productCode;
            }

            this.Quantity = quantity;
            if (uom != null)
            {
                this.Uom = uom;
            }

            this.UnitCost = unitCost;
            this.ItemDiscountAmount = itemDiscountAmount;
            this.LineItemTotal = lineItemTotal;
        }

        /// <summary>
        /// Gets or sets ItemSequenceNo.
        /// </summary>
        [JsonProperty("itemSequenceNo")]
        public string ItemSequenceNo
        {
            get
            {
                return this.itemSequenceNo;
            }

            set
            {
                this.shouldSerialize["itemSequenceNo"] = true;
                this.itemSequenceNo = value;
            }
        }

        /// <summary>
        /// Gets or sets CommodityCode.
        /// </summary>
        [JsonProperty("commodityCode")]
        public string CommodityCode
        {
            get
            {
                return this.commodityCode;
            }

            set
            {
                this.shouldSerialize["commodityCode"] = true;
                this.commodityCode = value;
            }
        }

        /// <summary>
        /// Gets or sets ItemDescription.
        /// </summary>
        [JsonProperty("itemDescription")]
        public string ItemDescription
        {
            get
            {
                return this.itemDescription;
            }

            set
            {
                this.shouldSerialize["itemDescription"] = true;
                this.itemDescription = value;
            }
        }

        /// <summary>
        /// Gets or sets ProductCode.
        /// </summary>
        [JsonProperty("productCode")]
        public string ProductCode
        {
            get
            {
                return this.productCode;
            }

            set
            {
                this.shouldSerialize["productCode"] = true;
                this.productCode = value;
            }
        }

        /// <summary>
        /// Gets or sets Quantity.
        /// </summary>
        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets Uom.
        /// </summary>
        [JsonProperty("uom")]
        public string Uom
        {
            get
            {
                return this.uom;
            }

            set
            {
                this.shouldSerialize["uom"] = true;
                this.uom = value;
            }
        }

        /// <summary>
        /// Gets or sets UnitCost.
        /// </summary>
        [JsonProperty("unitCost", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount UnitCost { get; set; }

        /// <summary>
        /// Gets or sets ItemDiscountAmount.
        /// </summary>
        [JsonProperty("itemDiscountAmount", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount ItemDiscountAmount { get; set; }

        /// <summary>
        /// Gets or sets LineItemTotal.
        /// </summary>
        [JsonProperty("lineItemTotal", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Amount LineItemTotal { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"Level2and3LineItem : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetItemSequenceNo()
        {
            this.shouldSerialize["itemSequenceNo"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetCommodityCode()
        {
            this.shouldSerialize["commodityCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetItemDescription()
        {
            this.shouldSerialize["itemDescription"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetProductCode()
        {
            this.shouldSerialize["productCode"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetUom()
        {
            this.shouldSerialize["uom"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeItemSequenceNo()
        {
            return this.shouldSerialize["itemSequenceNo"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeCommodityCode()
        {
            return this.shouldSerialize["commodityCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeItemDescription()
        {
            return this.shouldSerialize["itemDescription"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeProductCode()
        {
            return this.shouldSerialize["productCode"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeUom()
        {
            return this.shouldSerialize["uom"];
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
            return obj is Level2and3LineItem other &&                ((this.ItemSequenceNo == null && other.ItemSequenceNo == null) || (this.ItemSequenceNo?.Equals(other.ItemSequenceNo) == true)) &&
                ((this.CommodityCode == null && other.CommodityCode == null) || (this.CommodityCode?.Equals(other.CommodityCode) == true)) &&
                ((this.ItemDescription == null && other.ItemDescription == null) || (this.ItemDescription?.Equals(other.ItemDescription) == true)) &&
                ((this.ProductCode == null && other.ProductCode == null) || (this.ProductCode?.Equals(other.ProductCode) == true)) &&
                ((this.Quantity == null && other.Quantity == null) || (this.Quantity?.Equals(other.Quantity) == true)) &&
                ((this.Uom == null && other.Uom == null) || (this.Uom?.Equals(other.Uom) == true)) &&
                ((this.UnitCost == null && other.UnitCost == null) || (this.UnitCost?.Equals(other.UnitCost) == true)) &&
                ((this.ItemDiscountAmount == null && other.ItemDiscountAmount == null) || (this.ItemDiscountAmount?.Equals(other.ItemDiscountAmount) == true)) &&
                ((this.LineItemTotal == null && other.LineItemTotal == null) || (this.LineItemTotal?.Equals(other.LineItemTotal) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.ItemSequenceNo = {(this.ItemSequenceNo == null ? "null" : this.ItemSequenceNo)}");
            toStringOutput.Add($"this.CommodityCode = {(this.CommodityCode == null ? "null" : this.CommodityCode)}");
            toStringOutput.Add($"this.ItemDescription = {(this.ItemDescription == null ? "null" : this.ItemDescription)}");
            toStringOutput.Add($"this.ProductCode = {(this.ProductCode == null ? "null" : this.ProductCode)}");
            toStringOutput.Add($"this.Quantity = {(this.Quantity == null ? "null" : this.Quantity.ToString())}");
            toStringOutput.Add($"this.Uom = {(this.Uom == null ? "null" : this.Uom)}");
            toStringOutput.Add($"this.UnitCost = {(this.UnitCost == null ? "null" : this.UnitCost.ToString())}");
            toStringOutput.Add($"this.ItemDiscountAmount = {(this.ItemDiscountAmount == null ? "null" : this.ItemDiscountAmount.ToString())}");
            toStringOutput.Add($"this.LineItemTotal = {(this.LineItemTotal == null ? "null" : this.LineItemTotal.ToString())}");
        }
    }
}