/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.15.1
 * Contact: support@gridly.com
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

using Com.Gridly.Client;
using Com.Gridly.Api;
// uncomment below to import models
//using Com.Gridly.Model;

namespace Com.Gridly.Test.Api
{
    /// <summary>
    ///  Class for testing DatabaseApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DatabaseApiTests : IDisposable
    {
        private DatabaseApi instance;

        public DatabaseApiTests()
        {
            instance = new DatabaseApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DatabaseApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DatabaseApi
            //Assert.IsType<DatabaseApi>(instance);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //CreateDatabase body = null;
            //var response = instance.Create(projectId, body);
            //Assert.IsType<Database>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //instance.Delete(dbId);
        }

        /// <summary>
        /// Test Duplicate
        /// </summary>
        [Fact]
        public void DuplicateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //long projectId = null;
            //CreateDatabase body = null;
            //var response = instance.Duplicate(dbId, projectId, body);
            //Assert.IsType<Database>(response);
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //var response = instance.Get(dbId);
            //Assert.IsType<Database>(response);
        }

        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> expand = null;
            //string page = null;
            //long? projectId = null;
            //string search = null;
            //string sort = null;
            //var response = instance.List(expand, page, projectId, search, sort);
            //Assert.IsType<List<Database>>(response);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //UpdateDatabase body = null;
            //var response = instance.Update(dbId, body);
            //Assert.IsType<Database>(response);
        }
    }
}
