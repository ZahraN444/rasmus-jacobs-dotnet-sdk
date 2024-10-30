
# Tokenize Request

## Structure

`TokenizeRequest`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `MerchantCode` | `string` | Required | The merchant account identifier we geve you under which you want to process this transaction.<br>**Constraints**: *Minimum Length*: `1` |
| `DataToTokenize` | `object` | Required | The type and required details of data to tokenize |

## Example (as JSON)

```json
{
  "merchantCode": "merchantCode2",
  "dataToTokenize": {
    "key1": "val1",
    "key2": "val2"
  }
}
```

