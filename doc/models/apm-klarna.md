
# APM Klarna

Support for BNPL (Buy Now Pay Later) using Klarna

## Structure

`APMKlarna`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `KlarnaWayToPay` | [`KlarnaWayToPayEnum?`](../../doc/models/klarna-way-to-pay-enum.md) | Optional | - |
| `SuccessURL` | `string` | Optional | - |
| `FailureURL` | `string` | Optional | - |
| `CancelURL` | `string` | Optional | - |
| `PendingURL` | `string` | Optional | - |
| `LineItems` | [`List<LineItem>`](../../doc/models/line-item.md) | Optional | Price and product information about the purchased items, to be included on the invoice sent to the shopper. |

## Example (as JSON)

```json
{
  "type": "apm/klarna",
  "klarnaWayToPay": "UNKNOWN",
  "successURL": "successURL8",
  "failureURL": "failureURL4",
  "cancelURL": "cancelURL6",
  "pendingURL": "pendingURL8"
}
```

