# IO.Swagger.Api.RawMessageApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1RawMessageInstanceSessionPost**](RawMessageApi.md#v1rawmessageinstancesessionpost) | **POST** /v1/RawMessage/{instance}/{session} | Send a \&quot;raw\&quot; FIX message.

<a name="v1rawmessageinstancesessionpost"></a>
# **V1RawMessageInstanceSessionPost**
> void V1RawMessageInstanceSessionPost (string instance, string session, RawMessage body = null)

Send a \"raw\" FIX message.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1RawMessageInstanceSessionPostExample
    {
        public void main()
        {
            var apiInstance = new RawMessageApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 
            var body = new RawMessage(); // RawMessage |  (optional) 

            try
            {
                // Send a \"raw\" FIX message.
                apiInstance.V1RawMessageInstanceSessionPost(instance, session, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RawMessageApi.V1RawMessageInstanceSessionPost: " + e.Message );
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
 **body** | [**RawMessage**](RawMessage.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
