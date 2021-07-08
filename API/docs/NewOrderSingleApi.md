# IO.Swagger.Api.NewOrderSingleApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1NewOrderSingleInstanceSessionClordidDelete**](NewOrderSingleApi.md#v1newordersingleinstancesessionclordiddelete) | **DELETE** /v1/NewOrderSingle/{instance}/{session}/clordid | Delete a FIX Order.   Order can not be active for deletion.  (Must be in Cancelled, Rejected state.)
[**V1NewOrderSingleOrdersOutInstanceGet**](NewOrderSingleApi.md#v1newordersingleordersoutinstanceget) | **GET** /v1/NewOrderSingle/OrdersOut/{instance} | Get all the orders sent out for this FIXServer instance across all FIX sessions.
[**V1NewOrderSingleOrdersOutInstanceSessionGet**](NewOrderSingleApi.md#v1newordersingleordersoutinstancesessionget) | **GET** /v1/NewOrderSingle/OrdersOut/{instance}/{session} | Get all Orders sent out for the target session
[**V1NewOrderSingleOrdersOutInstanceSessionPost**](NewOrderSingleApi.md#v1newordersingleordersoutinstancesessionpost) | **POST** /v1/NewOrderSingle/OrdersOut/{instance}/{session} | Send a NewOrderSingle (MsgType &#x3D; D) to FIX endpoint.

<a name="v1newordersingleinstancesessionclordiddelete"></a>
# **V1NewOrderSingleInstanceSessionClordidDelete**
> void V1NewOrderSingleInstanceSessionClordidDelete (string instance, string session, string clordid = null)

Delete a FIX Order.   Order can not be active for deletion.  (Must be in Cancelled, Rejected state.)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1NewOrderSingleInstanceSessionClordidDeleteExample
    {
        public void main()
        {
            var apiInstance = new NewOrderSingleApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 
            var clordid = clordid_example;  // string |  (optional) 

            try
            {
                // Delete a FIX Order.   Order can not be active for deletion.  (Must be in Cancelled, Rejected state.)
                apiInstance.V1NewOrderSingleInstanceSessionClordidDelete(instance, session, clordid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewOrderSingleApi.V1NewOrderSingleInstanceSessionClordidDelete: " + e.Message );
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
 **clordid** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1newordersingleordersoutinstanceget"></a>
# **V1NewOrderSingleOrdersOutInstanceGet**
> List<NewOrderSingleDetails> V1NewOrderSingleOrdersOutInstanceGet (string instance)

Get all the orders sent out for this FIXServer instance across all FIX sessions.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1NewOrderSingleOrdersOutInstanceGetExample
    {
        public void main()
        {
            var apiInstance = new NewOrderSingleApi();
            var instance = instance_example;  // string | FIXSIM Instance

            try
            {
                // Get all the orders sent out for this FIXServer instance across all FIX sessions.
                List&lt;NewOrderSingleDetails&gt; result = apiInstance.V1NewOrderSingleOrdersOutInstanceGet(instance);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewOrderSingleApi.V1NewOrderSingleOrdersOutInstanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instance** | **string**| FIXSIM Instance | 

### Return type

[**List<NewOrderSingleDetails>**](NewOrderSingleDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1newordersingleordersoutinstancesessionget"></a>
# **V1NewOrderSingleOrdersOutInstanceSessionGet**
> List<NewOrderSingleDetails> V1NewOrderSingleOrdersOutInstanceSessionGet (string instance, string session, string orderstatus = null)

Get all Orders sent out for the target session

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1NewOrderSingleOrdersOutInstanceSessionGetExample
    {
        public void main()
        {
            var apiInstance = new NewOrderSingleApi();
            var instance = instance_example;  // string | FIXServer Instance
            var session = session_example;  // string | FIXServer target FIX session name
            var orderstatus = orderstatus_example;  // string | One or more FIX OrdStatus seperated by comma,  ex:  A,E (optional) 

            try
            {
                // Get all Orders sent out for the target session
                List&lt;NewOrderSingleDetails&gt; result = apiInstance.V1NewOrderSingleOrdersOutInstanceSessionGet(instance, session, orderstatus);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewOrderSingleApi.V1NewOrderSingleOrdersOutInstanceSessionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instance** | **string**| FIXServer Instance | 
 **session** | **string**| FIXServer target FIX session name | 
 **orderstatus** | **string**| One or more FIX OrdStatus seperated by comma,  ex:  A,E | [optional] 

### Return type

[**List<NewOrderSingleDetails>**](NewOrderSingleDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1newordersingleordersoutinstancesessionpost"></a>
# **V1NewOrderSingleOrdersOutInstanceSessionPost**
> NewOrderSingleDetails V1NewOrderSingleOrdersOutInstanceSessionPost (string instance, string session, NewOrderSingle body = null)

Send a NewOrderSingle (MsgType = D) to FIX endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1NewOrderSingleOrdersOutInstanceSessionPostExample
    {
        public void main()
        {
            var apiInstance = new NewOrderSingleApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 
            var body = new NewOrderSingle(); // NewOrderSingle |  (optional) 

            try
            {
                // Send a NewOrderSingle (MsgType = D) to FIX endpoint.
                NewOrderSingleDetails result = apiInstance.V1NewOrderSingleOrdersOutInstanceSessionPost(instance, session, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewOrderSingleApi.V1NewOrderSingleOrdersOutInstanceSessionPost: " + e.Message );
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
 **body** | [**NewOrderSingle**](NewOrderSingle.md)|  | [optional] 

### Return type

[**NewOrderSingleDetails**](NewOrderSingleDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
