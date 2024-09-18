﻿using System.Diagnostics;
using Databox.Api;
using Databox.Client;
using Databox.Model;

namespace Example {
  public class Example {
    public static void Main () {

      Configuration config = new Configuration ();
      config.BasePath = "https://push.databox.com";
      config.Username = "03f3b8668c01423b9154a247defacee5";
      config.DefaultHeaders.Add("Accept", "application/vnd.databox.v2+json");


      HttpClient httpClient = new HttpClient ();
      HttpClientHandler httpClientHandler = new HttpClientHandler ();
      var apiInstance = new DefaultApi (httpClient, config, httpClientHandler);
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

      try {
        var response = apiInstance.DataPostWithHttpInfo(dataPostRequest);
        Console.WriteLine(response.Data.ToString());
      } catch (ApiException e) {
        Console.WriteLine("Exception when calling DefaultApi.DataPostWithHttpInfo: " + e.Message);
        Console.WriteLine("Status Code: " + e.ErrorCode);
        Console.WriteLine(e.StackTrace);
      }
    }
  }
}