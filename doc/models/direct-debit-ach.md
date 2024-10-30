
# Direct Debit ACH

Support for Direct Debit in the US

## Structure

`DirectDebitACH`

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
  "type": "direct_debit/ach",
  "accountType": "checking",
  "accountNumber": "accountNumber6",
  "routingNumber": "routingNumber8",
  "checkNumber": "checkNumber2",
  "companyName": "companyName8"
}
```

