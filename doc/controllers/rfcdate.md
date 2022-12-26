# Rfcdate

```csharp
RfcdateController rfcdateController = client.RfcdateController;
```

## Class Name

`RfcdateController`

## Methods

* [Create Send Rfc 1123 Date](../../doc/controllers/rfcdate.md#create-send-rfc-1123-date)
* [Create Send Rfc 1123 Date Array](../../doc/controllers/rfcdate.md#create-send-rfc-1123-date-array)
* [Create Send Rfc 1123 Date Map](../../doc/controllers/rfcdate.md#create-send-rfc-1123-date-map)


# Create Send Rfc 1123 Date

```csharp
CreateSendRfc1123DateAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.Rfc1123Date date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.Rfc1123Date`](../../doc/models/rfc-1123-date.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new Rfc1123Date();
date.DateTime1 = DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT");

try
{
    ServerResponse result = await rfcDateController.CreateSendRfc1123DateAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```


# Create Send Rfc 1123 Date Array

```csharp
CreateSendRfc1123DateArrayAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.Rfc1123DateArray date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.Rfc1123DateArray`](../../doc/models/rfc-1123-date-array.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new Rfc1123DateArray();
date.DateTime1 = new List<DateTime>();
date.DateTime1.Add(DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT"));
date.DateTime1.Add(DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT"));

try
{
    ServerResponse result = await rfcDateController.CreateSendRfc1123DateArrayAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```


# Create Send Rfc 1123 Date Map

```csharp
CreateSendRfc1123DateMapAsync(
    bool unSet,
    bool setToNull,
    string field,
    Models.Rfc1123DateMap date)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `unSet` | `bool` | Query, Required | - |
| `setToNull` | `bool` | Query, Required | - |
| `field` | `string` | Query, Required | - |
| `date` | [`Models.Rfc1123DateMap`](../../doc/models/rfc-1123-date-map.md) | Body, Required | - |

## Response Type

[`Task<Models.ServerResponse>`](../../doc/models/server-response.md)

## Example Usage

```csharp
bool unSet = false;
bool setToNull = false;
string field = "field6";
var date = new Rfc1123DateMap();
date.DateTime1 = new Dictionary<string, DateTime>();
date.DateTime1.Add("key0", DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT"));
date.DateTime1.Add("key1", DateTime.Parse("Mon, 15 Jun 2009 20:45:30 GMT"));

try
{
    ServerResponse result = await rfcDateController.CreateSendRfc1123DateMapAsync(unSet, setToNull, field, date);
}
catch (ApiException e){};
```

