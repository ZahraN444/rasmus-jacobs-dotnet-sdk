// <copyright file="MTokensController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using System.Net.Http;
using WPGlobalCNPPaymentAPI.Standard;
using WPGlobalCNPPaymentAPI.Standard.Exceptions;
using WPGlobalCNPPaymentAPI.Standard.Http.Client;
using WPGlobalCNPPaymentAPI.Standard.Http.Response;
using WPGlobalCNPPaymentAPI.Standard.Utilities;

namespace WPGlobalCNPPaymentAPI.Standard.Controllers
{
    /// <summary>
    /// MTokensController.
    /// </summary>
    public class MTokensController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MTokensController"/> class.
        /// </summary>
        internal MTokensController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// You want to create a token for the supplied information.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Tokenize Request.</param>
        /// <returns>Returns the ApiResponse of Models.TokenizeResponse response from the API call.</returns>
        public ApiResponse<Models.TokenizeResponse> CreateToken(
                string idempotencyKey = null,
                Models.TokenizeRequest body = null)
            => CoreHelper.RunTask(CreateTokenAsync(idempotencyKey, body));

        /// <summary>
        /// You want to create a token for the supplied information.
        /// </summary>
        /// <param name="idempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Tokenize Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TokenizeResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TokenizeResponse>> CreateTokenAsync(
                string idempotencyKey = null,
                Models.TokenizeRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TokenizeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/tokens/createToken")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("idempotencyKey", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Client Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}