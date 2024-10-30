
# Getting Started with WP Global CNP Payment API

## Introduction

<b>Request Payload Validation Testing</b> endpoints
<br/>
<br/>
Functional Goals:

<pre>   <span>&#8226;</span>  Clean API surface area following standard REST conventions
<pre>   <span>&#8226;</span>  Thin mapping layer over an integration to <b>WPG's</b> XML-RPC webAPI for US and Intl Merchants
<pre>   <span>&#8226;</span>  Logically strutured Request and Response objects
<pre>   <span>&#8226;</span>  Support of Idempotency (via a HTTP Header)
<pre>   <span>&#8226;</span>  Ability to easily adding new <b>payment methods</b> via a polymorphic <b>PaymentMethod</b> property
<pre>   <span>&#8226;</span>  Ability to easily adding new <b>industry specific</b> data via a polymorphic <b>IndustryData</b> property
<pre>   <span>&#8226;</span>  Developer friendly <b>Request Data Validation error</b> responses
<pre>   <span>&#8226;</span>  Support for "Referenced" follow on transactions
<pre>   <span>&#8226;</span>  Baked in support for Sync responses (indicated by a HTTP 200 return code) and Async responses (indicated by a HTTP 202 return code).
<pre>   <span>&#8226;</span>  Error responses returned in RFC7807 ProblemDetails compliant responses
<pre>   <span>&#8226;</span>  High Fidelity OpenAPI v3 file (incl oneOf and type descriminators for polymorphic properties)
<br/>
<table>
<thead>
<tr>
<th>Date</th>
<th>Version</th>
<th>Changes</th>
</tr>
</thead>
<tbody>
<tr>
<td>2022/04/15</td>
<td>v1.0</td>
<td> Alpha implementation
</td>
</tr>
</tbody>
</table>


## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package ErasmusJacobsSDK --version 4.5.4
```

You can also view the package at:
https://www.nuget.org/packages/ErasmusJacobsSDK/4.5.4

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| `Environment` | `Environment` | The API environment. <br> **Default: `Environment.Production`** |
| `Timeout` | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| `LogBuilder` | [`LogBuilder`](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/log-builder.md) | Represents the logging configuration builder for API calls |

The API client can be initialized as follows:

```csharp
WPGlobalCNPPaymentAPIClient client = new WPGlobalCNPPaymentAPIClient.Builder()
    .Environment(WPGlobalCNPPaymentAPI.Standard.Environment.Production)
    .LoggingConfig(config => config
        .LogLevel(LogLevel.Information)
        .RequestConfig(reqConfig => reqConfig.Body(true))
        .ResponseConfig(respConfig => respConfig.Headers(true))
    )
    .Build();
```

API calls return an `ApiResponse` object that includes the following fields:

| Field | Description |
|  --- | --- |
| `StatusCode` | Status code of the HTTP response |
| `Headers` | Headers of the HTTP response as a Hash |
| `Data` | The deserialized body of the HTTP response as a String |

## Environments

The SDK can be configured to use a different environment for making API calls. Available environments are:

### Fields

| Name | Description |
|  --- | --- |
| Production | **Default** |
| Staging | - |
| Dev | - |
| Qa | - |
| Mock Server (only available for Thingspace M2M APIs) | - |

## List of APIs

* [Payments](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/controllers/payments.md)
* [Tokens](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/controllers/tokens.md)

## Classes Documentation

* [Utility Classes](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/utility-classes.md)
* [HttpRequest](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/http-request.md)
* [HttpResponse](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/http-string-response.md)
* [HttpContext](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/http-context.md)
* [HttpClientConfiguration](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/http-client-configuration.md)
* [HttpClientConfiguration Builder](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/http-client-configuration-builder.md)
* [IAuthManager](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/i-auth-manager.md)
* [ApiException](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/api-exception.md)
* [LogBuilder](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/log-builder.md)
* [LogRequestBuilder](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/log-request-builder.md)
* [LogResponseBuilder](https://www.github.com/ZahraN444/rasmus-jacobs-dotnet-sdk/tree/4.5.4/doc/log-response-builder.md)

