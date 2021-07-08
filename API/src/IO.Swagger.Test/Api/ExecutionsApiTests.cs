/* 
 * FIXServer - API
 *
 * Open API for FIXServer integrations.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ExecutionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExecutionsApiTests
    {
        private ExecutionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExecutionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExecutionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ExecutionsApi
            //Assert.IsInstanceOfType(typeof(ExecutionsApi), instance, "instance is a ExecutionsApi");
        }

        /// <summary>
        /// Test V1ExecutionsExecutionsInInstanceSessionClordidGet
        /// </summary>
        [Test]
        public void V1ExecutionsExecutionsInInstanceSessionClordidGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string instance = null;
            //string session = null;
            //string clordid = null;
            //var response = instance.V1ExecutionsExecutionsInInstanceSessionClordidGet(instance, session, clordid);
            //Assert.IsInstanceOf<List<ExecutionDetails>> (response, "response is List<ExecutionDetails>");
        }
    }

}