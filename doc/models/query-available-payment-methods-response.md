
# Query Available Payment Methods Response

## Structure

`QueryAvailablePaymentMethodsResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantCode` | `string` | Optional | The merchant account identifier we geve you under which you want to process this transaction. |
| `AvailablePaymentMethods` | [`List<AvailablePaymentMethod>`](../../doc/models/available-payment-method.md) | Optional | - |

## Example (as JSON)

```json
{
  "merchantCode": "merchantCode6",
  "availablePaymentMethods": [
    {
      "paymentMethod": "paymentMethod8",
      "currencyCode": [
        "USD",
        "Undefined",
        "CAD"
      ]
    },
    {
      "paymentMethod": "paymentMethod8",
      "currencyCode": [
        "USD",
        "Undefined",
        "CAD"
      ]
    },
    {
      "paymentMethod": "paymentMethod8",
      "currencyCode": [
        "USD",
        "Undefined",
        "CAD"
      ]
    }
  ]
}
```

