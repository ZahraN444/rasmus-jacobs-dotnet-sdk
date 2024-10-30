
# Industry Data Airline Flight Leg

## Structure

`IndustryDataAirlineFlightLeg`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `CarrierCode` | `string` | Optional | IATA 2-letter accounting code that identifies the carrier. |
| `FlightNumber` | `string` | Optional | The carrier's identifier for this flight |
| `ClassOfTravel` | `string` | Optional | 1-letter travel class identifier |
| `DepartureDate` | `DateTime?` | Optional | Departure Date and Time of this leg |
| `DepartureTax` | `int?` | Optional | Amount charged by a country to an individual upon their leaving in minor units |
| `DestinationAirportCode` | `string` | Optional | Alphabetical identifier of the destination/arrival airport |
| `FareBasisCode` | `string` | Optional | alphabetic or alpha-numeric code used by airlines to identify a fare type |

## Example (as JSON)

```json
{
  "carrierCode": "carrierCode0",
  "flightNumber": "flightNumber4",
  "classOfTravel": "classOfTravel8",
  "departureDate": "2016-03-13T12:52:32.123Z",
  "departureTax": 108
}
```

