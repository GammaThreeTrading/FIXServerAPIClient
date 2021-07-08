# IO.Swagger.Api.OrderCancelReplaceRequestApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1OrderCancelReplaceRequestInstanceSessionPost**](OrderCancelReplaceRequestApi.md#v1ordercancelreplacerequestinstancesessionpost) | **POST** /v1/OrderCancelReplaceRequest/{instance}/{session} | Send a Cancel/Replace Request on a New Order Single.

<a name="v1ordercancelreplacerequestinstancesessionpost"></a>
# **V1OrderCancelReplaceRequestInstanceSessionPost**
> NewOrderSingleDetails V1OrderCancelReplaceRequestInstanceSessionPost (string instance, string session, OrderCancelReplaceRequest body = null)

Send a Cancel/Replace Request on a New Order Single.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1OrderCancelReplaceRequestInstanceSessionPostExample
    {
        public void main()
        {
            var apiInstance = new OrderCancelReplaceRequestApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 
            var body = new OrderCancelReplaceRequest(); // OrderCancelReplaceRequest |  (optional) 

            try
            {
                // Send a Cancel/Replace Request on a New Order Single.
                NewOrderSingleDetails result = apiInstance.V1OrderCancelReplaceRequestInstanceSessionPost(instance, session, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderCancelReplaceRequestApi.V1OrderCancelReplaceRequestInstanceSessionPost: " + e.Message );
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
 **body** | [**OrderCancelReplaceRequest**](OrderCancelReplaceRequest.md)|  | [optional] 

### Return type

[**NewOrderSingleDetails**](NewOrderSingleDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
