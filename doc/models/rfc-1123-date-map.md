
# Rfc 1123 Date Map

## Structure

`Rfc1123DateMap`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `DateTime` | `Dictionary<string, DateTime>` | Optional | - |
| `DateTime1` | `Dictionary<string, DateTime>` | Required | - |

## Example (as JSON)

```json
{
  "dateTime": null,
  "dateTime1": {
    "key0": "Mon, 15 Jun 2009 20:45:30 GMT",
    "key1": "Mon, 15 Jun 2009 20:45:30 GMT",
    "key2": "Mon, 15 Jun 2009 20:45:30 GMT"
  }
}
```

