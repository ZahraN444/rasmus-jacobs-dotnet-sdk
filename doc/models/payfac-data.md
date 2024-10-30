
# Payfac Data

Additional (optional) Information About the submerchant if you are a PayFac (Payment Facilitator)

## Structure

`PayfacData`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `PayfacId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `IsoId` | `string` | Optional | - |
| `SubmerchantId` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `SubmerchantName` | `string` | Required | **Constraints**: *Minimum Length*: `1` |
| `SubmerchantAddress` | [`Address`](../../doc/models/address.md) | Required | - |
| `SubmerchantTaxId` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "payfacId": "payfacId8",
  "isoId": "isoId8",
  "submerchantId": "submerchantId6",
  "submerchantName": "submerchantName8",
  "submerchantAddress": {
    "firstName": "firstName4",
    "lastName": "lastName4",
    "street": "street0",
    "streetLine2": "streetLine20",
    "city": "city0"
  },
  "submerchantTaxId": "submerchantTaxId8"
}
```

