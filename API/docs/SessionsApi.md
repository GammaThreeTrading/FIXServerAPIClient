# IO.Swagger.Api.SessionsApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1SessionsInstanceGet**](SessionsApi.md#v1sessionsinstanceget) | **GET** /v1/Sessions/{instance} | Get all FIX sessions details.
[**V1SessionsInstancePatch**](SessionsApi.md#v1sessionsinstancepatch) | **PATCH** /v1/Sessions/{instance} | Modify an existing FIXServer session.
[**V1SessionsInstanceSessionDelete**](SessionsApi.md#v1sessionsinstancesessiondelete) | **DELETE** /v1/Sessions/{instance}/{session} | Delete a FIXServer session.

<a name="v1sessionsinstanceget"></a>
# **V1SessionsInstanceGet**
> List<SessionInfo> V1SessionsInstanceGet (string instance)

Get all FIX sessions details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1SessionsInstanceGetExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var instance = instance_example;  // string | 

            try
            {
                // Get all FIX sessions details.
                List&lt;SessionInfo&gt; result = apiInstance.V1SessionsInstanceGet(instance);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.V1SessionsInstanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instance** | **string**|  | 

### Return type

[**List<SessionInfo>**](SessionInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1sessionsinstancepatch"></a>
# **V1SessionsInstancePatch**
> void V1SessionsInstancePatch (string instance, SessionInfo body = null)

Modify an existing FIXServer session.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1SessionsInstancePatchExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var instance = instance_example;  // string | 
            var body = new SessionInfo(); // SessionInfo |  (optional) 

            try
            {
                // Modify an existing FIXServer session.
                apiInstance.V1SessionsInstancePatch(instance, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.V1SessionsInstancePatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instance** | **string**|  | 
 **body** | [**SessionInfo**](SessionInfo.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1sessionsinstancesessiondelete"></a>
# **V1SessionsInstanceSessionDelete**
> void V1SessionsInstanceSessionDelete (string instance, string session)

Delete a FIXServer session.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1SessionsInstanceSessionDeleteExample
    {
        public void main()
        {
            var apiInstance = new SessionsApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 

            try
            {
                // Delete a FIXServer session.
                apiInstance.V1SessionsInstanceSessionDelete(instance, session);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionsApi.V1SessionsInstanceSessionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instance** | **string**|  | 
 **session** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
