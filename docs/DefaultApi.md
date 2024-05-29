# Org.OpenAPITools.Api.DefaultApi

All URIs are relative to *https://push.databox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DataDelete**](DefaultApi.md#datadelete) | **DELETE** /data |  |
| [**DataMetricKeyDelete**](DefaultApi.md#datametrickeydelete) | **DELETE** /data/{metricKey} |  |
| [**DataPost**](DefaultApi.md#datapost) | **POST** /data |  |
| [**LastpushesGet**](DefaultApi.md#lastpushesget) | **GET** /lastpushes |  |
| [**MetrickeysGet**](DefaultApi.md#metrickeysget) | **GET** /metrickeys |  |
| [**MetrickeysPost**](DefaultApi.md#metrickeyspost) | **POST** /metrickeys |  |
| [**PingGet**](DefaultApi.md#pingget) | **GET** /ping |  |
| [**RootPost**](DefaultApi.md#rootpost) | **POST** / |  |

<a id="datadelete"></a>
# **DataDelete**
> void DataDelete ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.DataDelete();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DataDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DataDeleteWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DataDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datametrickeydelete"></a>
# **DataMetricKeyDelete**
> void DataMetricKeyDelete (string metricKey)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataMetricKeyDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);
            var metricKey = "metricKey_example";  // string | 

            try
            {
                apiInstance.DataMetricKeyDelete(metricKey);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DataMetricKeyDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataMetricKeyDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DataMetricKeyDeleteWithHttpInfo(metricKey);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DataMetricKeyDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **metricKey** | **string** |  |  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="datapost"></a>
# **DataPost**
> void DataPost (List<PushData>? pushData = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DataPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);
            var pushData = new List<PushData>?(); // List<PushData>? |  (optional) 

            try
            {
                apiInstance.DataPost(pushData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DataPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DataPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.DataPostWithHttpInfo(pushData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DataPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pushData** | [**List&lt;PushData&gt;?**](PushData.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.databox.v2+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="lastpushesget"></a>
# **LastpushesGet**
> void LastpushesGet (string? limit = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LastpushesGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);
            var limit = "limit_example";  // string? |  (optional) 

            try
            {
                apiInstance.LastpushesGet(limit);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.LastpushesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LastpushesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.LastpushesGetWithHttpInfo(limit);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.LastpushesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **limit** | **string?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="metrickeysget"></a>
# **MetrickeysGet**
> void MetrickeysGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MetrickeysGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.MetrickeysGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MetrickeysGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MetrickeysGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MetrickeysGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.MetrickeysGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="metrickeyspost"></a>
# **MetrickeysPost**
> void MetrickeysPost (Object? body = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MetrickeysPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);
            var body = null;  // Object? |  (optional) 

            try
            {
                apiInstance.MetrickeysPost(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MetrickeysPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MetrickeysPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.MetrickeysPostWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.MetrickeysPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **Object?** |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.databox.v2+json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pingget"></a>
# **PingGet**
> void PingGet ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);

            try
            {
                apiInstance.PingGet();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PingGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PingGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.PingGetWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PingGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rootpost"></a>
# **RootPost**
> void RootPost (PayloadModel? payloadModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RootPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new DefaultApi(config);
            var payloadModel = new PayloadModel?(); // PayloadModel? |  (optional) 

            try
            {
                apiInstance.RootPost(payloadModel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RootPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RootPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    apiInstance.RootPostWithHttpInfo(payloadModel);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RootPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payloadModel** | [**PayloadModel?**](PayloadModel?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/vnd.databox.v2+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

