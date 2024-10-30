
# Direct Debit SEPA

Support for Direct Debit via SEPA

## Structure

`DirectDebitSEPA`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Iban` | `string` | Optional | International Bank Account Number |

## Example (as JSON)

```json
{
  "type": "direct_debit/sepa",
  "iban": "iban0"
}
```

