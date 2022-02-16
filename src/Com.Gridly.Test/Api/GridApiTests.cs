/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.21.4
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
    ///  Class for testing GridApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GridApiTests : IDisposable
    {
        private GridApi instance;

        public GridApiTests()
        {
            instance = new GridApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GridApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GridApi
            //Assert.IsType<GridApi>(instance);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //CreateGrid createGrid = null;
            //var response = instance.Create(dbId, createGrid);
            //Assert.IsType<Grid>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //instance.Delete(gridId);
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //var response = instance.Get(gridId);
            //Assert.IsType<Grid>(response);
        }

        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string dbId = null;
            //var response = instance.List(dbId);
            //Assert.IsType<List<Grid>>(response);
        }

        /// <summary>
        /// Test ListTemplateGrids
        /// </summary>
        [Fact]
        public void ListTemplateGridsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListTemplateGrids();
            //Assert.IsType<List<Grid>>(response);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //UpdateGrid updateGrid = null;
            //var response = instance.Update(gridId, updateGrid);
            //Assert.IsType<Grid>(response);
        }
    }
}
