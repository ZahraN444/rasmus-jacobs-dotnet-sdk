
# Token Data Card Scheme

## Structure

`TokenDataCardScheme`

## Inherits From

[`BaseDataToTokenize`](../../doc/models/base-data-to-tokenize.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardNumber` | `string` | Optional | The Card Number |
| `CardVerificationCode` | `string` | Optional | The card verification code (same as CVV or CID) |
| `ExpiryMonth` | `int?` | Optional | The Card Expiry Month |
| `ExpiryYear` | `int?` | Optional | The Card Expiry Year |

## Example (as JSON)

```json
{
  "type": "card/scheme",
  "cardNumber": "cardNumber4",
  "cardVerificationCode": "cardVerificationCode4",
  "expiryMonth": 16,
  "expiryYear": 88
}
```

