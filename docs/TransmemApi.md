# Com.Gridly.Api.TransmemApi

All URIs are relative to *https://api.gridly.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**Cleanup**](TransmemApi.md#cleanup) | **PUT** /v1/transmems/{tmId}/cleanup | Erases all the translation data of the provided tmId |
| [**Create**](TransmemApi.md#create) | **POST** /v1/transmems | Create a new translation memory |
| [**CreateWithFile**](TransmemApi.md#createwithfile) | **POST** /v1/transmems/upload | Create a new translation memory by uploading tmx file |
| [**Delete**](TransmemApi.md#delete) | **DELETE** /v1/transmems/{tmId} | Delete a translation memory by id |
| [**Export**](TransmemApi.md#export) | **GET** /v1/transmems/{tmId}/export | Export translation memory tmx file |
| [**Get**](TransmemApi.md#get) | **GET** /v1/transmems/{tmId} | Get translation memory info by id |
| [**ImportTmx**](TransmemApi.md#importtmx) | **POST** /v1/transmems/{tmId}/import | Import a translation memory from tmx file |
| [**ListTM**](TransmemApi.md#listtm) | **GET** /v1/transmems | List all available translation memories or create default one if there is no translation memory |
| [**Update**](TransmemApi.md#update) | **PUT** /v1/transmems/{tmId} | Update a translation memory |

<a name="cleanup"></a>
# **Cleanup**
> void Cleanup (string tmId)

Erases all the translation data of the provided tmId

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class CleanupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransmemApi(config);
            var tmId = "tmId_example";  // string | 

            try
            {
                // Erases all the translation data of the provided tmId
                apiInstance.Cleanup(tmId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.Cleanup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CleanupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Erases all the translation data of the provided tmId
    apiInstance.CleanupWithHttpInfo(tmId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.CleanupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tmId** | **string** |  |  |

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

<a name="create"></a>
# **Create**
> TransMem Create (CreateTransMem createTransMem = null)

Create a new translation memory

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

            var apiInstance = new TransmemApi(config);
            var createTransMem = new CreateTransMem(); // CreateTransMem |  (optional) 

            try
            {
                // Create a new translation memory
                TransMem result = apiInstance.Create(createTransMem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.Create: " + e.Message);
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
    // Create a new translation memory
    ApiResponse<TransMem> response = apiInstance.CreateWithHttpInfo(createTransMem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.CreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTransMem** | [**CreateTransMem**](CreateTransMem.md) |  | [optional]  |

### Return type

[**TransMem**](TransMem.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a new translation memory successful ! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createwithfile"></a>
# **CreateWithFile**
> TransMem CreateWithFile (System.IO.Stream file)

Create a new translation memory by uploading tmx file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class CreateWithFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransmemApi(config);
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Create a new translation memory by uploading tmx file
                TransMem result = apiInstance.CreateWithFile(file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.CreateWithFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateWithFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new translation memory by uploading tmx file
    ApiResponse<TransMem> response = apiInstance.CreateWithFileWithHttpInfo(file);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.CreateWithFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |

### Return type

[**TransMem**](TransMem.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Create a new translation memory based on provided tmx file successfully ! |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="delete"></a>
# **Delete**
> TransMem Delete (string tmId)

Delete a translation memory by id

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

            var apiInstance = new TransmemApi(config);
            var tmId = "tmId_example";  // string | 

            try
            {
                // Delete a translation memory by id
                TransMem result = apiInstance.Delete(tmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.Delete: " + e.Message);
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
    // Delete a translation memory by id
    ApiResponse<TransMem> response = apiInstance.DeleteWithHttpInfo(tmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.DeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tmId** | **string** |  |  |

### Return type

[**TransMem**](TransMem.md)

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

<a name="export"></a>
# **Export**
> System.IO.Stream Export (string tmId, ExportFormat? format = null, string sourceLang = null, List<string> targetLangs = null)

Export translation memory tmx file

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

            var apiInstance = new TransmemApi(config);
            var tmId = "tmId_example";  // string | 
            var format = new ExportFormat();  // ExportFormat? |  (optional) 
            var sourceLang = "sourceLang_example";  // string |  (optional) 
            var targetLangs = new List<string>(); // List<string> |  (optional) 

            try
            {
                // Export translation memory tmx file
                System.IO.Stream result = apiInstance.Export(tmId, format, sourceLang, targetLangs);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.Export: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Export translation memory tmx file
    ApiResponse<System.IO.Stream> response = apiInstance.ExportWithHttpInfo(tmId, format, sourceLang, targetLangs);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.ExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tmId** | **string** |  |  |
| **format** | **ExportFormat?** |  | [optional]  |
| **sourceLang** | **string** |  | [optional]  |
| **targetLangs** | [**List&lt;string&gt;**](string.md) |  | [optional]  |

### Return type

**System.IO.Stream**

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/octet-stream


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> TransMem Get (string tmId)

Get translation memory info by id

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

            var apiInstance = new TransmemApi(config);
            var tmId = "tmId_example";  // string | 

            try
            {
                // Get translation memory info by id
                TransMem result = apiInstance.Get(tmId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.Get: " + e.Message);
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
    // Get translation memory info by id
    ApiResponse<TransMem> response = apiInstance.GetWithHttpInfo(tmId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.GetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tmId** | **string** |  |  |

### Return type

[**TransMem**](TransMem.md)

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

<a name="importtmx"></a>
# **ImportTmx**
> void ImportTmx (string tmId, System.IO.Stream file)

Import a translation memory from tmx file

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ImportTmxExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransmemApi(config);
            var tmId = "tmId_example";  // string | 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | 

            try
            {
                // Import a translation memory from tmx file
                apiInstance.ImportTmx(tmId, file);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.ImportTmx: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ImportTmxWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Import a translation memory from tmx file
    apiInstance.ImportTmxWithHttpInfo(tmId, file);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.ImportTmxWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tmId** | **string** |  |  |
| **file** | **System.IO.Stream****System.IO.Stream** |  |  |

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
| **200** | Import tmx file successfully |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listtm"></a>
# **ListTM**
> List&lt;TransMem&gt; ListTM (long? projectId = null)

List all available translation memories or create default one if there is no translation memory

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class ListTMExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TransmemApi(config);
            var projectId = 789L;  // long? |  (optional) 

            try
            {
                // List all available translation memories or create default one if there is no translation memory
                List<TransMem> result = apiInstance.ListTM(projectId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.ListTM: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTMWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all available translation memories or create default one if there is no translation memory
    ApiResponse<List<TransMem>> response = apiInstance.ListTMWithHttpInfo(projectId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.ListTMWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **projectId** | **long?** |  | [optional]  |

### Return type

[**List&lt;TransMem&gt;**](TransMem.md)

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
> TransMem Update (string tmId, UpdateTransMem updateTransMem = null)

Update a translation memory

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

            var apiInstance = new TransmemApi(config);
            var tmId = "tmId_example";  // string | 
            var updateTransMem = new UpdateTransMem(); // UpdateTransMem |  (optional) 

            try
            {
                // Update a translation memory
                TransMem result = apiInstance.Update(tmId, updateTransMem);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TransmemApi.Update: " + e.Message);
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
    // Update a translation memory
    ApiResponse<TransMem> response = apiInstance.UpdateWithHttpInfo(tmId, updateTransMem);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TransmemApi.UpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tmId** | **string** |  |  |
| **updateTransMem** | [**UpdateTransMem**](UpdateTransMem.md) |  | [optional]  |

### Return type

[**TransMem**](TransMem.md)

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

