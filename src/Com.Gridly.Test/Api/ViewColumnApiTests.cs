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
    ///  Class for testing ViewColumnApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewColumnApiTests : IDisposable
    {
        private ViewColumnApi instance;

        public ViewColumnApiTests()
        {
            instance = new ViewColumnApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ViewColumnApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ViewColumnApi
            //Assert.IsType<ViewColumnApi>(instance);
        }

        /// <summary>
        /// Test Add
        /// </summary>
        [Fact]
        public void AddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //var response = instance.Add(columnId, viewId);
            //Assert.IsType<ViewColumn>(response);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //CreateColumn createColumn = null;
            //var response = instance.Create(viewId, createColumn);
            //Assert.IsType<ViewColumn>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //instance.Delete(columnId, viewId);
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //var response = instance.Get(columnId, viewId);
            //Assert.IsType<ViewColumn>(response);
        }

        /// <summary>
        /// Test Remove
        /// </summary>
        [Fact]
        public void RemoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //instance.Remove(columnId, viewId);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string columnId = null;
            //string viewId = null;
            //UpdateColumn updateColumn = null;
            //var response = instance.Update(columnId, viewId, updateColumn);
            //Assert.IsType<ViewColumn>(response);
        }
    }
}
