
# Token Data Direct Debit ACH

## Structure

`TokenDataDirectDebitACH`

## Inherits From

[`BaseDataToTokenize`](../../doc/models/base-data-to-tokenize.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `AccountType` | [`DirectDebitACHAccountTypeEnum?`](../../doc/models/direct-debit-ach-account-type-enum.md) | Optional | - |
| `AccountNumber` | `string` | Optional | - |
| `RoutingNumber` | `string` | Optional | - |

## Example (as JSON)

```json
{
  "type": "direct_debit/ach",
  "accountType": "savings",
  "accountNumber": "accountNumber0",
  "routingNumber": "routingNumber4"
}
```

