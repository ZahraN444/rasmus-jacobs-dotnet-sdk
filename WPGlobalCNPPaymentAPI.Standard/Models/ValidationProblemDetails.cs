// <copyright file="ValidationProblemDetails.cs" company="APIMatic">
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
    /// ValidationProblemDetails.
    /// </summary>
    public class ValidationProblemDetails
    {
        private string type;
        private string title;
        private int? status;
        private string detail;
        private string instance;
        private object errors;
        private Dictionary<string, bool> shouldSerialize = new Dictionary<string, bool>
        {
            { "type", false },
            { "title", false },
            { "status", false },
            { "detail", false },
            { "instance", false },
            { "errors", false },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationProblemDetails"/> class.
        /// </summary>
        public ValidationProblemDetails()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationProblemDetails"/> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="title">title.</param>
        /// <param name="status">status.</param>
        /// <param name="detail">detail.</param>
        /// <param name="instance">instance.</param>
        /// <param name="errors">errors.</param>
        public ValidationProblemDetails(
            string type = null,
            string title = null,
            int? status = null,
            string detail = null,
            string instance = null,
            object errors = null)
        {
            if (type != null)
            {
                this.Type = type;
            }

            if (title != null)
            {
                this.Title = title;
            }

            if (status != null)
            {
                this.Status = status;
            }

            if (detail != null)
            {
                this.Detail = detail;
            }

            if (instance != null)
            {
                this.Instance = instance;
            }

            if (errors != null)
            {
                this.Errors = errors;
            }

        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.shouldSerialize["type"] = true;
                this.type = value;
            }
        }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title
        {
            get
            {
                return this.title;
            }

            set
            {
                this.shouldSerialize["title"] = true;
                this.title = value;
            }
        }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public int? Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.shouldSerialize["status"] = true;
                this.status = value;
            }
        }

        /// <summary>
        /// Gets or sets Detail.
        /// </summary>
        [JsonProperty("detail")]
        public string Detail
        {
            get
            {
                return this.detail;
            }

            set
            {
                this.shouldSerialize["detail"] = true;
                this.detail = value;
            }
        }

        /// <summary>
        /// Gets or sets Instance.
        /// </summary>
        [JsonProperty("instance")]
        public string Instance
        {
            get
            {
                return this.instance;
            }

            set
            {
                this.shouldSerialize["instance"] = true;
                this.instance = value;
            }
        }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors")]
        public object Errors
        {
            get
            {
                return this.errors;
            }

            set
            {
                this.shouldSerialize["errors"] = true;
                this.errors = value;
            }
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();

            this.ToString(toStringOutput);

            return $"ValidationProblemDetails : ({string.Join(", ", toStringOutput)})";
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetType()
        {
            this.shouldSerialize["type"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetTitle()
        {
            this.shouldSerialize["title"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetStatus()
        {
            this.shouldSerialize["status"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetDetail()
        {
            this.shouldSerialize["detail"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetInstance()
        {
            this.shouldSerialize["instance"] = false;
        }

        /// <summary>
        /// Marks the field to not be serailized.
        /// </summary>
        public void UnsetErrors()
        {
            this.shouldSerialize["errors"] = false;
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeType()
        {
            return this.shouldSerialize["type"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeTitle()
        {
            return this.shouldSerialize["title"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeStatus()
        {
            return this.shouldSerialize["status"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeDetail()
        {
            return this.shouldSerialize["detail"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeInstance()
        {
            return this.shouldSerialize["instance"];
        }

        /// <summary>
        /// Checks if the field should be serialized or not.
        /// </summary>
        /// <returns>A boolean weather the field should be serialized or not.</returns>
        public bool ShouldSerializeErrors()
        {
            return this.shouldSerialize["errors"];
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
            return obj is ValidationProblemDetails other &&                ((this.Type == null && other.Type == null) || (this.Type?.Equals(other.Type) == true)) &&
                ((this.Title == null && other.Title == null) || (this.Title?.Equals(other.Title) == true)) &&
                ((this.Status == null && other.Status == null) || (this.Status?.Equals(other.Status) == true)) &&
                ((this.Detail == null && other.Detail == null) || (this.Detail?.Equals(other.Detail) == true)) &&
                ((this.Instance == null && other.Instance == null) || (this.Instance?.Equals(other.Instance) == true)) &&
                ((this.Errors == null && other.Errors == null) || (this.Errors?.Equals(other.Errors) == true));
        }
        
        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"this.Type = {(this.Type == null ? "null" : this.Type)}");
            toStringOutput.Add($"this.Title = {(this.Title == null ? "null" : this.Title)}");
            toStringOutput.Add($"this.Status = {(this.Status == null ? "null" : this.Status.ToString())}");
            toStringOutput.Add($"this.Detail = {(this.Detail == null ? "null" : this.Detail)}");
            toStringOutput.Add($"this.Instance = {(this.Instance == null ? "null" : this.Instance)}");
            toStringOutput.Add($"Errors = {(this.Errors == null ? "null" : this.Errors.ToString())}");
        }
    }
}