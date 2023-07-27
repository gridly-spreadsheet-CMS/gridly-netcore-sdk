# Com.Gridly.Api.RecordApi

All URIs are relative to *https://api.gridly.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Create**](RecordApi.md#create) | **POST** /v1/views/{viewId}/records | create |
| [**Delete**](RecordApi.md#delete) | **DELETE** /v1/views/{viewId}/records | delete |
| [**Fetch**](RecordApi.md#fetch) | **GET** /v1/views/{viewId}/records | fetch |
| [**FetchHistories**](RecordApi.md#fetchhistories) | **GET** /v1/views/{viewId}/records/{recordId}/histories | fetchHistories |
| [**Update**](RecordApi.md#update) | **PATCH** /v1/views/{viewId}/records | update |
| [**UpdateRecord**](RecordApi.md#updaterecord) | **PATCH** /v1/views/{viewId}/records/{id} | updateRecord |

<a name="create"></a>
# **Create**
> List&lt;Record&gt; Create (string viewId, List<SetRecord> createRecords)

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

            var apiInstance = new RecordApi(config);
            var viewId = "viewId_example";  // string | viewId
            var createRecords = new List<SetRecord>(); // List<SetRecord> | createRecords

            try
            {
                // create
                List<Record> result = apiInstance.Create(viewId, createRecords);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordApi.Create: " + e.Message);
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
    ApiResponse<List<Record>> response = apiInstance.CreateWithHttpInfo(viewId, createRecords);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **viewId** | **string** | viewId |  |
| **createRecords** | [**List&lt;SetRecord&gt;**](SetRecord.md) | createRecords |  |

### Return type

[**List&lt;Record&gt;**](Record.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> void Delete (string viewId, DeleteRecord deleteRecord)

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

            var apiInstance = new RecordApi(config);
            var viewId = "viewId_example";  // string | viewId
            var deleteRecord = new DeleteRecord(); // DeleteRecord | 

            try
            {
                // delete
                apiInstance.Delete(viewId, deleteRecord);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordApi.Delete: " + e.Message);
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
    apiInstance.DeleteWithHttpInfo(viewId, deleteRecord);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **viewId** | **string** | viewId |  |
| **deleteRecord** | [**DeleteRecord**](DeleteRecord.md) |  |  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fetch"></a>
# **Fetch**
> List&lt;Record&gt; Fetch (string viewId, List<string> columnIds = null, string page = null, string query = null, string sort = null, FetchFileOption? fetchFileOption = null, string afterRecordId = null, string beforeRecordId = null)

fetch

fetch

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class FetchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordApi(config);
            var viewId = "viewId_example";  // string | viewId
            var columnIds = new List<string>(); // List<string> | columnIds (optional) 
            var page = "\"{}\"";  // string | page (optional)  (default to "{}")
            var query = "\"{}\"";  // string | query (optional)  (default to "{}")
            var sort = "\"{}\"";  // string | sort (optional)  (default to "{}")
            var fetchFileOption = (FetchFileOption) "all";  // FetchFileOption? | fetchFileOption (optional) 
            var afterRecordId = "afterRecordId_example";  // string | afterRecordId (optional) 
            var beforeRecordId = "beforeRecordId_example";  // string | beforeRecordId (optional) 

            try
            {
                // fetch
                List<Record> result = apiInstance.Fetch(viewId, columnIds, page, query, sort, fetchFileOption, afterRecordId, beforeRecordId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordApi.Fetch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // fetch
    ApiResponse<List<Record>> response = apiInstance.FetchWithHttpInfo(viewId, columnIds, page, query, sort, fetchFileOption, afterRecordId, beforeRecordId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordApi.FetchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **viewId** | **string** | viewId |  |
| **columnIds** | [**List&lt;string&gt;**](string.md) | columnIds | [optional]  |
| **page** | **string** | page | [optional] [default to &quot;{}&quot;] |
| **query** | **string** | query | [optional] [default to &quot;{}&quot;] |
| **sort** | **string** | sort | [optional] [default to &quot;{}&quot;] |
| **fetchFileOption** | **FetchFileOption?** | fetchFileOption | [optional]  |
| **afterRecordId** | **string** | afterRecordId | [optional]  |
| **beforeRecordId** | **string** | beforeRecordId | [optional]  |

### Return type

[**List&lt;Record&gt;**](Record.md)

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

<a name="fetchhistories"></a>
# **FetchHistories**
> List&lt;RecordHistory&gt; FetchHistories (string viewId, string recordId, string page = null)

fetchHistories

fetchHistories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class FetchHistoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordApi(config);
            var viewId = "viewId_example";  // string | viewId
            var recordId = "recordId_example";  // string | recordId
            var page = "\"{}\"";  // string | page (optional)  (default to "{}")

            try
            {
                // fetchHistories
                List<RecordHistory> result = apiInstance.FetchHistories(viewId, recordId, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordApi.FetchHistories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchHistoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // fetchHistories
    ApiResponse<List<RecordHistory>> response = apiInstance.FetchHistoriesWithHttpInfo(viewId, recordId, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordApi.FetchHistoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **viewId** | **string** | viewId |  |
| **recordId** | **string** | recordId |  |
| **page** | **string** | page | [optional] [default to &quot;{}&quot;] |

### Return type

[**List&lt;RecordHistory&gt;**](RecordHistory.md)

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

<a name="update"></a>
# **Update**
> List&lt;Record&gt; Update (string viewId, List<SetRecord> setRecord)

update

update

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class UpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordApi(config);
            var viewId = "viewId_example";  // string | viewId
            var setRecord = new List<SetRecord>(); // List<SetRecord> | 

            try
            {
                // update
                List<Record> result = apiInstance.Update(viewId, setRecord);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordApi.Update: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update
    ApiResponse<List<Record>> response = apiInstance.UpdateWithHttpInfo(viewId, setRecord);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordApi.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **viewId** | **string** | viewId |  |
| **setRecord** | [**List&lt;SetRecord&gt;**](SetRecord.md) |  |  |

### Return type

[**List&lt;Record&gt;**](Record.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updaterecord"></a>
# **UpdateRecord**
> Record UpdateRecord (string id, string viewId, SetRecord setRecord, string path = null)

updateRecord

updateRecord

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class UpdateRecordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new RecordApi(config);
            var id = "id_example";  // string | id
            var viewId = "viewId_example";  // string | viewId
            var setRecord = new SetRecord(); // SetRecord | 
            var path = "path_example";  // string | path (optional) 

            try
            {
                // updateRecord
                Record result = apiInstance.UpdateRecord(id, viewId, setRecord, path);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RecordApi.UpdateRecord: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRecordWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // updateRecord
    ApiResponse<Record> response = apiInstance.UpdateRecordWithHttpInfo(id, viewId, setRecord, path);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RecordApi.UpdateRecordWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | id |  |
| **viewId** | **string** | viewId |  |
| **setRecord** | [**SetRecord**](SetRecord.md) |  |  |
| **path** | **string** | path | [optional]  |

### Return type

[**Record**](Record.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

