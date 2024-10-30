
# Customer

Information About the customer

## Structure

`Customer`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `BillingAddress` | [`Address`](../../doc/models/address.md) | Optional | - |
| `ShippingAddress` | [`Address`](../../doc/models/address.md) | Optional | - |
| `TelephoneNumber` | `string` | Optional | The customer's telephone number. |
| `DateOfBirth` | `DateTime?` | Optional | The customer's date of birth in ISO-8601 format (YYYY-MM-DD) |
| `EmailAddress` | `string` | Optional | The customer's email address. |
| `IpAddress` | `string` | Optional | The customer's IP address. |
| `ShopperLocale` | `string` | Optional | The RFC 1766 language string for this shopper |

## Example (as JSON)

```json
{
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
  "telephoneNumber": "telephoneNumber0",
  "dateOfBirth": "2016-03-13",
  "emailAddress": "emailAddress8"
}
```

