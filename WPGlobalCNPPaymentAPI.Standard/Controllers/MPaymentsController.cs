// <copyright file="MPaymentsController.cs" company="APIMatic">
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
    /// MPaymentsController.
    /// </summary>
    public class MPaymentsController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MPaymentsController"/> class.
        /// </summary>
        internal MPaymentsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// You want to process an Authorization and Capture in one (1) step.
        /// </summary>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Sale Request.</param>
        /// <returns>Returns the ApiResponse of Models.TokenizeResponse response from the API call.</returns>
        public ApiResponse<Models.TokenizeResponse> SalePayment(
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                Models.SalePaymentRequest body = null)
            => CoreHelper.RunTask(SalePaymentAsync(wpIdempotencyKey, wpCorrelationId, body));

        /// <summary>
        /// You want to process an Authorization and Capture in one (1) step.
        /// </summary>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Sale Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.TokenizeResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.TokenizeResponse>> SalePaymentAsync(
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                Models.SalePaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.TokenizeResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/payments/sale")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("wp-idempotencyKey", wpIdempotencyKey))
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("400", CreateErrorCase("Bad Request", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Client Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Note: The response contains the WPTransactionId you will use for follow-on actions.
        /// </summary>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Authorization Request.</param>
        /// <returns>Returns the ApiResponse of Models.AuthorizePaymentResponse response from the API call.</returns>
        public ApiResponse<Models.AuthorizePaymentResponse> AuthorizePayment(
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                Models.AuthorizePaymentRequest body = null)
            => CoreHelper.RunTask(AuthorizePaymentAsync(wpIdempotencyKey, wpCorrelationId, body));

        /// <summary>
        /// Note: The response contains the WPTransactionId you will use for follow-on actions.
        /// </summary>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Authorization Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.AuthorizePaymentResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.AuthorizePaymentResponse>> AuthorizePaymentAsync(
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                Models.AuthorizePaymentRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.AuthorizePaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/payments/authorize")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("wp-idempotencyKey", wpIdempotencyKey))
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Client Error", (_reason, _context) => new ApiV1PaymentsAuthorize422ErrorException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You want to complete the authorization and initiate funds movement using the reference from your original request.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to capture..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Capture Request.</param>
        /// <returns>Returns the ApiResponse of Models.CancelPaymentResponse response from the API call.</returns>
        public ApiResponse<Models.CancelPaymentResponse> CapturePayment(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null)
            => CoreHelper.RunTask(CapturePaymentAsync(wpTransactionId, wpIdempotencyKey, wpCorrelationId, body));

        /// <summary>
        /// You want to complete the authorization and initiate funds movement using the reference from your original request.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to capture..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Capture Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CancelPaymentResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.CancelPaymentResponse>> CapturePaymentAsync(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelPaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/payments/{wpTransactionId}/capture")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("wpTransactionId", wpTransactionId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("wp-idempotencyKey", wpIdempotencyKey))
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Client Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You want to cancel a payment that has been authorised but not captured yet using the reference from your original request.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to cancel..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Cancel Request.</param>
        /// <returns>Returns the ApiResponse of Models.CancelPaymentResponse response from the API call.</returns>
        public ApiResponse<Models.CancelPaymentResponse> CancelPayment(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null)
            => CoreHelper.RunTask(CancelPaymentAsync(wpTransactionId, wpIdempotencyKey, wpCorrelationId, body));

        /// <summary>
        /// You want to cancel a payment that has been authorised but not captured yet using the reference from your original request.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to cancel..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Cancel Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CancelPaymentResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.CancelPaymentResponse>> CancelPaymentAsync(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelPaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/payments/{wpTransactionId}/cancel")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("wpTransactionId", wpTransactionId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("wp-idempotencyKey", wpIdempotencyKey))
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Client Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to refund..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Refund Request.</param>
        /// <returns>Returns the ApiResponse of Models.CancelPaymentResponse response from the API call.</returns>
        public ApiResponse<Models.CancelPaymentResponse> RefundPayment(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null)
            => CoreHelper.RunTask(RefundPaymentAsync(wpTransactionId, wpIdempotencyKey, wpCorrelationId, body));

        /// <summary>
        /// You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to refund..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Refund Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.CancelPaymentResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.CancelPaymentResponse>> RefundPaymentAsync(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.CancelPaymentResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/payments/{wpTransactionId}/refund")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("wpTransactionId", wpTransactionId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("wp-idempotencyKey", wpIdempotencyKey))
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Client Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// This will either: <br /><pre><span>•</span>Cancel the payment – in case it has not yet been captured. </pre><pre><span>•</span>Refund the payment – in case it has already been captured. </pre>.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to reverse..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Reversal Request.</param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public ApiResponse<object> ReversePayment(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null)
            => CoreHelper.RunTask(ReversePaymentAsync(wpTransactionId, wpIdempotencyKey, wpCorrelationId, body));

        /// <summary>
        /// This will either: <br /><pre><span>•</span>Cancel the payment – in case it has not yet been captured. </pre><pre><span>•</span>Refund the payment – in case it has already been captured. </pre>.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to reverse..</param>
        /// <param name="wpIdempotencyKey">Optional parameter: A unique identifier for the message with a maximum of 64 characters (we recommend a UUID)..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The information for the Payment Reversal Request.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public async Task<ApiResponse<object>> ReversePaymentAsync(
                string wpTransactionId,
                string wpIdempotencyKey = null,
                string wpCorrelationId = null,
                object body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<object>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/payments/{wpTransactionId}/reverse")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Template(_template => _template.Setup("wpTransactionId", wpTransactionId).Required())
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("wp-idempotencyKey", wpIdempotencyKey))
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("422", CreateErrorCase("Client Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .Deserializer(_response => _response))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// You want to return information about the current state of the payment.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to query..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public ApiResponse<object> QueryPaymentState(
                string wpTransactionId,
                string wpCorrelationId = null)
            => CoreHelper.RunTask(QueryPaymentStateAsync(wpTransactionId, wpCorrelationId));

        /// <summary>
        /// You want to return information about the current state of the payment.
        /// </summary>
        /// <param name="wpTransactionId">Required parameter: A unique identifier returned from the original transaction for the payment that you want to query..</param>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of object response from the API call.</returns>
        public async Task<ApiResponse<object>> QueryPaymentStateAsync(
                string wpTransactionId,
                string wpCorrelationId = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<object>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/api/v1/payments/{wpTransactionId}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("wpTransactionId", wpTransactionId).Required())
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("404", CreateErrorCase("Not Found", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .Deserializer(_response => _response))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Returns a list of available payment methods for the merchant.
        /// </summary>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The query payment methods request..</param>
        /// <returns>Returns the ApiResponse of Models.QueryAvailablePaymentMethodsResponse response from the API call.</returns>
        public ApiResponse<Models.QueryAvailablePaymentMethodsResponse> QueryAvailablePaymentMethods(
                string wpCorrelationId = null,
                Models.QueryAvailablePaymentMethodsRequest body = null)
            => CoreHelper.RunTask(QueryAvailablePaymentMethodsAsync(wpCorrelationId, body));

        /// <summary>
        /// Returns a list of available payment methods for the merchant.
        /// </summary>
        /// <param name="wpCorrelationId">Optional parameter: A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID)..</param>
        /// <param name="body">Optional parameter: The query payment methods request..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the ApiResponse of Models.QueryAvailablePaymentMethodsResponse response from the API call.</returns>
        public async Task<ApiResponse<Models.QueryAvailablePaymentMethodsResponse>> QueryAvailablePaymentMethodsAsync(
                string wpCorrelationId = null,
                Models.QueryAvailablePaymentMethodsRequest body = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.QueryAvailablePaymentMethodsResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/api/v1/payments/availablePaymentMethods")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(body))
                      .Header(_header => _header.Setup("Content-Type", "application/json"))
                      .Header(_header => _header.Setup("wp-correlationId", wpCorrelationId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized", (_reason, _context) => new ProblemDetailsException(_reason, _context)))
                  .ErrorCase("500", CreateErrorCase("Server Error", (_reason, _context) => new ProblemDetailsException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}