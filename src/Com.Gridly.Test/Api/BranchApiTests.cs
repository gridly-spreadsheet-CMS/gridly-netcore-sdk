/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 4.33.0
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
    ///  Class for testing BranchApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class BranchApiTests : IDisposable
    {
        private BranchApi instance;

        public BranchApiTests()
        {
            instance = new BranchApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of BranchApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' BranchApi
            //Assert.IsType<BranchApi>(instance);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBranch createBranch = null;
            //string gridId = null;
            //string branchId = null;
            //var response = instance.Create(createBranch, gridId, branchId);
            //Assert.IsType<Branch>(response);
        }

        /// <summary>
        /// Test CreateDiffCheck
        /// </summary>
        [Fact]
        public void CreateDiffCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string sourceViewId = null;
            //string destinationViewId = null;
            //var response = instance.CreateDiffCheck(sourceViewId, destinationViewId);
            //Assert.IsType<Task>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string branchId = null;
            //instance.Delete(branchId);
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string branchId = null;
            //var response = instance.Get(branchId);
            //Assert.IsType<Branch>(response);
        }

        /// <summary>
        /// Test GetDiffCheck
        /// </summary>
        [Fact]
        public void GetDiffCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string taskId = null;
            //List<string> mergeRecordOptions = null;
            //string query = null;
            //string page = null;
            //var response = instance.GetDiffCheck(taskId, mergeRecordOptions, query, page);
            //Assert.IsType<List<BranchDiffRecord>>(response);
        }

        /// <summary>
        /// Test List
        /// </summary>
        [Fact]
        public void ListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string gridId = null;
            //var response = instance.List(gridId);
            //Assert.IsType<List<Branch>>(response);
        }

        /// <summary>
        /// Test Merge
        /// </summary>
        [Fact]
        public void MergeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string branchId = null;
            //string destinationBranchId = null;
            //MergeBranchRequest mergeBranchRequest = null;
            //List<string> mergeRecordOptions = null;
            //var response = instance.Merge(branchId, destinationBranchId, mergeBranchRequest, mergeRecordOptions);
            //Assert.IsType<Task>(response);
        }
    }
}
