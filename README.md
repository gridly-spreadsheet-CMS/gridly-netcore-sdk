# Com.Gridly - the C# library for the Gridly API

Gridly API documentation

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 4.29.1
- SDK version: 1.2.12
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.gridly.com](https://www.gridly.com)

<a name="frameworks-supported"></a>
## Frameworks supported

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Com.Gridly.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Gridly.Api;
using Com.Gridly.Client;
using Com.Gridly.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.gridly.com";
            // Configure API key authorization: ApiKey
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BranchApi.Create: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.gridly.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BranchApi* | [**Create**](docs/BranchApi.md#create) | **POST** /v1/branches | create
*BranchApi* | [**CreateDiffCheck**](docs/BranchApi.md#creatediffcheck) | **POST** /v1/branches/diffcheck | createDiffCheck
*BranchApi* | [**Delete**](docs/BranchApi.md#delete) | **DELETE** /v1/branches/{branchId} | delete
*BranchApi* | [**Get**](docs/BranchApi.md#get) | **GET** /v1/branches/{branchId} | get
*BranchApi* | [**GetDiffCheck**](docs/BranchApi.md#getdiffcheck) | **GET** /v1/branches/diffcheck/{taskId} | getDiffCheck
*BranchApi* | [**List**](docs/BranchApi.md#list) | **GET** /v1/branches | list
*BranchApi* | [**Merge**](docs/BranchApi.md#merge) | **POST** /v1/branches/{branchId}/merge | merge
*DatabaseApi* | [**Create**](docs/DatabaseApi.md#create) | **POST** /v1/databases | create
*DatabaseApi* | [**Delete**](docs/DatabaseApi.md#delete) | **DELETE** /v1/databases/{dbId} | delete
*DatabaseApi* | [**Duplicate**](docs/DatabaseApi.md#duplicate) | **POST** /v1/databases/{dbId}/duplicate | duplicate
*DatabaseApi* | [**Get**](docs/DatabaseApi.md#get) | **GET** /v1/databases/{dbId} | get
*DatabaseApi* | [**List**](docs/DatabaseApi.md#list) | **GET** /v1/databases | list
*DatabaseApi* | [**Update**](docs/DatabaseApi.md#update) | **PUT** /v1/databases/{dbId} | update
*GlossaryApi* | [**Create**](docs/GlossaryApi.md#create) | **POST** /v1/glossaries | Create a new glossary
*GlossaryApi* | [**Delete**](docs/GlossaryApi.md#delete) | **DELETE** /v1/glossaries/{id} | Delete a glossary
*GlossaryApi* | [**ExportFile**](docs/GlossaryApi.md#exportfile) | **GET** /v1/glossaries/{id}/export | Export a glossary
*GlossaryApi* | [**Get**](docs/GlossaryApi.md#get) | **GET** /v1/glossaries/{id} | get glossary info
*GlossaryApi* | [**GetAll**](docs/GlossaryApi.md#getall) | **GET** /v1/glossaries | List all glossaries
*GlossaryApi* | [**ImportFile**](docs/GlossaryApi.md#importfile) | **POST** /v1/glossaries/{id}/import | Import a glossary from file
*GlossaryApi* | [**Update**](docs/GlossaryApi.md#update) | **PUT** /v1/glossaries/{id} | Update glossary info
*GridApi* | [**Create**](docs/GridApi.md#create) | **POST** /v1/grids | create
*GridApi* | [**CreateCategory**](docs/GridApi.md#createcategory) | **POST** /v1/grids/{gridId}/settings/categories | createCategory
*GridApi* | [**Delete**](docs/GridApi.md#delete) | **DELETE** /v1/grids/{gridId} | delete
*GridApi* | [**DeleteCategory**](docs/GridApi.md#deletecategory) | **DELETE** /v1/grids/{gridId}/settings/categories/{categoryId} | deleteCategory
*GridApi* | [**DeleteFile**](docs/GridApi.md#deletefile) | **DELETE** /v1/grids/{gridId}/settings/categories/{categoryId}/files/{fileId} | deleteFile
*GridApi* | [**Get**](docs/GridApi.md#get) | **GET** /v1/grids/{gridId} | get
*GridApi* | [**GetSetting**](docs/GridApi.md#getsetting) | **GET** /v1/grids/{gridId}/settings | getSetting
*GridApi* | [**List**](docs/GridApi.md#list) | **GET** /v1/grids | list
*GridApi* | [**ListFiles**](docs/GridApi.md#listfiles) | **GET** /v1/grids/{gridId}/settings/files | listFiles
*GridApi* | [**ListTemplateGrids**](docs/GridApi.md#listtemplategrids) | **GET** /v1/template-grids | listTemplateGrids
*GridApi* | [**Update**](docs/GridApi.md#update) | **PATCH** /v1/grids/{gridId} | update
*GridApi* | [**UpdateCategory**](docs/GridApi.md#updatecategory) | **PUT** /v1/grids/{gridId}/settings/categories/{categoryId} | updateCategory
*GridApi* | [**UpdateSetting**](docs/GridApi.md#updatesetting) | **PATCH** /v1/grids/{gridId}/settings | updateSetting
*GridApi* | [**UploadSettingFile**](docs/GridApi.md#uploadsettingfile) | **POST** /v1/grids/{gridId}/settings/categories/{categoryId}/files | uploadSettingFile
*PathApi* | [**Create**](docs/PathApi.md#create) | **POST** /v1/views/{viewId}/paths | create
*PathApi* | [**Delete**](docs/PathApi.md#delete) | **DELETE** /v1/views/{viewId}/paths | delete
*PathApi* | [**List**](docs/PathApi.md#list) | **GET** /v1/views/{viewId}/paths/tree | list
*PathApi* | [**Move**](docs/PathApi.md#move) | **POST** /v1/views/{viewId}/paths/move | move
*PathApi* | [**Update**](docs/PathApi.md#update) | **PUT** /v1/views/{viewId}/paths/{path} | update
*ProjectApi* | [**Create**](docs/ProjectApi.md#create) | **POST** /v1/projects | create
*ProjectApi* | [**Delete**](docs/ProjectApi.md#delete) | **DELETE** /v1/projects/{projectId} | delete
*ProjectApi* | [**FindOne**](docs/ProjectApi.md#findone) | **GET** /v1/projects/{projectId} | findOne
*ProjectApi* | [**List**](docs/ProjectApi.md#list) | **GET** /v1/projects | list
*ProjectApi* | [**Update**](docs/ProjectApi.md#update) | **PUT** /v1/projects/{projectId} | update
*RecordApi* | [**Create**](docs/RecordApi.md#create) | **POST** /v1/views/{viewId}/records | create
*RecordApi* | [**Delete**](docs/RecordApi.md#delete) | **DELETE** /v1/views/{viewId}/records | delete
*RecordApi* | [**Fetch**](docs/RecordApi.md#fetch) | **GET** /v1/views/{viewId}/records | fetch
*RecordApi* | [**FetchHistories**](docs/RecordApi.md#fetchhistories) | **GET** /v1/views/{viewId}/records/{recordId}/histories | fetchHistories
*RecordApi* | [**Update**](docs/RecordApi.md#update) | **PATCH** /v1/views/{viewId}/records | update
*RecordApi* | [**UpdateRecord**](docs/RecordApi.md#updaterecord) | **PATCH** /v1/views/{viewId}/records/{id} | updateRecord
*ShareViewApi* | [**Create**](docs/ShareViewApi.md#create) | **PUT** /v1/views/{viewId}/shares | create
*ShareViewApi* | [**Delete**](docs/ShareViewApi.md#delete) | **DELETE** /v1/views/{viewId}/shares | delete
*ShareViewApi* | [**Get**](docs/ShareViewApi.md#get) | **GET** /v1/views/{viewId}/shares | get
*TaskApi* | [**Get**](docs/TaskApi.md#get) | **GET** /v1/tasks/{taskId} | get
*TransmemApi* | [**Cleanup**](docs/TransmemApi.md#cleanup) | **PUT** /v1/transmems/{tmId}/cleanup | Erases all the translation data of the provided tmId
*TransmemApi* | [**Create**](docs/TransmemApi.md#create) | **POST** /v1/transmems | Create a new translation memory
*TransmemApi* | [**CreateWithFile**](docs/TransmemApi.md#createwithfile) | **POST** /v1/transmems/upload | Create a new translation memory by uploading tmx file
*TransmemApi* | [**Delete**](docs/TransmemApi.md#delete) | **DELETE** /v1/transmems/{tmId} | Delete a translation memory by id
*TransmemApi* | [**Export**](docs/TransmemApi.md#export) | **GET** /v1/transmems/{tmId}/export | Export translation memory tmx file
*TransmemApi* | [**Get**](docs/TransmemApi.md#get) | **GET** /v1/transmems/{tmId} | Get translation memory info by id
*TransmemApi* | [**ImportTmx**](docs/TransmemApi.md#importtmx) | **POST** /v1/transmems/{tmId}/import | Import a translation memory from tmx file
*TransmemApi* | [**ListTM**](docs/TransmemApi.md#listtm) | **GET** /v1/transmems | List all available translation memories or create default one if there is no translation memory
*TransmemApi* | [**Update**](docs/TransmemApi.md#update) | **PUT** /v1/transmems/{tmId} | Update a translation memory
*ViewApi* | [**Create**](docs/ViewApi.md#create) | **POST** /v1/views | create
*ViewApi* | [**Export**](docs/ViewApi.md#export) | **GET** /v1/views/{viewId}/export | export
*ViewApi* | [**Get**](docs/ViewApi.md#get) | **GET** /v1/views/{viewId} | get
*ViewApi* | [**GetStatistic**](docs/ViewApi.md#getstatistic) | **GET** /v1/views/{viewId}/statistic | getStatistic
*ViewApi* | [**ImportView**](docs/ViewApi.md#importview) | **POST** /v1/views/{viewId}/import | importView
*ViewApi* | [**List**](docs/ViewApi.md#list) | **GET** /v1/views | list
*ViewApi* | [**Merge**](docs/ViewApi.md#merge) | **POST** /v1/views/{viewId}/merge | merge
*ViewColumnApi* | [**Add**](docs/ViewColumnApi.md#add) | **POST** /v1/views/{viewId}/columns/{columnId}/add | add
*ViewColumnApi* | [**BulkCreate**](docs/ViewColumnApi.md#bulkcreate) | **POST** /v1/views/{viewId}/columns/bulk | bulkCreate
*ViewColumnApi* | [**Create**](docs/ViewColumnApi.md#create) | **POST** /v1/views/{viewId}/columns | create
*ViewColumnApi* | [**Delete**](docs/ViewColumnApi.md#delete) | **DELETE** /v1/views/{viewId}/columns/{columnId} | delete
*ViewColumnApi* | [**Get**](docs/ViewColumnApi.md#get) | **GET** /v1/views/{viewId}/columns/{columnId} | get
*ViewColumnApi* | [**Remove**](docs/ViewColumnApi.md#remove) | **POST** /v1/views/{viewId}/columns/{columnId}/remove | remove
*ViewColumnApi* | [**Update**](docs/ViewColumnApi.md#update) | **PATCH** /v1/views/{viewId}/columns/{columnId} | update
*ViewDependencyApi* | [**Create**](docs/ViewDependencyApi.md#create) | **POST** /v1/views/{viewId}/dependencies | create
*ViewDependencyApi* | [**Delete**](docs/ViewDependencyApi.md#delete) | **DELETE** /v1/views/{viewId}/dependencies | delete
*ViewDependencyApi* | [**DeleteById**](docs/ViewDependencyApi.md#deletebyid) | **DELETE** /v1/views/{viewId}/dependencies/{dependencyId} | deleteById
*ViewDependencyApi* | [**Get**](docs/ViewDependencyApi.md#get) | **GET** /v1/views/{viewId}/dependencies/{dependencyId} | get
*ViewDependencyApi* | [**List**](docs/ViewDependencyApi.md#list) | **GET** /v1/views/{viewId}/dependencies | list
*ViewDependencyApi* | [**Update**](docs/ViewDependencyApi.md#update) | **PUT** /v1/views/{viewId}/dependencies/{dependencyId} | update
*ViewFileApi* | [**Delete**](docs/ViewFileApi.md#delete) | **DELETE** /v1/views/{viewId}/files | delete
*ViewFileApi* | [**Download**](docs/ViewFileApi.md#download) | **GET** /v1/views/{viewId}/files/{fileId} | download
*ViewFileApi* | [**Upload**](docs/ViewFileApi.md#upload) | **POST** /v1/views/{viewId}/files | upload
*ViewFileApi* | [**UploadZip**](docs/ViewFileApi.md#uploadzip) | **POST** /v1/views/{viewId}/files/zip | uploadZip


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddViewColumn](docs/AddViewColumn.md)
 - [Model.Branch](docs/Branch.md)
 - [Model.BranchDiffCell](docs/BranchDiffCell.md)
 - [Model.BranchDiffRecord](docs/BranchDiffRecord.md)
 - [Model.Cell](docs/Cell.md)
 - [Model.CellHistory](docs/CellHistory.md)
 - [Model.ColumnReference](docs/ColumnReference.md)
 - [Model.ColumnStatistic](docs/ColumnStatistic.md)
 - [Model.CreateBranch](docs/CreateBranch.md)
 - [Model.CreateColumn](docs/CreateColumn.md)
 - [Model.CreateDatabase](docs/CreateDatabase.md)
 - [Model.CreateDependency](docs/CreateDependency.md)
 - [Model.CreateFileCategory](docs/CreateFileCategory.md)
 - [Model.CreateGlossary](docs/CreateGlossary.md)
 - [Model.CreateGrid](docs/CreateGrid.md)
 - [Model.CreatePath](docs/CreatePath.md)
 - [Model.CreateProject](docs/CreateProject.md)
 - [Model.CreateShareView](docs/CreateShareView.md)
 - [Model.CreateTransMem](docs/CreateTransMem.md)
 - [Model.CreateView](docs/CreateView.md)
 - [Model.Database](docs/Database.md)
 - [Model.DateTimeFormat](docs/DateTimeFormat.md)
 - [Model.DeleteDependency](docs/DeleteDependency.md)
 - [Model.DeleteFile](docs/DeleteFile.md)
 - [Model.DeletePath](docs/DeletePath.md)
 - [Model.DeleteRecord](docs/DeleteRecord.md)
 - [Model.Dependency](docs/Dependency.md)
 - [Model.ExportFileHeader](docs/ExportFileHeader.md)
 - [Model.ExportFormat](docs/ExportFormat.md)
 - [Model.FetchFileOption](docs/FetchFileOption.md)
 - [Model.FetchRecordHistoryRequest](docs/FetchRecordHistoryRequest.md)
 - [Model.FileCategory](docs/FileCategory.md)
 - [Model.FilterField](docs/FilterField.md)
 - [Model.Formula](docs/Formula.md)
 - [Model.Glossary](docs/Glossary.md)
 - [Model.GlossaryExportFormat](docs/GlossaryExportFormat.md)
 - [Model.GlossaryProject](docs/GlossaryProject.md)
 - [Model.Grid](docs/Grid.md)
 - [Model.GridSetting](docs/GridSetting.md)
 - [Model.Group](docs/Group.md)
 - [Model.ImportOption](docs/ImportOption.md)
 - [Model.MergeBranchRequest](docs/MergeBranchRequest.md)
 - [Model.MergeCellConflict](docs/MergeCellConflict.md)
 - [Model.MergeRecordConflict](docs/MergeRecordConflict.md)
 - [Model.MovePath](docs/MovePath.md)
 - [Model.NumberFormat](docs/NumberFormat.md)
 - [Model.PathList](docs/PathList.md)
 - [Model.PathNode](docs/PathNode.md)
 - [Model.PathSingle](docs/PathSingle.md)
 - [Model.Privilege](docs/Privilege.md)
 - [Model.Project](docs/Project.md)
 - [Model.ProjectDetail](docs/ProjectDetail.md)
 - [Model.Record](docs/Record.md)
 - [Model.RecordHistory](docs/RecordHistory.md)
 - [Model.RecordIdentifierWrapper](docs/RecordIdentifierWrapper.md)
 - [Model.Reference](docs/Reference.md)
 - [Model.ReferencedColumn](docs/ReferencedColumn.md)
 - [Model.ReferencedGrid](docs/ReferencedGrid.md)
 - [Model.Role](docs/Role.md)
 - [Model.SetCell](docs/SetCell.md)
 - [Model.SetRecord](docs/SetRecord.md)
 - [Model.SettingFile](docs/SettingFile.md)
 - [Model.ShareView](docs/ShareView.md)
 - [Model.Task](docs/Task.md)
 - [Model.TransMem](docs/TransMem.md)
 - [Model.TranslationCount](docs/TranslationCount.md)
 - [Model.TranslationStatus](docs/TranslationStatus.md)
 - [Model.UpdateCategory](docs/UpdateCategory.md)
 - [Model.UpdateColumn](docs/UpdateColumn.md)
 - [Model.UpdateDatabase](docs/UpdateDatabase.md)
 - [Model.UpdateDependency](docs/UpdateDependency.md)
 - [Model.UpdateGlossary](docs/UpdateGlossary.md)
 - [Model.UpdateGrid](docs/UpdateGrid.md)
 - [Model.UpdateGridSetting](docs/UpdateGridSetting.md)
 - [Model.UpdatePath](docs/UpdatePath.md)
 - [Model.UpdateProject](docs/UpdateProject.md)
 - [Model.UpdateTransMem](docs/UpdateTransMem.md)
 - [Model.UploadSettingFileRequest](docs/UploadSettingFileRequest.md)
 - [Model.UploadZipRequest](docs/UploadZipRequest.md)
 - [Model.UploadedFile](docs/UploadedFile.md)
 - [Model.View](docs/View.md)
 - [Model.ViewColumn](docs/ViewColumn.md)
 - [Model.ViewStatistic](docs/ViewStatistic.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKey"></a>
### ApiKey

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

