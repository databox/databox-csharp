/*
 * Static OpenAPI document of Push API resource
 *
 * Push API resources Open API documentation
 *
 * The version of the OpenAPI document: 0.4.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;

namespace Databox.Client
{
    /// <summary>
    /// A URI builder
    /// </summary>
    class WebRequestPathBuilder
    {
            private string _baseUrl;
            private string _path;
            private string _query = "?";
            public WebRequestPathBuilder(string baseUrl, string path)
            {
                _baseUrl = baseUrl;
                _path = path;
            }

            public void AddPathParameters(Dictionary<string, string> parameters)
            {
                foreach (var parameter in parameters)
                {
                    _path = _path.Replace("{" + parameter.Key + "}", Uri.EscapeDataString(parameter.Value));
                }
            }

            public void AddQueryParameters(Multimap<string, string> parameters)
            {
                foreach (var parameter in parameters)
                {
                    foreach (var value in parameter.Value)
                    {
                        _query = _query + parameter.Key + "=" + Uri.EscapeDataString(value) + "&";
                    }
                }
            }

            public string GetFullUri()
            {
                return _baseUrl + _path + _query.Substring(0, _query.Length - 1);
            }
    }
}
