
# Token WP Security

Support for Worldpay Security Tokens

## Structure

`TokenWPSecurity`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `TokenValue` | `string` | Optional | The Worldpay Security Token representing the Card No |
| `ExpiryMonth` | `int?` | Optional | The Card Expiry Month (if suppplied will be used in place of the value stored with the token) |
| `ExpiryYear` | `int?` | Optional | The Card Expiry Year (if suppplied will be used in place of the value stored with the token) |

## Example (as JSON)

```json
{
  "type": "token/wp_security",
  "tokenValue": "tokenValue4",
  "expiryMonth": 98,
  "expiryYear": 86
}
```

