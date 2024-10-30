
# Wallet Amazon Pay

Support for Amazon Pay payments

## Structure

`WalletAmazonPay`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AmazonPayChargeID` | `int?` | Optional | ID of the Charge object created at Amazon Pay. It should be passed on every subsequent request for this transaction. |
| `AmazonPayToken` | `int?` | Optional | This field represents the high value token for the transaction. |
| `AmazonPayBillingDescriptor` | `int?` | Optional | The description to be shown on the buyer's payment statement. For a payment, it should be passed either during authorization or capture. |
| `AmazonPayMerchantOrderNumber` | `int?` | Optional | This field contains the order number associated with the transaction. Any inquiries regarding the transactions should use this value. |
| `AmazonPayMerchantID` | `int?` | Optional | Gets or sets my property. |

## Example (as JSON)

```json
{
  "type": "wallet/amazonpay",
  "amazonPayChargeID": 214,
  "amazonPayToken": 70,
  "amazonPayBillingDescriptor": 214,
  "amazonPayMerchantOrderNumber": 62,
  "amazonPayMerchantID": 182
}
```

