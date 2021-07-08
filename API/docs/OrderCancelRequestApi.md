# IO.Swagger.Api.OrderCancelRequestApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1OrderCancelRequestInstanceSessionPost**](OrderCancelRequestApi.md#v1ordercancelrequestinstancesessionpost) | **POST** /v1/OrderCancelRequest/{instance}/{session} | Send a Cancel Request on a New Order Single.

<a name="v1ordercancelrequestinstancesessionpost"></a>
# **V1OrderCancelRequestInstanceSessionPost**
> NewOrderSingleDetails V1OrderCancelRequestInstanceSessionPost (string instance, string session, OrderCancelRequest body = null)

Send a Cancel Request on a New Order Single.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1OrderCancelRequestInstanceSessionPostExample
    {
        public void main()
        {
            var apiInstance = new OrderCancelRequestApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 
            var body = new OrderCancelRequest(); // OrderCancelRequest |  (optional) 

            try
            {
                // Send a Cancel Request on a New Order Single.
                NewOrderSingleDetails result = apiInstance.V1OrderCancelRequestInstanceSessionPost(instance, session, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderCancelRequestApi.V1OrderCancelRequestInstanceSessionPost: " + e.Message );
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
 **body** | [**OrderCancelRequest**](OrderCancelRequest.md)|  | [optional] 

### Return type

[**NewOrderSingleDetails**](NewOrderSingleDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
