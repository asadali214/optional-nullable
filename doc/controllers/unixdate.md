# Unixdate

```csharp
UnixdateController unixdateController = client.UnixdateController;
```

## Class Name

`UnixdateController`

## Methods

* [Create Send Unix Date](../../doc/controllers/unixdate.md#create-send-unix-date)
* [Create Send Unix Date Array](../../doc/controllers/unixdate.md#create-send-unix-date-array)
* [Create Send Unix Date Map](../../doc/controllers/unixdate.md#create-send-unix-date-map)


# Create Send Unix Date

```csharp
CreateSendUnixDateAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.UnixDate date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.UnixDate`](../../doc/models/unix-date.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new UnixDate();
date.DateTime1 = DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'.");

try
{
    ServerResponse result = await unixDateController.CreateSendUnixDateAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```


# Create Send Unix Date Array

```csharp
CreateSendUnixDateArrayAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.UnixDateArray date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.UnixDateArray`](../../doc/models/unix-date-array.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new UnixDateArray();
date.DateTime1 = new List<DateTime>();
date.DateTime1.Add(DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'."));
date.DateTime1.Add(DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'."));

try
{
    ServerResponse result = await unixDateController.CreateSendUnixDateArrayAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```


# Create Send Unix Date Map

```csharp
CreateSendUnixDateMapAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.UnixDateMap date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.UnixDateMap`](../../doc/models/unix-date-map.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new UnixDateMap();
date.DateTime1 = new Dictionary<string, DateTime>();
date.DateTime1.Add("key0", DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'."));
date.DateTime1.Add("key1", DateTime.Parse("Liquid error: Object of type 'System.Int64' cannot be converted to type 'System.String'."));

try
{
    ServerResponse result = await unixDateController.CreateSendUnixDateMapAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```

