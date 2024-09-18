## Databox

This package is designed to consume the Databox Push API functionality via .NET based client.

Supported .NET versions: .NET 6.0 and later.

## Installation

The package is listed as **public** in our Databox Github repository. In order to consume it, you must first add a **nuget source**.

Databox package repository url is: https://nuget.pkg.github.com/databox/index.json

Detail instructions on how to add this to your project is available [here](https://docs.github.com/en/packages/working-with-a-github-packages-registry/working-with-the-nuget-registry).

After this is completed, the package can be installed via IDE (package named **"Databox"**) or via **dotnet cli** command

```
dotnet add package Databox --version <version>
```

### Prerequisites

In use the Databox Push API functionality, please refer to [Databox Developers Page](https://developers.databox.com/), specifically the **Quick Guide** section, where you will learn how to create a **Databox Push API token** which is required for pushing your data.

### Example

The basic example of pushing data to Databox is provided below:

```csharp
using System.Diagnostics;
using Databox.Api;
using Databox.Client;
using Databox.Model;

namespace Example
{
  public class Example
  {
    public static async Task Main(string[] args)
    {

      Configuration config = new Configuration();
      config.BasePath = "https://push.databox.com";
      config.Username = "<Your_Databox_API_Token>";
      config.DefaultHeaders.Add("Accept", "application/vnd.databox.v2+json");


      HttpClient httpClient = new HttpClient();
      HttpClientHandler httpClientHandler = new HttpClientHandler();
      var apiInstance = new DefaultApi(httpClient, config, httpClientHandler);
      var dataPostRequest = new List<PushData>() {
        new PushData() {
          Key = "<Metric_name>",
          Value = 123,
          Date = "<Date_in_ISO8601>",
          Unit = "<Unit>", // Optional
          Attributes = new List<PushDataAttribute>() { // Optional
            new PushDataAttribute() {
              Key = "<Dimension_name>",
              Value = "<Dimension_value>"
            }
          }
        }
      };

      try
      {
        var response = await apiInstance.DataPostWithHttpInfoAsync(dataPostRequest);
        Console.WriteLine(response.Data.ToString());
      }
      catch (ApiException e)
      {
        Console.WriteLine("Exception when calling DefaultApi.DataPostWithHttpInfo: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);
      }
    }
  }
}
```
