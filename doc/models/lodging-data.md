
# Lodging Data

Support for Lodging (Industry Specific) Data

## Structure

`LodgingData`

## Inherits From

[`BaseIndustryData`](../../doc/models/base-industry-data.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `HotelFolioNumber` | `string` | Optional | Card acceptor’s internal invoice or billing ID reference number. |
| `CheckInDate` | `DateTime?` | Optional | The Date you are checking in |
| `CheckOutDate` | `DateTime?` | Optional | The Date you are checking out |
| `NumberOfDays` | `int?` | Optional | Total number of nights the room will be rented. |
| `NumberOfAdults` | `int?` | Optional | The total amount of adults staying in the room |
| `CustomerServiceTollFreeNumber` | `string` | Optional | The toll free phone number for customer service |
| `PropertyLocalPhoneNumber` | `string` | Optional | The local phone number for the property |
| `FireSafetyIndicator` | `bool?` | Optional | Does the facility complies with the Hotel and Motel Fire Safety Act of 1990 |
| `RoomRate` | [`Amount`](../../doc/models/amount.md) | Optional | - |
| `RoomTax` | [`Amount`](../../doc/models/amount.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "industry/lodging",
  "hotelFolioNumber": "hotelFolioNumber0",
  "checkInDate": "2016-03-13",
  "checkOutDate": "2016-03-13",
  "numberOfDays": 112,
  "numberOfAdults": 68
}
```

