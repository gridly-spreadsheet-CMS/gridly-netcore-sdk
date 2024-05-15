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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Com.Gridly.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShareViewApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// create
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ShareView</returns>
        ShareView Create(string viewId, CreateShareView createShareView, int operationIndex = 0);

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// create
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ShareView</returns>
        ApiResponse<ShareView> CreateWithHttpInfo(string viewId, CreateShareView createShareView, int operationIndex = 0);
        /// <summary>
        /// delete
        /// </summary>
        /// <remarks>
        /// delete
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        void Delete(string viewId, int operationIndex = 0);

        /// <summary>
        /// delete
        /// </summary>
        /// <remarks>
        /// delete
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteWithHttpInfo(string viewId, int operationIndex = 0);
        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// get
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ShareView</returns>
        ShareView Get(string viewId, int operationIndex = 0);

        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// get
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ShareView</returns>
        ApiResponse<ShareView> GetWithHttpInfo(string viewId, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShareViewApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// create
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShareView</returns>
        System.Threading.Tasks.Task<ShareView> CreateAsync(string viewId, CreateShareView createShareView, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// create
        /// </summary>
        /// <remarks>
        /// create
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShareView)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShareView>> CreateWithHttpInfoAsync(string viewId, CreateShareView createShareView, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// delete
        /// </summary>
        /// <remarks>
        /// delete
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// delete
        /// </summary>
        /// <remarks>
        /// delete
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteWithHttpInfoAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// get
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShareView</returns>
        System.Threading.Tasks.Task<ShareView> GetAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// get
        /// </summary>
        /// <remarks>
        /// get
        /// </remarks>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShareView)</returns>
        System.Threading.Tasks.Task<ApiResponse<ShareView>> GetWithHttpInfoAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShareViewApi : IShareViewApiSync, IShareViewApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShareViewApi : IShareViewApi
    {
        private Com.Gridly.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareViewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShareViewApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareViewApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShareViewApi(string basePath)
        {
            this.Configuration = Com.Gridly.Client.Configuration.MergeConfigurations(
                Com.Gridly.Client.GlobalConfiguration.Instance,
                new Com.Gridly.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Com.Gridly.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Gridly.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Com.Gridly.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareViewApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShareViewApi(Com.Gridly.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Com.Gridly.Client.Configuration.MergeConfigurations(
                Com.Gridly.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Com.Gridly.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Gridly.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Com.Gridly.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareViewApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ShareViewApi(Com.Gridly.Client.ISynchronousClient client, Com.Gridly.Client.IAsynchronousClient asyncClient, Com.Gridly.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Com.Gridly.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Com.Gridly.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Com.Gridly.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Com.Gridly.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.Gridly.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// create create
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ShareView</returns>
        public ShareView Create(string viewId, CreateShareView createShareView, int operationIndex = 0)
        {
            Com.Gridly.Client.ApiResponse<ShareView> localVarResponse = CreateWithHttpInfo(viewId, createShareView);
            return localVarResponse.Data;
        }

        /// <summary>
        /// create create
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ShareView</returns>
        public Com.Gridly.Client.ApiResponse<ShareView> CreateWithHttpInfo(string viewId, CreateShareView createShareView, int operationIndex = 0)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'viewId' when calling ShareViewApi->Create");
            }

            // verify the required parameter 'createShareView' is set
            if (createShareView == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'createShareView' when calling ShareViewApi->Create");
            }

            Com.Gridly.Client.RequestOptions localVarRequestOptions = new Com.Gridly.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Gridly.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Gridly.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("viewId", Com.Gridly.Client.ClientUtils.ParameterToString(viewId)); // path parameter
            localVarRequestOptions.Data = createShareView;

            localVarRequestOptions.Operation = "ShareViewApi.Create";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Put<ShareView>("/v1/views/{viewId}/shares", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// create create
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShareView</returns>
        public async System.Threading.Tasks.Task<ShareView> CreateAsync(string viewId, CreateShareView createShareView, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Gridly.Client.ApiResponse<ShareView> localVarResponse = await CreateWithHttpInfoAsync(viewId, createShareView, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// create create
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="createShareView"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShareView)</returns>
        public async System.Threading.Tasks.Task<Com.Gridly.Client.ApiResponse<ShareView>> CreateWithHttpInfoAsync(string viewId, CreateShareView createShareView, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'viewId' when calling ShareViewApi->Create");
            }

            // verify the required parameter 'createShareView' is set
            if (createShareView == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'createShareView' when calling ShareViewApi->Create");
            }


            Com.Gridly.Client.RequestOptions localVarRequestOptions = new Com.Gridly.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Gridly.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Gridly.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("viewId", Com.Gridly.Client.ClientUtils.ParameterToString(viewId)); // path parameter
            localVarRequestOptions.Data = createShareView;

            localVarRequestOptions.Operation = "ShareViewApi.Create";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PutAsync<ShareView>("/v1/views/{viewId}/shares", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Create", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// delete delete
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns></returns>
        public void Delete(string viewId, int operationIndex = 0)
        {
            DeleteWithHttpInfo(viewId);
        }

        /// <summary>
        /// delete delete
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Com.Gridly.Client.ApiResponse<Object> DeleteWithHttpInfo(string viewId, int operationIndex = 0)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'viewId' when calling ShareViewApi->Delete");
            }

            Com.Gridly.Client.RequestOptions localVarRequestOptions = new Com.Gridly.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Com.Gridly.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Gridly.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("viewId", Com.Gridly.Client.ClientUtils.ParameterToString(viewId)); // path parameter

            localVarRequestOptions.Operation = "ShareViewApi.Delete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Delete<Object>("/v1/views/{viewId}/shares", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// delete delete
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await DeleteWithHttpInfoAsync(viewId, operationIndex, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// delete delete
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Com.Gridly.Client.ApiResponse<Object>> DeleteWithHttpInfoAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'viewId' when calling ShareViewApi->Delete");
            }


            Com.Gridly.Client.RequestOptions localVarRequestOptions = new Com.Gridly.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
            };

            var localVarContentType = Com.Gridly.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Gridly.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("viewId", Com.Gridly.Client.ClientUtils.ParameterToString(viewId)); // path parameter

            localVarRequestOptions.Operation = "ShareViewApi.Delete";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.DeleteAsync<Object>("/v1/views/{viewId}/shares", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Delete", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get get
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ShareView</returns>
        public ShareView Get(string viewId, int operationIndex = 0)
        {
            Com.Gridly.Client.ApiResponse<ShareView> localVarResponse = GetWithHttpInfo(viewId);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get get
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of ShareView</returns>
        public Com.Gridly.Client.ApiResponse<ShareView> GetWithHttpInfo(string viewId, int operationIndex = 0)
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'viewId' when calling ShareViewApi->Get");
            }

            Com.Gridly.Client.RequestOptions localVarRequestOptions = new Com.Gridly.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Gridly.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Gridly.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("viewId", Com.Gridly.Client.ClientUtils.ParameterToString(viewId)); // path parameter

            localVarRequestOptions.Operation = "ShareViewApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<ShareView>("/v1/views/{viewId}/shares", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// get get
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ShareView</returns>
        public async System.Threading.Tasks.Task<ShareView> GetAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Gridly.Client.ApiResponse<ShareView> localVarResponse = await GetWithHttpInfoAsync(viewId, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// get get
        /// </summary>
        /// <exception cref="Com.Gridly.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="viewId">viewId</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ShareView)</returns>
        public async System.Threading.Tasks.Task<Com.Gridly.Client.ApiResponse<ShareView>> GetWithHttpInfoAsync(string viewId, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'viewId' is set
            if (viewId == null)
            {
                throw new Com.Gridly.Client.ApiException(400, "Missing required parameter 'viewId' when calling ShareViewApi->Get");
            }


            Com.Gridly.Client.RequestOptions localVarRequestOptions = new Com.Gridly.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Com.Gridly.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Com.Gridly.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("viewId", Com.Gridly.Client.ClientUtils.ParameterToString(viewId)); // path parameter

            localVarRequestOptions.Operation = "ShareViewApi.Get";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (ApiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<ShareView>("/v1/views/{viewId}/shares", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Get", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
