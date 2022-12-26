# Body

```csharp
BodyController bodyController = client.BodyController;
```

## Class Name

`BodyController`


# Create Send Child

```csharp
CreateSendChildAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.ChildClass child)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `child` | [`Models.ChildClass`](../../doc/models/child-class.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var child = new ChildClass();
child.GrandParentRequiredNullable = "Grand_Parent_Required_Nullable4";
child.GrandParentRequired = "not nullable and required";
child.ParentRequiredNullable = "Parent_Required_Nullable8";
child.ParentRequired = "not nullable and required";
child.RequiredNullable = "Required_Nullable2";
child.Required = "not nullable and required";

try
{
    ServerResponse result = await bodyController.CreateSendChildAsync(unSet, setToNull, field, child);
}
catch (ApiException e){};
```

