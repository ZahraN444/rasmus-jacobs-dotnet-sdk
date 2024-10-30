
# Sale Payment Request

## Structure

`SalePaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantCode` | `string` | Optional | The merchant account identifier we geve you under which you want to process this transaction. |
| `CallersReferenceId` | `string` | Optional | Your reference value for this payment that is carried thru to reporting. |
| `Amount` | [`Amount`](../../doc/models/amount.md) | Optional | - |
| `PaymentMethod` | `object` | Optional | The type and required details of a payment method to use. |
| `CustomerData` | [`CustomerData`](../../doc/models/customer-data.md) | Optional | - |
| `AdditionalData` | `object` | Optional | - |
| `DynamicMCC` | `string` | Optional | The merchant category code (MCC) is a four-digit number, which relates to a particular market segment. |
| `CustomerInteractionType` | [`CustomerInteractionTypeEnum?`](../../doc/models/customer-interaction-type-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "merchantCode": "merchantCode0",
  "callersReferenceId": "callersReferenceId0",
  "amount": {
    "value": 110,
    "currencyCode": "GBP"
  },
  "paymentMethod": {
    "key1": "val1",
    "key2": "val2"
  },
  "customerData": {
    "billingAddress": {
      "firstName": "firstName2",
      "lastName": "lastName6",
      "street": "street2",
      "streetLine2": "streetLine22",
      "city": "city8"
    },
    "shippingAddress": {
      "firstName": "firstName6",
      "lastName": "lastName2",
      "street": "street8",
      "streetLine2": "streetLine28",
      "city": "city2"
    },
    "telephoneNumber": "telephoneNumber8",
    "dateOfBirth": "2016-03-13",
    "emailAddress": "emailAddress6"
  }
}
```

