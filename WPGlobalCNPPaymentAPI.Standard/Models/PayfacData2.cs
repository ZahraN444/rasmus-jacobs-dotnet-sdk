// <copyright file="PayfacData2.cs" company="APIMatic">
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
    /// PayfacData2.
    /// </summary>
    public class PayfacData2
    {
        private string isoId;
        private string submerchantTaxId;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "isoId", false },
            { "submerchantTaxId", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="PayfacData2"/> class.
        /// </summary>
        public PayfacData2()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayfacData2"/> class.
        /// </summary>
        /// <param name="payfacId">payfacId.</param>
        /// <param name="submerchantId">submerchantId.</param>
        /// <param name="submerchantName">submerchantName.</param>
        /// <param name="submerchantAddress">submerchantAddress.</param>
        /// <param name="isoId">isoId.</param>
        /// <param name="submerchantTaxId">submerchantTaxId.</param>
        public PayfacData2(
            string payfacId,
            string submerchantId,
            string submerchantName,
            Models.Address submerchantAddress,
            string isoId = null,
            string submerchantTaxId = null)
        {
            this.PayfacId = payfacId;
            if (isoId != null)
            {
                this.IsoId = isoId;
            }

            this.SubmerchantId = submerchantId;
            this.SubmerchantName = submerchantName;
            this.SubmerchantAddress = submerchantAddress;
            if (submerchantTaxId != null)
            {
                this.SubmerchantTaxId = submerchantTaxId;
            }

        }

        /// <summary>
        /// Gets or sets PayfacId.
        /// </summary>
        [JsonProperty("payfacId")]
        public string PayfacId { get; set; }

        /// <summary>
        /// Gets or sets IsoId.
        /// </summary>
        [JsonProperty("isoId")]
        public string IsoId
        {
            get
            {
                return this.isoId;
            }

            set
            {
                this.shouldSerialize["isoId"] = true;
                this.isoId = value;
            }
        }

        /// <summary>
        /// Gets or sets SubmerchantId.
        /// </summary>
        [JsonProperty("submerchantId")]
        public string SubmerchantId { get; set; }

        /// <summary>
        /// Gets or sets SubmerchantName.
        /// </summary>
        [JsonProperty("submerchantName")]
        public string SubmerchantName { get; set; }

        /// <summary>
        /// Gets or sets SubmerchantAddress.
        /// </summary>
        [JsonProperty("submerchantAddress")]
        public Models.Address SubmerchantAddress { get; set; }

        /// <summary>
        /// Gets or sets SubmerchantTaxId.
        /// </summary>
        [JsonProperty("submerchantTaxId")]
        public string SubmerchantTaxId
        {
            get
            {
                return this.submerchantTaxId;
            }

            set
            {
                this.shouldSerialize["submerchantTaxId"] = true;
                this.submerchantTaxId = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"PayfacData2 : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetIsoId()
        {
            this.shouldSerialize["isoId"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetSubmerchantTaxId()
        {
            this.shouldSerialize["submerchantTaxId"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeIsoId()
        {
            return this.shouldSerialize["isoId"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeSubmerchantTaxId()
        {
            return this.shouldSerialize["submerchantTaxId"];
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
            return obj is PayfacData2 other &&                ((this.PayfacId == null && other.PayfacId == null) || (this.PayfacId?.Equals(other.PayfacId) == true)) &&
                ((this.IsoId == null && other.IsoId == null) || (this.IsoId?.Equals(other.IsoId) == true)) &&
                ((this.SubmerchantId == null && other.SubmerchantId == null) || (this.SubmerchantId?.Equals(other.SubmerchantId) == true)) &&
                ((this.SubmerchantName == null && other.SubmerchantName == null) || (this.SubmerchantName?.Equals(other.SubmerchantName) == true)) &&
                ((this.SubmerchantAddress == null && other.SubmerchantAddress == null) || (this.SubmerchantAddress?.Equals(other.SubmerchantAddress) == true)) &&
                ((this.SubmerchantTaxId == null && other.SubmerchantTaxId == null) || (this.SubmerchantTaxId?.Equals(other.SubmerchantTaxId) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.PayfacId = {(this.PayfacId == null ? "null" : this.PayfacId)}");
            toStringOutput.Add($"this.IsoId = {(this.IsoId == null ? "null" : this.IsoId)}");
            toStringOutput.Add($"this.SubmerchantId = {(this.SubmerchantId == null ? "null" : this.SubmerchantId)}");
            toStringOutput.Add($"this.SubmerchantName = {(this.SubmerchantName == null ? "null" : this.SubmerchantName)}");
            toStringOutput.Add($"this.SubmerchantAddress = {(this.SubmerchantAddress == null ? "null" : this.SubmerchantAddress.ToString())}");
            toStringOutput.Add($"this.SubmerchantTaxId = {(this.SubmerchantTaxId == null ? "null" : this.SubmerchantTaxId)}");
        }
    }
}