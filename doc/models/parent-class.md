
# Parent Class

## Structure

`ParentClass`

## Inherits From

[`GrandParentClass`](../../doc/models/grand-parent-class.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Class` | `int?` | Optional | **Default**: `23` |
| `Precision` | `double?` | Optional | - |
| `BigDecimal` | `double?` | Optional | - |
| `ParentOptionalNullableWithDefaultValue` | `string` | Optional | **Default**: `"Has default value"` |
| `ParentOptional` | `string` | Optional | - |
| `ParentRequiredNullable` | `string` | Required | - |
| `ParentRequired` | `string` | Required | **Default**: `"not nullable and required"` |

## Example (as JSON)

```json
{
  "Grand_Parent_Required_Nullable": null,
  "Grand_Parent_Required": "not nullable and required",
  "Parent_Required_Nullable": null,
  "Parent_Required": "not nullable and required"
}
```

