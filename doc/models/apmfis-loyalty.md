
# APMFIS Loyalty

Support for FIS Loyalty (Retail Rewards)

## Structure

`APMFISLoyalty`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `FisDiscountedAmount` | `string` | Optional | The actual discounted amounted returned to the terminal so the customer can determine whether to opt in/out. |
| `FisLoyaltyEligibility` | `bool?` | Optional | True/False flag indicating the merchant's ability to accept Loyalty transactions. |
| `FisLoyaltyOptIn` | `bool?` | Optional | True/False flag on the follow-up message to indicate whether or not the customer accepts the discounted amount. |
| `FisLoyaltyTransactionID` | `string` | Optional | The FIS transaction ID that ties requests together. It should be sent on any follow-up messages. |
| `FisLoyaltyRewardID` | `string` | Optional | This field contains the reward ID associated with the transaction. |
| `FisLoyaltyPromoID` | `string` | Optional | This field contains the loyalty program associated with the transaction |
| `FisLoyaltySequenceNumber` | `string` | Optional | This field contains the loyalty sequence number that must be submitted on subsequent loyalty transactions |
| `FisLoyaltyReservationID` | `string` | Optional | This contains the reservation ID used with the loyalty system to reserve/finalize e-comm Premium Payback tranasactions. |
| `FisLoyaltyPSPID` | `string` | Optional | This contains the PSP identifier associated with the processor who holds the loyalty reservation. It will be ignored without a Loyalty Reservation ID. |

## Example (as JSON)

```json
{
  "type": "apm/fisloyalty",
  "fisDiscountedAmount": "fisDiscountedAmount0",
  "FisLoyaltyEligibility": false,
  "fisLoyaltyOptIn": false,
  "fisLoyaltyTransactionID": "fisLoyaltyTransactionID8",
  "fisLoyaltyRewardID": "fisLoyaltyRewardID4"
}
```

