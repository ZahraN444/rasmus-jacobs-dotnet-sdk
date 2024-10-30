
# Card Merchant Gift

Closed Loop Gift Card

## Structure

`CardMerchantGift`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardNumber` | `string` | Optional | The Card Number |
| `CardVerificationCode` | `string` | Optional | The card verification code (same as CVV or CID) |

## Example (as JSON)

```json
{
  "type": "card/merchant_gift",
  "cardNumber": "cardNumber6",
  "cardVerificationCode": "cardVerificationCode6"
}
```

