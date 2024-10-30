
# Authorize Payment Request

## Structure

`AuthorizePaymentRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantCode` | `string` | Required | The merchant account identifier we geve you under which you want to process this transaction.<br>**Constraints**: *Minimum Length*: `1` |
| `CallersReferenceId` | `string` | Optional | Your reference value for this payment that is carried thru to reporting. |
| `Amount` | [`Amount`](../../doc/models/amount.md) | Required | - |
| `PaymentMethod` | `object` | Required | The type and required details of a payment method to use. |
| `IndustryData` | `object` | Optional | Additional Industry Specific Data |
| `CustomerData` | [`CustomerData`](../../doc/models/customer-data.md) | Optional | - |
| `ScaData` | [`ScaData2`](../../doc/models/sca-data-2.md) | Optional | - |
| `PayfacData` | [`PayfacData2`](../../doc/models/payfac-data-2.md) | Optional | - |
| `AdditionalData` | `object` | Optional | - |
| `DynamicMCC` | `string` | Optional | The merchant category code (MCC) is a four-digit number, which relates to a particular market segment. |
| `CustomerInteractionType` | [`CustomerInteractionTypeEnum?`](../../doc/models/customer-interaction-type-enum.md) | Optional | - |

## Example (as JSON)

```json
{
  "merchantCode": "merchantCode8",
  "callersReferenceId": "callersReferenceId8",
  "amount": {
    "value": 110,
    "currencyCode": "GBP"
  },
  "paymentMethod": {
    "key1": "val1",
    "key2": "val2"
  },
  "industryData": {
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
  },
  "scaData": {
    "authenticationRiskData": {
      "key1": "val1",
      "key2": "val2"
    },
    "shopperAccountRiskData": {
      "key1": "val1",
      "key2": "val2"
    },
    "transactionRiskData": {
      "key1": "val1",
      "key2": "val2"
    }
  },
  "payfacData": {
    "payfacId": "payfacId4",
    "isoId": "isoId4",
    "submerchantId": "submerchantId8",
    "submerchantName": "submerchantName4",
    "submerchantAddress": {
      "firstName": "firstName4",
      "lastName": "lastName4",
      "street": "street0",
      "streetLine2": "streetLine20",
      "city": "city0"
    },
    "submerchantTaxId": "submerchantTaxId2"
  }
}
```

