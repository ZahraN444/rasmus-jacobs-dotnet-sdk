
# Wallet Google Pay

Support for Google Pay payments with Visa, Mastercard and American Express (Amex) cards.

## Structure

`WalletGooglePay`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ProtocolVersion` | `string` | Optional | - |
| `Signature` | `string` | Optional | - |
| `SignedMessage` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "type": "wallet/googlepay",
  "protocolVersion": "protocolVersion8",
  "signature": "signature0",
  "signedMessage": "signedMessage4"
}
```

