/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.22.0
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
    ///  Class for testing ViewDependencyApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewDependencyApiTests : IDisposable
    {
        private ViewDependencyApi instance;

        public ViewDependencyApiTests()
        {
            instance = new ViewDependencyApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ViewDependencyApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ViewDependencyApi
            //Assert.IsType<ViewDependencyApi>(instance);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //CreateDependency createDependency = null;
            //var response = instance.Create(viewId, createDependency);
            //Assert.IsType<Dependency>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //DeleteDependency deleteDependency = null;
            //instance.Delete(viewId, deleteDependency);
        }

        /// <summary>
        /// Test Delete_0
        /// </summary>
        [Fact]
        public void Delete_0Test()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dependencyId = null;
            //string viewId = null;
            //instance.Delete_0(dependencyId, viewId);
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dependencyId = null;
            //string viewId = null;
            //var response = instance.Get(dependencyId, viewId);
            //Assert.IsType<Dependency>(response);
        }

        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //var response = instance.List(viewId);
            //Assert.IsType<List<Dependency>>(response);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dependencyId = null;
            //string viewId = null;
            //UpdateDependency updateDependency = null;
            //var response = instance.Update(dependencyId, viewId, updateDependency);
            //Assert.IsType<Dependency>(response);
        }
    }
}
