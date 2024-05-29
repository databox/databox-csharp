# Org.OpenAPITools.Api.MicroProfileHealthApi

All URIs are relative to *https://push.databox.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MicroprofileHealthLiveness**](MicroProfileHealthApi.md#microprofilehealthliveness) | **GET** /q/health/live | The Liveness check of this application |
| [**MicroprofileHealthReadiness**](MicroProfileHealthApi.md#microprofilehealthreadiness) | **GET** /q/health/ready | The Readiness check of this application |
| [**MicroprofileHealthRoot**](MicroProfileHealthApi.md#microprofilehealthroot) | **GET** /q/health | An aggregated view of the Liveness and Readiness of this application |

<a id="microprofilehealthliveness"></a>
# **MicroprofileHealthLiveness**
> HealthCheckResponse MicroprofileHealthLiveness ()

The Liveness check of this application

Check the liveness of the application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MicroprofileHealthLivenessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new MicroProfileHealthApi(config);

            try
            {
                // The Liveness check of this application
                HealthCheckResponse result = apiInstance.MicroprofileHealthLiveness();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicroProfileHealthApi.MicroprofileHealthLiveness: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MicroprofileHealthLivenessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The Liveness check of this application
    ApiResponse<HealthCheckResponse> response = apiInstance.MicroprofileHealthLivenessWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicroProfileHealthApi.MicroprofileHealthLivenessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthCheckResponse**](HealthCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **503** | Service Unavailable |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="microprofilehealthreadiness"></a>
# **MicroprofileHealthReadiness**
> HealthCheckResponse MicroprofileHealthReadiness ()

The Readiness check of this application

Check the readiness of the application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MicroprofileHealthReadinessExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new MicroProfileHealthApi(config);

            try
            {
                // The Readiness check of this application
                HealthCheckResponse result = apiInstance.MicroprofileHealthReadiness();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicroProfileHealthApi.MicroprofileHealthReadiness: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MicroprofileHealthReadinessWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The Readiness check of this application
    ApiResponse<HealthCheckResponse> response = apiInstance.MicroprofileHealthReadinessWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicroProfileHealthApi.MicroprofileHealthReadinessWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthCheckResponse**](HealthCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **503** | Service Unavailable |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="microprofilehealthroot"></a>
# **MicroprofileHealthRoot**
> HealthCheckResponse MicroprofileHealthRoot ()

An aggregated view of the Liveness and Readiness of this application

Check the health of the application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MicroprofileHealthRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://push.databox.com";
            var apiInstance = new MicroProfileHealthApi(config);

            try
            {
                // An aggregated view of the Liveness and Readiness of this application
                HealthCheckResponse result = apiInstance.MicroprofileHealthRoot();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MicroProfileHealthApi.MicroprofileHealthRoot: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MicroprofileHealthRootWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // An aggregated view of the Liveness and Readiness of this application
    ApiResponse<HealthCheckResponse> response = apiInstance.MicroprofileHealthRootWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MicroProfileHealthApi.MicroprofileHealthRootWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthCheckResponse**](HealthCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **503** | Service Unavailable |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

