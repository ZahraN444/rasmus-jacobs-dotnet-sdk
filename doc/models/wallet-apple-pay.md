
# Wallet Apple Pay

Support for Apple Pay payments with Visa, Mastercard, Maestro, American Express (Amex) and Discover cards.

## Structure

`WalletApplePay`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Header` | [`WalletApplePayWalletHeader`](../../doc/models/wallet-apple-pay-wallet-header.md) | Optional | - |
| `Signature` | `string` | Optional | - |
| `Version` | `string` | Optional | - |
| `Data` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "type": "wallet/applepay",
  "header": {
    "ephemeralPublicKey": "ephemeralPublicKey6",
    "publicKeyHash": "publicKeyHash2",
    "transactionId": "transactionId6"
  },
  "signature": "signature2",
  "version": "version0",
  "data": "data4"
}
```

