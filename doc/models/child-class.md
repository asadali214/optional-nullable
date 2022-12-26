
# Child Class

## Structure

`ChildClass`

## Inherits From

[`ParentClass`](../../doc/models/parent-class.md)

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `OptionalNullable` | `string` | Optional | - |
| `OptionalNullableWithDefaultValue` | `string` | Optional | **Default**: `"With default value"` |
| `Optional` | `string` | Optional | - |
| `RequiredNullable` | `string` | Required | - |
| `Required` | `string` | Required | **Default**: `"not nullable and required"` |
| `ChildClassArray` | [`List<Models.ChildClass>`](../../doc/models/child-class.md) | Optional | - |

## Example (as JSON)

```json
{
  "Grand_Parent_Required_Nullable": null,
  "Grand_Parent_Required": "not nullable and required",
  "Parent_Required_Nullable": null,
  "Parent_Required": "not nullable and required",
  "Required_Nullable": null,
  "Required": "not nullable and required"
}
```

