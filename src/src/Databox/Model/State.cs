/*
 * Static OpenAPI document of Push API resource
 *
 * Push API resources Open API documentation
 *
 * The version of the OpenAPI document: 0.4.3
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = Databox.Client.FileParameter;
using OpenAPIDateConverter = Databox.Client.OpenAPIDateConverter;

namespace Databox.Model
{
    /// <summary>
    /// Defines State
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum State
    {
        /// <summary>
        /// Enum DOWN for value: DOWN
        /// </summary>
        [EnumMember(Value = "DOWN")]
        DOWN = 1,

        /// <summary>
        /// Enum UP for value: UP
        /// </summary>
        [EnumMember(Value = "UP")]
        UP = 2
    }

}
