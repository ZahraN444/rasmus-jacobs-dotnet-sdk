
# Available Payment Method

## Structure

`AvailablePaymentMethod`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PaymentMethod` | `string` | Optional | - |
| `CurrencyCode` | [`List<CurrencyCodeEnum>`](../../doc/models/currency-code-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "paymentMethod": "paymentMethod0",
  "currencyCode": [
    "EUR",
    "GBP"
  ]
}
```

