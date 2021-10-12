/*
 * Gridly API
 *
 * Gridly API documentation
 *
 * The version of the OpenAPI document: 3.13.0
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
    ///  Class for testing ViewFileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ViewFileApiTests : IDisposable
    {
        private ViewFileApi instance;

        public ViewFileApiTests()
        {
            instance = new ViewFileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ViewFileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ViewFileApi
            //Assert.IsType<ViewFileApi>(instance);
        }

        /// <summary>
        /// Test Download
        /// </summary>
        [Fact]
        public void DownloadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string fileId = null;
            //string viewId = null;
            //var response = instance.Download(fileId, viewId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test Upload
        /// </summary>
        [Fact]
        public void UploadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //Object columnId = null;
            //System.IO.Stream file = null;
            //Object recordId = null;
            //var response = instance.Upload(viewId, columnId, file, recordId);
            //Assert.IsType<UploadedFile>(response);
        }

        /// <summary>
        /// Test UploadZip
        /// </summary>
        [Fact]
        public void UploadZipTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewId = null;
            //Object columnId = null;
            //Object file = null;
            //var response = instance.UploadZip(viewId, columnId, file);
            //Assert.IsType<List<Record>>(response);
        }
    }
}
