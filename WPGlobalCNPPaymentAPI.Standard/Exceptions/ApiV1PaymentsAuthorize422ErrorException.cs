// <copyright file="ApiV1PaymentsAuthorize422ErrorException.cs" company="APIMatic">
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
using WPGlobalCNPPaymentAPI.Standard.Http.Client;
using WPGlobalCNPPaymentAPI.Standard.Models;
using WPGlobalCNPPaymentAPI.Standard.Utilities;

namespace WPGlobalCNPPaymentAPI.Standard.Exceptions
{
    /// <summary>
    /// ApiV1PaymentsAuthorize422ErrorException.
    /// </summary>
    public class ApiV1PaymentsAuthorize422ErrorException : ApiException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiV1PaymentsAuthorize422ErrorException"/> class.
        /// </summary>
        /// <param name="reason"> The reason for throwing exception.</param>
        /// <param name="context"> The HTTP context that encapsulates request and response objects.</param>
        public ApiV1PaymentsAuthorize422ErrorException(string reason, HttpContext context)
            : base(reason, context)
        {
        }

        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets Title.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        [JsonProperty("status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets Detail.
        /// </summary>
        [JsonProperty("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// Gets or sets Instance.
        /// </summary>
        [JsonProperty("instance")]
        public string Instance { get; set; }

        /// <summary>
        /// Gets or sets Errors.
        /// </summary>
        [JsonProperty("errors")]
        public object Errors { get; set; }
    }
}