/*
 * Lagrello API
 *
 * API specification for Lagrello, a simple to use authentication service
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@lagrello.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using lagrello.Client;
using lagrello.Api;
using lagrello.Model;

namespace lagrello.Test
{
    /// <summary>
    ///  Class for testing InternalApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InternalApiTests
    {
        private InternalApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new InternalApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of InternalApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOf' InternalApi
            //Assert.IsInstanceOf(typeof(InternalApi), instance);
        }

        
        /// <summary>
        /// Test TenantsCardtoken
        /// </summary>
        [Test]
        public void TenantsCardtokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.TenantsCardtoken();
            //Assert.IsInstanceOf(typeof(string), response, "response is string");
        }
        
    }

}
