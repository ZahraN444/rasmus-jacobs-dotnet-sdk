# Payments

```csharp
MPaymentsController mPaymentsController = client.MPaymentsController;
```

## Class Name

`MPaymentsController`

## Methods

* [Sale Payment](../../doc/controllers/payments.md#sale-payment)
* [Authorize Payment](../../doc/controllers/payments.md#authorize-payment)
* [Capture Payment](../../doc/controllers/payments.md#capture-payment)
* [Cancel Payment](../../doc/controllers/payments.md#cancel-payment)
* [Refund Payment](../../doc/controllers/payments.md#refund-payment)
* [Reverse Payment](../../doc/controllers/payments.md#reverse-payment)
* [Query Payment State](../../doc/controllers/payments.md#query-payment-state)
* [Query Available Payment Methods](../../doc/controllers/payments.md#query-available-payment-methods)


# Sale Payment

You want to process an Authorization and Capture in one (1) step.

```csharp
SalePaymentAsync(
    string wpIdempotencyKey = null,
    string wpCorrelationId = null,
    Models.SalePaymentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpIdempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |
| `body` | [`SalePaymentRequest`](../../doc/models/sale-payment-request.md) | Body, Optional | The information for the Payment Sale Request |

## Response Type

[`Task<ApiResponse<Models.TokenizeResponse>>`](../../doc/models/tokenize-response.md)

## Example Usage

```csharp
SalePaymentRequest body = new SalePaymentRequest
{
    MerchantCode = "US_MERCHANT_CODE",
    CallersReferenceId = "Sample 1",
    Amount = new Amount
    {
        MValue = 1000,
        CurrencyCode = CurrencyCodeEnum.USD,
    },
    PaymentMethod = ApiHelper.JsonDeserialize<object>("{\"type\":\"card/scheme\",\"cardNumber\":\"4111111111111111\",\"cardVerificationCode\":\"123\",\"expiryMonth\":1,\"expiryYear\":2025}"),
    CustomerData = new CustomerData
    {
        BillingAddress = new Address
        {
            PostalCode = "12345",
        },
    },
    CustomerInteractionType = CustomerInteractionTypeEnum.ECOMMERCE,
};

try
{
    ApiResponse<TokenizeResponse> result = await mPaymentsController.SalePaymentAsync(
        null,
        null,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 400 | Bad Request | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 422 | Client Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |


# Authorize Payment

Note: The response contains the WPTransactionId you will use for follow-on actions

```csharp
AuthorizePaymentAsync(
    string wpIdempotencyKey = null,
    string wpCorrelationId = null,
    Models.AuthorizePaymentRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpIdempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |
| `body` | [`AuthorizePaymentRequest`](../../doc/models/authorize-payment-request.md) | Body, Optional | The information for the Payment Authorization Request |

## Response Type

[`Task<ApiResponse<Models.AuthorizePaymentResponse>>`](../../doc/models/authorize-payment-response.md)

## Example Usage

```csharp
AuthorizePaymentRequest body = new AuthorizePaymentRequest
{
    MerchantCode = "US_MERCHANT_CODE",
    Amount = new Amount
    {
        MValue = 1000,
        CurrencyCode = CurrencyCodeEnum.USD,
    },
    PaymentMethod = ApiHelper.JsonDeserialize<object>("{\"type\":\"card/scheme\",\"cardHolderName\":\"A Cardholder\",\"cardNumber\":\"4111111111111111\",\"cardVerificationCode\":\"123\",\"expiryMonth\":1,\"expiryYear\":2025}"),
    CallersReferenceId = "Sample 1",
    CustomerData = new CustomerData
    {
        BillingAddress = new Address
        {
            PostalCode = "12345",
            Country = "USA",
        },
    },
    CustomerInteractionType = CustomerInteractionTypeEnum.ECOMMERCE,
};

try
{
    ApiResponse<AuthorizePaymentResponse> result = await mPaymentsController.AuthorizePaymentAsync(
        null,
        null,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "resultCode": "Undefined",
  "refusalReason": "Undefined"
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 422 | Client Error | [`ApiV1PaymentsAuthorize422ErrorException`](../../doc/models/api-v1-payments-authorize-422-error-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |


# Capture Payment

You want to complete the authorization and initiate funds movement using the reference from your original request.

```csharp
CapturePaymentAsync(
    string wpTransactionId,
    string wpIdempotencyKey = null,
    string wpCorrelationId = null,
    object body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpTransactionId` | `string` | Template, Required | A unique identifier returned from the original transaction for the payment that you want to capture. |
| `wpIdempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |
| `body` | `object` | Body, Optional | The information for the Payment Capture Request |

## Response Type

[`Task<ApiResponse<Models.CancelPaymentResponse>>`](../../doc/models/cancel-payment-response.md)

## Example Usage

```csharp
string wpTransactionId = "wpTransactionId0";
object body = ApiHelper.JsonDeserialize<object>("{}");
try
{
    ApiResponse<CancelPaymentResponse> result = await mPaymentsController.CapturePaymentAsync(
        wpTransactionId,
        null,
        null,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 404 | Not Found | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 422 | Client Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |


# Cancel Payment

You want to cancel a payment that has been authorised but not captured yet using the reference from your original request.

```csharp
CancelPaymentAsync(
    string wpTransactionId,
    string wpIdempotencyKey = null,
    string wpCorrelationId = null,
    object body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpTransactionId` | `string` | Template, Required | A unique identifier returned from the original transaction for the payment that you want to cancel. |
| `wpIdempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |
| `body` | `object` | Body, Optional | The information for the Payment Cancel Request |

## Response Type

[`Task<ApiResponse<Models.CancelPaymentResponse>>`](../../doc/models/cancel-payment-response.md)

## Example Usage

```csharp
string wpTransactionId = "wpTransactionId0";
object body = ApiHelper.JsonDeserialize<object>("{}");
try
{
    ApiResponse<CancelPaymentResponse> result = await mPaymentsController.CancelPaymentAsync(
        wpTransactionId,
        null,
        null,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 404 | Not Found | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 422 | Client Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |


# Refund Payment

You can refund either the full captured amount or a part of the captured amount. You can also perform multiple partial refunds, as long as their sum doesn't exceed the captured amount.

```csharp
RefundPaymentAsync(
    string wpTransactionId,
    string wpIdempotencyKey = null,
    string wpCorrelationId = null,
    object body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpTransactionId` | `string` | Template, Required | A unique identifier returned from the original transaction for the payment that you want to refund. |
| `wpIdempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |
| `body` | `object` | Body, Optional | The information for the Payment Refund Request |

## Response Type

[`Task<ApiResponse<Models.CancelPaymentResponse>>`](../../doc/models/cancel-payment-response.md)

## Example Usage

```csharp
string wpTransactionId = "wpTransactionId0";
object body = ApiHelper.JsonDeserialize<object>("{}");
try
{
    ApiResponse<CancelPaymentResponse> result = await mPaymentsController.RefundPaymentAsync(
        wpTransactionId,
        null,
        null,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 404 | Not Found | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 422 | Client Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |


# Reverse Payment

This will either: <br /><pre><span>•</span>Cancel the payment – in case it has not yet been captured. </pre><pre><span>•</span>Refund the payment – in case it has already been captured. </pre>

```csharp
ReversePaymentAsync(
    string wpTransactionId,
    string wpIdempotencyKey = null,
    string wpCorrelationId = null,
    object body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpTransactionId` | `string` | Template, Required | A unique identifier returned from the original transaction for the payment that you want to reverse. |
| `wpIdempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |
| `body` | `object` | Body, Optional | The information for the Payment Reversal Request |

## Response Type

`Task<ApiResponse<object>>`

## Example Usage

```csharp
string wpTransactionId = "wpTransactionId0";
object body = ApiHelper.JsonDeserialize<object>("{}");
try
{
    ApiResponse<object> result = await mPaymentsController.ReversePaymentAsync(
        wpTransactionId,
        null,
        null,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response

```
{}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 404 | Not Found | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 422 | Client Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |


# Query Payment State

You want to return information about the current state of the payment

```csharp
QueryPaymentStateAsync(
    string wpTransactionId,
    string wpCorrelationId = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpTransactionId` | `string` | Template, Required | A unique identifier returned from the original transaction for the payment that you want to query. |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |

## Response Type

`Task<ApiResponse<object>>`

## Example Usage

```csharp
string wpTransactionId = "wpTransactionId0";
string wpCorrelationId = "00000000-0000-0000-0000-000000000000";
try
{
    ApiResponse<object> result = await mPaymentsController.QueryPaymentStateAsync(
        wpTransactionId,
        wpCorrelationId
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response

```
{}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 404 | Not Found | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |


# Query Available Payment Methods

Returns a list of available payment methods for the merchant

```csharp
QueryAvailablePaymentMethodsAsync(
    string wpCorrelationId = null,
    Models.QueryAvailablePaymentMethodsRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `wpCorrelationId` | `string` | Header, Optional | A identifier used to trace a request thru multiple internal platforms.  This would not be exposed to external callers (we recommend a UUID). |
| `body` | [`QueryAvailablePaymentMethodsRequest`](../../doc/models/query-available-payment-methods-request.md) | Body, Optional | The query payment methods request. |

## Response Type

[`Task<ApiResponse<Models.QueryAvailablePaymentMethodsResponse>>`](../../doc/models/query-available-payment-methods-response.md)

## Example Usage

```csharp
QueryAvailablePaymentMethodsRequest body = new QueryAvailablePaymentMethodsRequest
{
    MerchantCode = "US_MERCHANT_CODE",
};

try
{
    ApiResponse<QueryAvailablePaymentMethodsResponse> result = await mPaymentsController.QueryAvailablePaymentMethodsAsync(
        null,
        body
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Example Response *(as JSON)*

```json
{
  "merchantCode": "US_MERCHANT_CODE",
  "availablePaymentMethods": [
    {
      "paymentMethod": "card/scheme",
      "currencyCode": [
        "USD",
        "CAD"
      ]
    },
    {
      "paymentMethod": "card/scheme_encrypted",
      "currencyCode": [
        "USD",
        "CAD"
      ]
    },
    {
      "paymentMethod": "card/merchant_gift",
      "currencyCode": [
        "USD",
        "CAD"
      ]
    }
  ]
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |
| 500 | Server Error | [`ProblemDetailsException`](../../doc/models/problem-details-exception.md) |

