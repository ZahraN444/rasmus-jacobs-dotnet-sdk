
# APM Ideal

Support for Ideal

## Structure

`APMIdeal`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `SuccessURL` | `string` | Optional | - |
| `FailureURL` | `string` | Optional | - |
| `CancelURL` | `string` | Optional | - |
| `PendingURL` | `string` | Optional | - |
| `BankCode` | [`APMIdealBankCodeEnum?`](../../doc/models/apm-ideal-bank-code-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "apm/ideal",
  "successURL": "successURL6",
  "failureURL": "failureURL2",
  "cancelURL": "cancelURL4",
  "pendingURL": "pendingURL6",
  "bankCode": "ASN"
}
```

