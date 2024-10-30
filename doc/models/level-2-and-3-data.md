
# Level 2 and 3 Data

Support for Level 2 and 3 (Industry Specific) Data

## Structure

`Level2and3Data`

## Inherits From

[`BaseIndustryData`](../../doc/models/base-industry-data.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CustomerReference` | `string` | Optional | Card acceptor’s internal invoice or billing ID reference number. |
| `InvoiceReferenceNo` | `string` | Optional | - |
| `OrderDate` | `DateTime?` | Optional | - |
| `ShipFromCountryCode` | `string` | Optional | - |
| `ShipFromPostalCode` | `string` | Optional | - |
| `DestinationCountryCode` | `string` | Optional | - |
| `DestinationPostalCode` | `string` | Optional | - |
| `LineItems` | [`List<Level2and3LineItem>`](../../doc/models/level-2-and-3-line-item.md) | Optional | Line items associated with this order |

## Example (as JSON)

```json
{
  "type": "industry/level2_3",
  "customerReference": "customerReference0",
  "invoiceReferenceNo": "invoiceReferenceNo2",
  "orderDate": "2016-03-13",
  "shipFromCountryCode": "shipFromCountryCode2",
  "shipFromPostalCode": "shipFromPostalCode2"
}
```

