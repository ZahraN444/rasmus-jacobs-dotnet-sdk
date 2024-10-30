
# Level 2 and 3 Line Item

Support for Level 2 and 3 (Industry Specific) Line Item Data

## Structure

`Level2and3LineItem`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `ItemSequenceNo` | `string` | Optional | - |
| `CommodityCode` | `string` | Optional | - |
| `ItemDescription` | `string` | Optional | - |
| `ProductCode` | `string` | Optional | - |
| `Quantity` | `int?` | Optional | - |
| `Uom` | `string` | Optional | - |
| `UnitCost` | [`Amount`](../../doc/models/amount.md) | Optional | - |
| `ItemDiscountAmount` | [`Amount`](../../doc/models/amount.md) | Optional | - |
| `LineItemTotal` | [`Amount`](../../doc/models/amount.md) | Optional | - |

## Example (as JSON)

```json
{
  "itemSequenceNo": "itemSequenceNo6",
  "commodityCode": "commodityCode6",
  "itemDescription": "itemDescription4",
  "productCode": "productCode2",
  "quantity": 68
}
```

