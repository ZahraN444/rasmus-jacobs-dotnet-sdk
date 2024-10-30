// <copyright file="APMFISLoyalty.cs" company="APIMatic">
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
    /// APMFISLoyalty.
    /// </summary>
    public class APMFISLoyalty : BasePaymentMethod
    {
        private string fisDiscountedAmount;
        private string fisLoyaltyTransactionID;
        private string fisLoyaltyRewardID;
        private string fisLoyaltyPromoID;
        private string fisLoyaltySequenceNumber;
        private string fisLoyaltyReservationID;
        private string fisLoyaltyPSPID;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "fisDiscountedAmount", false },
            { "fisLoyaltyTransactionID", false },
            { "fisLoyaltyRewardID", false },
            { "fisLoyaltyPromoID", false },
            { "fisLoyaltySequenceNumber", false },
            { "fisLoyaltyReservationID", false },
            { "fisLoyaltyPSPID", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="APMFISLoyalty"/> class.
        /// </summary>
        public APMFISLoyalty()
        {
            this.Type = "apm/fisloyalty";
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="APMFISLoyalty"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="fisDiscountedAmount">fisDiscountedAmount.</param>
        /// <param name="fisLoyaltyEligibility">FisLoyaltyEligibility.</param>
        /// <param name="fisLoyaltyOptIn">fisLoyaltyOptIn.</param>
        /// <param name="fisLoyaltyTransactionID">fisLoyaltyTransactionID.</param>
        /// <param name="fisLoyaltyRewardID">fisLoyaltyRewardID.</param>
        /// <param name="fisLoyaltyPromoID">fisLoyaltyPromoID.</param>
        /// <param name="fisLoyaltySequenceNumber">fisLoyaltySequenceNumber.</param>
        /// <param name="fisLoyaltyReservationID">fisLoyaltyReservationID.</param>
        /// <param name="fisLoyaltyPSPID">fisLoyaltyPSPID.</param>
        public APMFISLoyalty(
            string type = "apm/fisloyalty",
            string fisDiscountedAmount = null,
            bool? fisLoyaltyEligibility = null,
            bool? fisLoyaltyOptIn = null,
            string fisLoyaltyTransactionID = null,
            string fisLoyaltyRewardID = null,
            string fisLoyaltyPromoID = null,
            string fisLoyaltySequenceNumber = null,
            string fisLoyaltyReservationID = null,
            string fisLoyaltyPSPID = null)
            : base(
                type)
        {
            if (fisDiscountedAmount != null)
            {
                this.FisDiscountedAmount = fisDiscountedAmount;
            }

            this.FisLoyaltyEligibility = fisLoyaltyEligibility;
            this.FisLoyaltyOptIn = fisLoyaltyOptIn;
            if (fisLoyaltyTransactionID != null)
            {
                this.FisLoyaltyTransactionID = fisLoyaltyTransactionID;
            }

            if (fisLoyaltyRewardID != null)
            {
                this.FisLoyaltyRewardID = fisLoyaltyRewardID;
            }

            if (fisLoyaltyPromoID != null)
            {
                this.FisLoyaltyPromoID = fisLoyaltyPromoID;
            }

            if (fisLoyaltySequenceNumber != null)
            {
                this.FisLoyaltySequenceNumber = fisLoyaltySequenceNumber;
            }

            if (fisLoyaltyReservationID != null)
            {
                this.FisLoyaltyReservationID = fisLoyaltyReservationID;
            }

            if (fisLoyaltyPSPID != null)
            {
                this.FisLoyaltyPSPID = fisLoyaltyPSPID;
            }

        }

        /// <summary>
        /// The actual discounted amounted returned to the terminal so the customer can determine whether to opt in/out.
        /// </summary>
        [JsonProperty("fisDiscountedAmount")]
        public string FisDiscountedAmount
        {
            get
            {
                return this.fisDiscountedAmount;
            }

            set
            {
                this.shouldSerialize["fisDiscountedAmount"] = true;
                this.fisDiscountedAmount = value;
            }
        }

        /// <summary>
        /// True/False flag indicating the merchant's ability to accept Loyalty transactions.
        /// </summary>
        [JsonProperty("FisLoyaltyEligibility", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FisLoyaltyEligibility { get; set; }

        /// <summary>
        /// True/False flag on the follow-up message to indicate whether or not the customer accepts the discounted amount.
        /// </summary>
        [JsonProperty("fisLoyaltyOptIn", NullValueHandling = NullValueHandling.Ignore)]
        public bool? FisLoyaltyOptIn { get; set; }

        /// <summary>
        /// The FIS transaction ID that ties requests together. It should be sent on any follow-up messages.
        /// </summary>
        [JsonProperty("fisLoyaltyTransactionID")]
        public string FisLoyaltyTransactionID
        {
            get
            {
                return this.fisLoyaltyTransactionID;
            }

            set
            {
                this.shouldSerialize["fisLoyaltyTransactionID"] = true;
                this.fisLoyaltyTransactionID = value;
            }
        }

        /// <summary>
        /// This field contains the reward ID associated with the transaction.
        /// </summary>
        [JsonProperty("fisLoyaltyRewardID")]
        public string FisLoyaltyRewardID
        {
            get
            {
                return this.fisLoyaltyRewardID;
            }

            set
            {
                this.shouldSerialize["fisLoyaltyRewardID"] = true;
                this.fisLoyaltyRewardID = value;
            }
        }

        /// <summary>
        /// This field contains the loyalty program associated with the transaction
        /// </summary>
        [JsonProperty("fisLoyaltyPromoID")]
        public string FisLoyaltyPromoID
        {
            get
            {
                return this.fisLoyaltyPromoID;
            }

            set
            {
                this.shouldSerialize["fisLoyaltyPromoID"] = true;
                this.fisLoyaltyPromoID = value;
            }
        }

        /// <summary>
        /// This field contains the loyalty sequence number that must be submitted on subsequent loyalty transactions
        /// </summary>
        [JsonProperty("fisLoyaltySequenceNumber")]
        public string FisLoyaltySequenceNumber
        {
            get
            {
                return this.fisLoyaltySequenceNumber;
            }

            set
            {
                this.shouldSerialize["fisLoyaltySequenceNumber"] = true;
                this.fisLoyaltySequenceNumber = value;
            }
        }

        /// <summary>
        /// This contains the reservation ID used with the loyalty system to reserve/finalize e-comm Premium Payback tranasactions.
        /// </summary>
        [JsonProperty("fisLoyaltyReservationID")]
        public string FisLoyaltyReservationID
        {
            get
            {
                return this.fisLoyaltyReservationID;
            }

            set
            {
                this.shouldSerialize["fisLoyaltyReservationID"] = true;
                this.fisLoyaltyReservationID = value;
            }
        }

        /// <summary>
        /// This contains the PSP identifier associated with the processor who holds the loyalty reservation. It will be ignored without a Loyalty Reservation ID.
        /// </summary>
        [JsonProperty("fisLoyaltyPSPID")]
        public string FisLoyaltyPSPID
        {
            get
            {
                return this.fisLoyaltyPSPID;
            }

            set
            {
                this.shouldSerialize["fisLoyaltyPSPID"] = true;
                this.fisLoyaltyPSPID = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"APMFISLoyalty : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFisDiscountedAmount()
        {
            this.shouldSerialize["fisDiscountedAmount"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFisLoyaltyTransactionID()
        {
            this.shouldSerialize["fisLoyaltyTransactionID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFisLoyaltyRewardID()
        {
            this.shouldSerialize["fisLoyaltyRewardID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFisLoyaltyPromoID()
        {
            this.shouldSerialize["fisLoyaltyPromoID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFisLoyaltySequenceNumber()
        {
            this.shouldSerialize["fisLoyaltySequenceNumber"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFisLoyaltyReservationID()
        {
            this.shouldSerialize["fisLoyaltyReservationID"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetFisLoyaltyPSPID()
        {
            this.shouldSerialize["fisLoyaltyPSPID"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFisDiscountedAmount()
        {
            return this.shouldSerialize["fisDiscountedAmount"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFisLoyaltyTransactionID()
        {
            return this.shouldSerialize["fisLoyaltyTransactionID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFisLoyaltyRewardID()
        {
            return this.shouldSerialize["fisLoyaltyRewardID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFisLoyaltyPromoID()
        {
            return this.shouldSerialize["fisLoyaltyPromoID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFisLoyaltySequenceNumber()
        {
            return this.shouldSerialize["fisLoyaltySequenceNumber"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFisLoyaltyReservationID()
        {
            return this.shouldSerialize["fisLoyaltyReservationID"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeFisLoyaltyPSPID()
        {
            return this.shouldSerialize["fisLoyaltyPSPID"];
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
            return obj is APMFISLoyalty other &&                ((this.FisDiscountedAmount == null && other.FisDiscountedAmount == null) || (this.FisDiscountedAmount?.Equals(other.FisDiscountedAmount) == true)) &&
                ((this.FisLoyaltyEligibility == null && other.FisLoyaltyEligibility == null) || (this.FisLoyaltyEligibility?.Equals(other.FisLoyaltyEligibility) == true)) &&
                ((this.FisLoyaltyOptIn == null && other.FisLoyaltyOptIn == null) || (this.FisLoyaltyOptIn?.Equals(other.FisLoyaltyOptIn) == true)) &&
                ((this.FisLoyaltyTransactionID == null && other.FisLoyaltyTransactionID == null) || (this.FisLoyaltyTransactionID?.Equals(other.FisLoyaltyTransactionID) == true)) &&
                ((this.FisLoyaltyRewardID == null && other.FisLoyaltyRewardID == null) || (this.FisLoyaltyRewardID?.Equals(other.FisLoyaltyRewardID) == true)) &&
                ((this.FisLoyaltyPromoID == null && other.FisLoyaltyPromoID == null) || (this.FisLoyaltyPromoID?.Equals(other.FisLoyaltyPromoID) == true)) &&
                ((this.FisLoyaltySequenceNumber == null && other.FisLoyaltySequenceNumber == null) || (this.FisLoyaltySequenceNumber?.Equals(other.FisLoyaltySequenceNumber) == true)) &&
                ((this.FisLoyaltyReservationID == null && other.FisLoyaltyReservationID == null) || (this.FisLoyaltyReservationID?.Equals(other.FisLoyaltyReservationID) == true)) &&
                ((this.FisLoyaltyPSPID == null && other.FisLoyaltyPSPID == null) || (this.FisLoyaltyPSPID?.Equals(other.FisLoyaltyPSPID) == true)) &&
                base.Equals(obj);
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected new void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.FisDiscountedAmount = {(this.FisDiscountedAmount == null ? "null" : this.FisDiscountedAmount)}");
            toStringOutput.Add($"this.FisLoyaltyEligibility = {(this.FisLoyaltyEligibility == null ? "null" : this.FisLoyaltyEligibility.ToString())}");
            toStringOutput.Add($"this.FisLoyaltyOptIn = {(this.FisLoyaltyOptIn == null ? "null" : this.FisLoyaltyOptIn.ToString())}");
            toStringOutput.Add($"this.FisLoyaltyTransactionID = {(this.FisLoyaltyTransactionID == null ? "null" : this.FisLoyaltyTransactionID)}");
            toStringOutput.Add($"this.FisLoyaltyRewardID = {(this.FisLoyaltyRewardID == null ? "null" : this.FisLoyaltyRewardID)}");
            toStringOutput.Add($"this.FisLoyaltyPromoID = {(this.FisLoyaltyPromoID == null ? "null" : this.FisLoyaltyPromoID)}");
            toStringOutput.Add($"this.FisLoyaltySequenceNumber = {(this.FisLoyaltySequenceNumber == null ? "null" : this.FisLoyaltySequenceNumber)}");
            toStringOutput.Add($"this.FisLoyaltyReservationID = {(this.FisLoyaltyReservationID == null ? "null" : this.FisLoyaltyReservationID)}");
            toStringOutput.Add($"this.FisLoyaltyPSPID = {(this.FisLoyaltyPSPID == null ? "null" : this.FisLoyaltyPSPID)}");

            base.ToString(toStringOutput);
        }
    }
}