
# Direct Debit EFT

Support for Direct Debit in the US

## Structure

`DirectDebitEFT`

## Inherits From

[`BasePaymentMethod`](../../doc/models/base-payment-method.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountType` | [`DirectDebitACHAccountTypeEnum?`](../../doc/models/direct-debit-ach-account-type-enum.md) | Optional | - |
| `AccountNumber` | `string` | Optional | - |
| `RoutingNumber` | `string` | Optional | - |
| `CheckNumber` | `string` | Optional | - |
| `CompanyName` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "type": "direct_debit/eft",
  "accountType": "checking",
  "accountNumber": "accountNumber4",
  "routingNumber": "routingNumber8",
  "checkNumber": "checkNumber2",
  "companyName": "companyName8"
}
```

