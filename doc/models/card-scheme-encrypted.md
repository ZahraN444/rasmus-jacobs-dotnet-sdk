
# Card Scheme Encrypted

Similiar to CardSchemePlain except the PCI fields are encrypted with a merchant provided key

## Structure

`CardSchemeEncrypted`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `EncryptedCardNumber` | `string` | Optional | The encrypted Card Number |
| `EncryptedCardVerificationCode` | `string` | Optional | The encrypted card verification code (same as CVV or CID) |
| `EncryptedExpiryMonth` | `string` | Optional | The encrypted Card Expiry Month |
| `EncryptedExpiryYear` | `string` | Optional | The encrypted Card Expiry Year |
| `CardHolderName` | `string` | Optional | The name of the CardHolder |

## Example (as JSON)

```json
{
  "type": "card/scheme_encrypted",
  "encryptedCardNumber": "encryptedCardNumber6",
  "encryptedCardVerificationCode": "encryptedCardVerificationCode8",
  "encryptedExpiryMonth": "encryptedExpiryMonth4",
  "encryptedExpiryYear": "encryptedExpiryYear8",
  "CardHolderName": "CardHolderName0"
}
```

