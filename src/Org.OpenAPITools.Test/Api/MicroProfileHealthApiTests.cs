/*
 * Static OpenAPI document of Push API resource
 *
 * Push API resources Open API documentation
 *
 * The version of the OpenAPI document: 1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing MicroProfileHealthApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MicroProfileHealthApiTests : IDisposable
    {
        private MicroProfileHealthApi instance;

        public MicroProfileHealthApiTests()
        {
            instance = new MicroProfileHealthApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MicroProfileHealthApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MicroProfileHealthApi
            //Assert.IsType<MicroProfileHealthApi>(instance);
        }

        /// <summary>
        /// Test MicroprofileHealthLiveness
        /// </summary>
        [Fact]
        public void MicroprofileHealthLivenessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MicroprofileHealthLiveness();
            //Assert.IsType<HealthCheckResponse>(response);
        }

        /// <summary>
        /// Test MicroprofileHealthReadiness
        /// </summary>
        [Fact]
        public void MicroprofileHealthReadinessTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MicroprofileHealthReadiness();
            //Assert.IsType<HealthCheckResponse>(response);
        }

        /// <summary>
        /// Test MicroprofileHealthRoot
        /// </summary>
        [Fact]
        public void MicroprofileHealthRootTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.MicroprofileHealthRoot();
            //Assert.IsType<HealthCheckResponse>(response);
        }
    }
}
