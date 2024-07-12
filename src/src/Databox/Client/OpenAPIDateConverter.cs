/*
 * Static OpenAPI document of Push API resource
 *
 * Push API resources Open API documentation
 *
 * The version of the OpenAPI document: 0.4.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace Databox.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
