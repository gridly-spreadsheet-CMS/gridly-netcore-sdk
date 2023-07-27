# Com.Gridly.Api.BranchApi

All URIs are relative to *https://api.gridly.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](BranchApi.md#create) | **POST** /v1/branches | create |
| [**Delete**](BranchApi.md#delete) | **DELETE** /v1/branches/{branchId} | delete |
| [**Get**](BranchApi.md#get) | **GET** /v1/branches/{branchId} | get |
| [**List**](BranchApi.md#list) | **GET** /v1/branches | list |
| [**Merge**](BranchApi.md#merge) | **POST** /v1/branches/{branchId}/merge | merge |

<a name="create"></a>
# **Create**
> Branch Create (CreateBranch createBranch, string gridId = null, string branchId = null)

create

create

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class CreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(config);
            var createBranch = new CreateBranch(); // CreateBranch | 
            var gridId = "gridId_example";  // string | gridId (optional) 
            var branchId = "branchId_example";  // string | branchId (optional) 

            try
            {
                // create
                Branch result = apiInstance.Create(createBranch, gridId, branchId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BranchApi.Create: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // create
    ApiResponse<Branch> response = apiInstance.CreateWithHttpInfo(createBranch, gridId, branchId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BranchApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createBranch** | [**CreateBranch**](CreateBranch.md) |  |  |
| **gridId** | **string** | gridId | [optional]  |
| **branchId** | **string** | branchId | [optional]  |

### Return type

[**Branch**](Branch.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string branchId)

delete

delete

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class DeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(config);
            var branchId = "branchId_example";  // string | branchId

            try
            {
                // delete
                apiInstance.Delete(branchId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BranchApi.Delete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete
    apiInstance.DeleteWithHttpInfo(branchId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BranchApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **branchId** | **string** | branchId |  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> Branch Get (string branchId)

get

get

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class GetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(config);
            var branchId = "branchId_example";  // string | branchId

            try
            {
                // get
                Branch result = apiInstance.Get(branchId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BranchApi.Get: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get
    ApiResponse<Branch> response = apiInstance.GetWithHttpInfo(branchId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BranchApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **branchId** | **string** | branchId |  |

### Return type

[**Branch**](Branch.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> List&lt;Branch&gt; List (string gridId)

list

list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(config);
            var gridId = "gridId_example";  // string | gridId

            try
            {
                // list
                List<Branch> result = apiInstance.List(gridId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BranchApi.List: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // list
    ApiResponse<List<Branch>> response = apiInstance.ListWithHttpInfo(gridId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BranchApi.ListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **gridId** | **string** | gridId |  |

### Return type

[**List&lt;Branch&gt;**](Branch.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="merge"></a>
# **Merge**
> Task Merge (string branchId, string destinationBranchId, List<string> mergeRecordOptions = null)

merge

merge

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class MergeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BranchApi(config);
            var branchId = "branchId_example";  // string | branchId
            var destinationBranchId = "destinationBranchId_example";  // string | destinationBranchId
            var mergeRecordOptions = new List<string>(); // List<string> | mergeRecordOptions (optional) 

            try
            {
                // merge
                Task result = apiInstance.Merge(branchId, destinationBranchId, mergeRecordOptions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BranchApi.Merge: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MergeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // merge
    ApiResponse<Task> response = apiInstance.MergeWithHttpInfo(branchId, destinationBranchId, mergeRecordOptions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BranchApi.MergeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **branchId** | **string** | branchId |  |
| **destinationBranchId** | **string** | destinationBranchId |  |
| **mergeRecordOptions** | [**List&lt;string&gt;**](string.md) | mergeRecordOptions | [optional]  |

### Return type

[**Task**](Task.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

