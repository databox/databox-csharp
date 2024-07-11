/*
 * Static OpenAPI document of Push API resource
 *
 * Push API resources Open API documentation
 *
 * The version of the OpenAPI document: 0.4.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Xunit;

using Databox.Client;
using Databox.Api;
// uncomment below to import models
//using Databox.Model;

namespace Databox.Test.Api
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private DefaultApi instance;

        public DefaultApiTests()
        {
            instance = new DefaultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DefaultApi
            //Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test DataDelete
        /// </summary>
        [Fact]
        public void DataDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.DataDelete();
        }

        /// <summary>
        /// Test DataMetricKeyDelete
        /// </summary>
        [Fact]
        public void DataMetricKeyDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string metricKey = null;
            //instance.DataMetricKeyDelete(metricKey);
        }

        /// <summary>
        /// Test DataPost
        /// </summary>
        [Fact]
        public void DataPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<PushData>? pushData = null;
            //instance.DataPost(pushData);
        }

        /// <summary>
        /// Test MetrickeysGet
        /// </summary>
        [Fact]
        public void MetrickeysGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.MetrickeysGet();
        }

        /// <summary>
        /// Test MetrickeysPost
        /// </summary>
        [Fact]
        public void MetrickeysPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object? body = null;
            //instance.MetrickeysPost(body);
        }

        /// <summary>
        /// Test PingGet
        /// </summary>
        [Fact]
        public void PingGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.PingGet();
        }
    }
}
