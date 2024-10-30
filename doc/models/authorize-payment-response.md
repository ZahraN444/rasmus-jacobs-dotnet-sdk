
# Authorize Payment Response

## Structure

`AuthorizePaymentResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `WpTransactionId` | `string` | Optional | WorldPay's globally unique reference for this transaction/request.  You will use this value on all follow-up requests. |
| `ResultCode` | [`ResultCodeEnum?`](../../doc/models/result-code-enum.md) | Optional | - |
| `Message` | `string` | Optional | - |
| `RefusalReason` | [`RefusalReasonEnum?`](../../doc/models/refusal-reason-enum.md) | Optional | - |
| `Amount` | [`Amount`](../../doc/models/amount.md) | Optional | - |
| `CallersReferenceId` | `string` | Optional | Your reference value for this payment that is carried thru to reporting. |
| `AdditionalData` | `object` | Optional | - |

## Example (as JSON)

```json
{
  "wpTransactionId": "wpTransactionId0",
  "resultCode": "Undefined",
  "message": "message0",
  "refusalReason": "Undefined",
  "amount": {
    "value": 110,
    "currencyCode": "GBP"
  }
}
```

