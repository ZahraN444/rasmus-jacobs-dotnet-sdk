// <copyright file="CapturePaymentResponse.cs" company="APIMatic">
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
    /// CapturePaymentResponse.
    /// </summary>
    public class CapturePaymentResponse
    {
        private string message;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "message", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="CapturePaymentResponse"/> class.
        /// </summary>
        public CapturePaymentResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CapturePaymentResponse"/> class.
        /// </summary>
        /// <param name="message">message.</param>
        public CapturePaymentResponse(
            string message = null)
        {
            if (message != null)
            {
                this.Message = message;
            }

        }

        /// <summary>
        /// Gets or sets Message.
        /// </summary>
        [JsonProperty("message")]
        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.shouldSerialize["message"] = true;
                this.message = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"CapturePaymentResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetMessage()
        {
            this.shouldSerialize["message"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeMessage()
        {
            return this.shouldSerialize["message"];
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
            return obj is CapturePaymentResponse other &&                ((this.Message == null && other.Message == null) || (this.Message?.Equals(other.Message) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Message = {(this.Message == null ? "null" : this.Message)}");
        }
    }
}