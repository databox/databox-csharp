# Databox.Api.DefaultApi

All URIs are relative to *http://localhost:8080/q/openapi*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RootPost**](DefaultApi.md#rootpost) | **POST** / |  |

<a id="rootpost"></a>
# **RootPost**
> void RootPost (PayloadModel? payloadModel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Databox.Api;
using Databox.Client;
using Databox.Model;

namespace Example
{
    public class RootPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8080/q/openapi";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
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

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

