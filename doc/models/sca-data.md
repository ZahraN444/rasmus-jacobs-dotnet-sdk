
# SCA Data

Information to support Strong Customer AUthentication (SCA)

## Structure

`SCAData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AuthenticationRiskData` | `object` | Optional | Information about the shopper and how they are authenticating with Worldpay. |
| `ShopperAccountRiskData` | `object` | Optional | Information about the shopper's account with you. |
| `TransactionRiskData` | `object` | Optional | Information about the order. |

## Example (as JSON)

```json
{
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
}
```

