
# APM Paypal

Support for Paypal

## Structure

`APMPaypal`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuccessURL` | `string` | Optional | - |
| `CancelURL` | `string` | Optional | - |
| `FailureURL` | `string` | Optional | - |
| `PendingURL` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "type": "apm/paypal",
  "successURL": "successURL6",
  "cancelURL": "cancelURL8",
  "failureURL": "failureURL0",
  "pendingURL": "pendingURL4"
}
```

