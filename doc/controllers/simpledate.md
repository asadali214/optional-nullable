# Simpledate

```csharp
SimpledateController simpledateController = client.SimpledateController;
```

## Class Name

`SimpledateController`

## Methods

* [Create Send Simple Date](../../doc/controllers/simpledate.md#create-send-simple-date)
* [Create Send Simple Date Array](../../doc/controllers/simpledate.md#create-send-simple-date-array)


# Create Send Simple Date

```csharp
CreateSendSimpleDateAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.SimpleDate date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.SimpleDate`](../../doc/models/simple-date.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new SimpleDate();

try
{
    ServerResponse result = await simpleDateController.CreateSendSimpleDateAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```


# Create Send Simple Date Array

```csharp
CreateSendSimpleDateArrayAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.SimpleDateArray date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.SimpleDateArray`](../../doc/models/simple-date-array.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new SimpleDateArray();

try
{
    ServerResponse result = await simpleDateController.CreateSendSimpleDateArrayAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```

