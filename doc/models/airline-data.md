
# Airline Data

Support for Airline (Industry Specific) Data

## Structure

`AirlineData`

## Inherits From

[`BaseIndustryData`](../../doc/models/base-industry-data.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AirlineCode` | `string` | Optional | IATA 3 digit code that identifies the carrier |
| `TicketNumber` | `string` | Optional | The ticket's unique identifier |
| `DepartureDate` | `DateTime?` | Optional | Flight departure date. |
| `Passenger` | [`IndustryDataAirlinePassenger`](../../doc/models/industry-data-airline-passenger.md) | Optional | - |
| `TripLegs` | [`List<IndustryDataAirlineFlightLeg>`](../../doc/models/industry-data-airline-flight-leg.md) | Optional | Information about each leg of the flight |
| `TravelAgency` | [`IndustryDataAirlineTravelAgency`](../../doc/models/industry-data-airline-travel-agency.md) | Optional | - |

## Example (as JSON)

```json
{
  "type": "industry/airline",
  "airlineCode": "airlineCode2",
  "ticketNumber": "ticketNumber2",
  "departureDate": "2016-03-13",
  "passenger": {
    "firstName": "firstName6",
    "lastName": "lastName4",
    "dateOfBirth": "2016-03-13",
    "telephoneNumber": "telephoneNumber2",
    "travelerType": "travelerType4"
  },
  "tripLegs": [
    {
      "carrierCode": "carrierCode8",
      "flightNumber": "flightNumber2",
      "classOfTravel": "classOfTravel6",
      "departureDate": "2016-03-13T12:52:32.123Z",
      "departureTax": 96
    },
    {
      "carrierCode": "carrierCode8",
      "flightNumber": "flightNumber2",
      "classOfTravel": "classOfTravel6",
      "departureDate": "2016-03-13T12:52:32.123Z",
      "departureTax": 96
    },
    {
      "carrierCode": "carrierCode8",
      "flightNumber": "flightNumber2",
      "classOfTravel": "classOfTravel6",
      "departureDate": "2016-03-13T12:52:32.123Z",
      "departureTax": 96
    }
  ]
}
```

