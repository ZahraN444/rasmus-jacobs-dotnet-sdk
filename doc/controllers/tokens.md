# Tokens

```csharp
MTokensController mTokensController = client.MTokensController;
```

## Class Name

`MTokensController`


# Create Token

You want to create a token for the supplied information

```csharp
CreateTokenAsync(
    string idempotencyKey = null,
    Models.TokenizeRequest body = null)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `idempotencyKey` | `string` | Header, Optional | A unique identifier for the message with a maximum of 64 characters (we recommend a UUID). |
| `body` | [`TokenizeRequest`](../../doc/models/tokenize-request.md) | Body, Optional | The information for the Tokenize Request |

## Response Type

[`Task<ApiResponse<Models.TokenizeResponse>>`](../../doc/models/tokenize-response.md)

## Example Usage

```csharp
TokenizeRequest body = new TokenizeRequest
{
    MerchantCode = "US_MERCHANT_CODE",
    DataToTokenize = ApiHelper.JsonDeserialize<object>("{\"type\":\"card/scheme\",\"cardNumber\":\"4111111111111111\",\"cardVerificationCode\":\"123\",\"expiryMonth\":1,\"expiryYear\":2025}"),
};

try
{
    ApiResponse<TokenizeResponse> result = await mTokensController.CreateTokenAsync(
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

