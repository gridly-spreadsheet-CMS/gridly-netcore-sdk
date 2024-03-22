/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.29.1
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
    ///  Class for testing PathApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PathApiTests : IDisposable
    {
        private PathApi instance;

        public PathApiTests()
        {
            instance = new PathApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PathApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PathApi
            //Assert.IsType<PathApi>(instance);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //CreatePath createPath = null;
            //var response = instance.Create(viewId, createPath);
            //Assert.IsType<PathList>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //DeletePath deletePath = null;
            //instance.Delete(viewId, deletePath);
        }

        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //string rootPath = null;
            //var response = instance.List(viewId, rootPath);
            //Assert.IsType<List<PathNode>>(response);
        }

        /// <summary>
        /// Test Move
        /// </summary>
        [Fact]
        public void MoveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //MovePath movePath = null;
            //var response = instance.Move(viewId, movePath);
            //Assert.IsType<PathList>(response);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //string path = null;
            //UpdatePath updatePath = null;
            //var response = instance.Update(viewId, path, updatePath);
            //Assert.IsType<PathSingle>(response);
        }
    }
}
