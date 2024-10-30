
# Card Scheme

Support for Full Card Information

## Structure

`CardScheme`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CardHolderName` | `string` | Optional | The name of the CardHolder |
| `CardNumber` | `string` | Required | The Card Number<br>**Constraints**: *Minimum Length*: `1` |
| `CardVerificationCode` | `string` | Required | The card verification code (same as CVV or CID)<br>**Constraints**: *Minimum Length*: `1` |
| `ExpiryMonth` | `int` | Required | The Card Expiry Month (1-12) |
| `ExpiryYear` | `int` | Required | The Card Expiry Year |
| `ReturnSecurityToken` | `bool?` | Optional | If true, return a new or existing Security Token for this Card Number |

## Example (as JSON)

```json
{
  "type": "card/scheme",
  "cardHolderName": "cardHolderName6",
  "cardNumber": "cardNumber8",
  "cardVerificationCode": "cardVerificationCode8",
  "expiryMonth": 222,
  "expiryYear": 218,
  "returnSecurityToken": false
}
```

