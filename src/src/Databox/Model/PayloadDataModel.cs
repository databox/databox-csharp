/*
 * Static OpenAPI document of Push API resource
 *
 * Push API resources Open API documentation
 *
 * The version of the OpenAPI document: 1.0
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
    /// PayloadDataModel
    /// </summary>
    [DataContract(Name = "PayloadDataModel")]
    public partial class PayloadDataModel : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadDataModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayloadDataModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadDataModel" /> class.
        /// </summary>
        /// <param name="metricName">example metric name would be &#39;$sales&#39;.</param>
        /// <param name="dimensionName">example dimension would be &#39;channel&#39;.</param>
        /// <param name="unit">unit.</param>
        /// <param name="periodFrom">required if date not provided.</param>
        /// <param name="periodTo">required if date not provided.</param>
        /// <param name="date">required periods not provided (required).</param>
        public PayloadDataModel(decimal metricName = default(decimal), string dimensionName = default(string), string unit = default(string), string periodFrom = default(string), string periodTo = default(string), string date = default(string))
        {
            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new ArgumentNullException("date is a required property for PayloadDataModel and cannot be null");
            }
            this.Date = date;
            this.MetricName = metricName;
            this.DimensionName = dimensionName;
            this.Unit = unit;
            this.PeriodFrom = periodFrom;
            this.PeriodTo = periodTo;
        }

        /// <summary>
        /// example metric name would be &#39;$sales&#39;
        /// </summary>
        /// <value>example metric name would be &#39;$sales&#39;</value>
        [DataMember(Name = "$&lt;metric_name&gt;", EmitDefaultValue = false)]
        public decimal MetricName { get; set; }

        /// <summary>
        /// example dimension would be &#39;channel&#39;
        /// </summary>
        /// <value>example dimension would be &#39;channel&#39;</value>
        [DataMember(Name = "&lt;dimension_name&gt;", EmitDefaultValue = false)]
        public string DimensionName { get; set; }

        /// <summary>
        /// Gets or Sets Unit
        /// </summary>
        [DataMember(Name = "unit", EmitDefaultValue = false)]
        public string Unit { get; set; }

        /// <summary>
        /// required if date not provided
        /// </summary>
        /// <value>required if date not provided</value>
        [DataMember(Name = "periodFrom", EmitDefaultValue = false)]
        public string PeriodFrom { get; set; }

        /// <summary>
        /// required if date not provided
        /// </summary>
        /// <value>required if date not provided</value>
        [DataMember(Name = "periodTo", EmitDefaultValue = false)]
        public string PeriodTo { get; set; }

        /// <summary>
        /// required periods not provided
        /// </summary>
        /// <value>required periods not provided</value>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = true)]
        public string Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayloadDataModel {\n");
            sb.Append("  MetricName: ").Append(MetricName).Append("\n");
            sb.Append("  DimensionName: ").Append(DimensionName).Append("\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  PeriodFrom: ").Append(PeriodFrom).Append("\n");
            sb.Append("  PeriodTo: ").Append(PeriodTo).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
