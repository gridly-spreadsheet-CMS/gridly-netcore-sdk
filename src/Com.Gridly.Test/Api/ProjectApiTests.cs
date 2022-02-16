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
    ///  Class for testing ProjectApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProjectApiTests : IDisposable
    {
        private ProjectApi instance;

        public ProjectApiTests()
        {
            instance = new ProjectApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProjectApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProjectApi
            //Assert.IsType<ProjectApi>(instance);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateProject createProject = null;
            //var response = instance.Create(createProject);
            //Assert.IsType<Project>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //instance.Delete(projectId);
        }

        /// <summary>
        /// Test FindOne
        /// </summary>
        [Fact]
        public void FindOneTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //var response = instance.FindOne(projectId);
            //Assert.IsType<ProjectDetail>(response);
        }

        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.List();
            //Assert.IsType<List<Project>>(response);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long projectId = null;
            //UpdateProject updateProject = null;
            //var response = instance.Update(projectId, updateProject);
            //Assert.IsType<Project>(response);
        }
    }
}
