# Com.Gridly.Api.ViewApi

All URIs are relative to *https://api.gridly.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Export**](ViewApi.md#export) | **GET** /v1/views/{viewId}/export | export
[**Get**](ViewApi.md#get) | **GET** /v1/views/{viewId} | get
[**ImportView**](ViewApi.md#importview) | **POST** /v1/views/{viewId}/import | importView
[**List**](ViewApi.md#list) | **GET** /v1/views | list


<a name="export"></a>
# **Export**
> Object Export (string viewId, List<string> columnIds = null, string query = null, string sort = null, string type = null)

export

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewApi(config);
            var viewId = viewId_example;  // string | viewId
            var columnIds = new List<string>(); // List<string> | columnIds (optional) 
            var query = query_example;  // string | query (optional)  (default to "{}")
            var sort = sort_example;  // string | sort (optional)  (default to "{}")
            var type = type_example;  // string | type (optional)  (default to csv)

            try
            {
                // export
                Object result = apiInstance.Export(viewId, columnIds, query, sort, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.Export: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewId** | **string**| viewId | 
 **columnIds** | [**List&lt;string&gt;**](string.md)| columnIds | [optional] 
 **query** | **string**| query | [optional] [default to &quot;{}&quot;]
 **sort** | **string**| sort | [optional] [default to &quot;{}&quot;]
 **type** | **string**| type | [optional] [default to csv]

### Return type

**Object**

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> View Get (string viewId, List<string> columnIds = null, List<string> include = null, string page = null, string query = null, string sort = null)

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

            var apiInstance = new ViewApi(config);
            var viewId = viewId_example;  // string | viewId
            var columnIds = new List<string>(); // List<string> | columnIds (optional) 
            var include = include_example;  // List<string> | include (optional) 
            var page = page_example;  // string | page (optional)  (default to "{}")
            var query = query_example;  // string | query (optional)  (default to "{}")
            var sort = sort_example;  // string | sort (optional)  (default to "{}")

            try
            {
                // get
                View result = apiInstance.Get(viewId, columnIds, include, page, query, sort);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.Get: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewId** | **string**| viewId | 
 **columnIds** | [**List&lt;string&gt;**](string.md)| columnIds | [optional] 
 **include** | **List&lt;string&gt;**| include | [optional] 
 **page** | **string**| page | [optional] [default to &quot;{}&quot;]
 **query** | **string**| query | [optional] [default to &quot;{}&quot;]
 **sort** | **string**| sort | [optional] [default to &quot;{}&quot;]

### Return type

[**View**](View.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="importview"></a>
# **ImportView**
> void ImportView (string viewId, System.IO.Stream file, Object importRequest = null, Object type = null)

importView

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ImportViewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ViewApi(config);
            var viewId = viewId_example;  // string | viewId
            var file = BINARY_DATA_HERE;  // System.IO.Stream | The following file types are supported: csv, tsv, xls, xlsx and JSON
            var importRequest = new Object(); // Object | importRequest (optional) 
            var type = new Object(); // Object | type (optional) 

            try
            {
                // importView
                apiInstance.ImportView(viewId, file, importRequest, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.ImportView: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **viewId** | **string**| viewId | 
 **file** | **System.IO.Stream****System.IO.Stream**| The following file types are supported: csv, tsv, xls, xlsx and JSON | 
 **importRequest** | [**Object**](Object.md)| importRequest | [optional] 
 **type** | [**Object**](Object.md)| type | [optional] 

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **202** | Accepted |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="list"></a>
# **List**
> List&lt;View&gt; List (string branchId = null, string gridId = null, string type = null)

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

            var apiInstance = new ViewApi(config);
            var branchId = branchId_example;  // string | branchId (optional) 
            var gridId = gridId_example;  // string | gridId (optional) 
            var type = type_example;  // string | type (optional) 

            try
            {
                // list
                List<View> result = apiInstance.List(branchId, gridId, type);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ViewApi.List: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **branchId** | **string**| branchId | [optional] 
 **gridId** | **string**| gridId | [optional] 
 **type** | **string**| type | [optional] 

### Return type

[**List&lt;View&gt;**](View.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Unauthorized |  -  |
| **403** | Forbidden |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

