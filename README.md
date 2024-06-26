# Org.OpenAPITools - the C# library for the Static OpenAPI document of Push API resource

Push API resources Open API documentation

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Generator version: 7.6.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.DataDelete: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://push.databox.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**DataDelete**](docs/DefaultApi.md#datadelete) | **DELETE** /data | 
*DefaultApi* | [**DataMetricKeyDelete**](docs/DefaultApi.md#datametrickeydelete) | **DELETE** /data/{metricKey} | 
*DefaultApi* | [**DataPost**](docs/DefaultApi.md#datapost) | **POST** /data | 
*DefaultApi* | [**LastpushesGet**](docs/DefaultApi.md#lastpushesget) | **GET** /lastpushes | 
*DefaultApi* | [**MetrickeysGet**](docs/DefaultApi.md#metrickeysget) | **GET** /metrickeys | 
*DefaultApi* | [**MetrickeysPost**](docs/DefaultApi.md#metrickeyspost) | **POST** /metrickeys | 
*DefaultApi* | [**PingGet**](docs/DefaultApi.md#pingget) | **GET** /ping | 
*DefaultApi* | [**RootPost**](docs/DefaultApi.md#rootpost) | **POST** / | 
*MicroProfileHealthApi* | [**MicroprofileHealthLiveness**](docs/MicroProfileHealthApi.md#microprofilehealthliveness) | **GET** /q/health/live | The Liveness check of this application
*MicroProfileHealthApi* | [**MicroprofileHealthReadiness**](docs/MicroProfileHealthApi.md#microprofilehealthreadiness) | **GET** /q/health/ready | The Readiness check of this application
*MicroProfileHealthApi* | [**MicroprofileHealthRoot**](docs/MicroProfileHealthApi.md#microprofilehealthroot) | **GET** /q/health | An aggregated view of the Liveness and Readiness of this application


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.ApiResponse](docs/ApiResponse.md)
 - [Model.HealthCheckResponse](docs/HealthCheckResponse.md)
 - [Model.PayloadDataModel](docs/PayloadDataModel.md)
 - [Model.PayloadModel](docs/PayloadModel.md)
 - [Model.PushData](docs/PushData.md)
 - [Model.PushDataAttribute](docs/PushDataAttribute.md)
 - [Model.State](docs/State.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="basicAuth"></a>
### basicAuth

- **Type**: HTTP basic authentication

