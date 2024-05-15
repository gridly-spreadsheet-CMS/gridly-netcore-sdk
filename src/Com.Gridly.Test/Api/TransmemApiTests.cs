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
    ///  Class for testing TransmemApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransmemApiTests : IDisposable
    {
        private TransmemApi instance;

        public TransmemApiTests()
        {
            instance = new TransmemApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TransmemApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TransmemApi
            //Assert.IsType<TransmemApi>(instance);
        }

        /// <summary>
        /// Test Cleanup
        /// </summary>
        [Fact]
        public void CleanupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //instance.Cleanup(tmId);
        }

        /// <summary>
        /// Test Create
        /// </summary>
        [Fact]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateTransMem createTransMem = null;
            //var response = instance.Create(createTransMem);
            //Assert.IsType<TransMem>(response);
        }

        /// <summary>
        /// Test CreateWithFile
        /// </summary>
        [Fact]
        public void CreateWithFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream file = null;
            //var response = instance.CreateWithFile(file);
            //Assert.IsType<TransMem>(response);
        }

        /// <summary>
        /// Test Delete
        /// </summary>
        [Fact]
        public void DeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //var response = instance.Delete(tmId);
            //Assert.IsType<TransMem>(response);
        }

        /// <summary>
        /// Test Export
        /// </summary>
        [Fact]
        public void ExportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //ExportFormat? format = null;
            //string sourceLang = null;
            //List<string> targetLangs = null;
            //var response = instance.Export(tmId, format, sourceLang, targetLangs);
            //Assert.IsType<System.IO.Stream>(response);
        }

        /// <summary>
        /// Test Get
        /// </summary>
        [Fact]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //var response = instance.Get(tmId);
            //Assert.IsType<TransMem>(response);
        }

        /// <summary>
        /// Test ImportTmx
        /// </summary>
        [Fact]
        public void ImportTmxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //Object file = null;
            //instance.ImportTmx(tmId, file);
        }

        /// <summary>
        /// Test ListTM
        /// </summary>
        [Fact]
        public void ListTMTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? projectId = null;
            //var response = instance.ListTM(projectId);
            //Assert.IsType<List<TransMem>>(response);
        }

        /// <summary>
        /// Test Update
        /// </summary>
        [Fact]
        public void UpdateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string tmId = null;
            //UpdateTransMem updateTransMem = null;
            //var response = instance.Update(tmId, updateTransMem);
            //Assert.IsType<TransMem>(response);
        }
    }
}
