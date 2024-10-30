
# APM Giropay

Support for GiroPay

## Structure

`APMGiropay`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuccessURL` | `string` | Optional | - |
| `CancelURL` | `string` | Optional | - |
| `FailureURL` | `string` | Optional | - |
| `PendingURL` | `string` | Optional | - |
| `SwiftCode` | `string` | Optional | The BIC/Swift code of the shopper’s bank. This can be either:<br><br>- A valid BIC (Business Identifier Code)<br>- Null |

## Example (as JSON)

```json
{
  "type": "apm/giropay",
  "successURL": "successURL2",
  "cancelURL": "cancelURL0",
  "failureURL": "failureURL8",
  "pendingURL": "pendingURL2",
  "swiftCode": "swiftCode2"
}
```

