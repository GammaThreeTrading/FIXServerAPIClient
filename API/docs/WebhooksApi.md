# IO.Swagger.Api.WebhooksApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1WebhooksInstanceSessionGet**](WebhooksApi.md#v1webhooksinstancesessionget) | **GET** /v1/Webhooks/{instance}/{session} | Get a list of the current Webhook Subscriptions
[**V1WebhooksInstanceSessionIdDelete**](WebhooksApi.md#v1webhooksinstancesessioniddelete) | **DELETE** /v1/Webhooks/{instance}/{session}/{id} | Delete a webhook subscription.
[**V1WebhooksInstanceSessionIdPatch**](WebhooksApi.md#v1webhooksinstancesessionidpatch) | **PATCH** /v1/Webhooks/{instance}/{session}/{id} | Update a Webhook subscription
[**V1WebhooksInstanceSessionPost**](WebhooksApi.md#v1webhooksinstancesessionpost) | **POST** /v1/Webhooks/{instance}/{session} | Create a new Webhook subscription.

<a name="v1webhooksinstancesessionget"></a>
# **V1WebhooksInstanceSessionGet**
> List<WebHookSubscriptionDetails> V1WebhooksInstanceSessionGet (string instance, string session)

Get a list of the current Webhook Subscriptions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1WebhooksInstanceSessionGetExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 

            try
            {
                // Get a list of the current Webhook Subscriptions
                List&lt;WebHookSubscriptionDetails&gt; result = apiInstance.V1WebhooksInstanceSessionGet(instance, session);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.V1WebhooksInstanceSessionGet: " + e.Message );
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

[**List<WebHookSubscriptionDetails>**](WebHookSubscriptionDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1webhooksinstancesessioniddelete"></a>
# **V1WebhooksInstanceSessionIdDelete**
> void V1WebhooksInstanceSessionIdDelete (string instance, string session, int? id)

Delete a webhook subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1WebhooksInstanceSessionIdDeleteExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var instance = instance_example;  // string | FIXSIM Instance
            var session = session_example;  // string | FIXSIM target FIX session name
            var id = 56;  // int? | 

            try
            {
                // Delete a webhook subscription.
                apiInstance.V1WebhooksInstanceSessionIdDelete(instance, session, id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.V1WebhooksInstanceSessionIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **instance** | **string**| FIXSIM Instance | 
 **session** | **string**| FIXSIM target FIX session name | 
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1webhooksinstancesessionidpatch"></a>
# **V1WebhooksInstanceSessionIdPatch**
> WebHookSubscriptionDetails V1WebhooksInstanceSessionIdPatch (string instance, string session, int? id, WebHookSubscription body = null)

Update a Webhook subscription

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1WebhooksInstanceSessionIdPatchExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 
            var id = 56;  // int? | 
            var body = new WebHookSubscription(); // WebHookSubscription |  (optional) 

            try
            {
                // Update a Webhook subscription
                WebHookSubscriptionDetails result = apiInstance.V1WebhooksInstanceSessionIdPatch(instance, session, id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.V1WebhooksInstanceSessionIdPatch: " + e.Message );
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
 **id** | **int?**|  | 
 **body** | [**WebHookSubscription**](WebHookSubscription.md)|  | [optional] 

### Return type

[**WebHookSubscriptionDetails**](WebHookSubscriptionDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1webhooksinstancesessionpost"></a>
# **V1WebhooksInstanceSessionPost**
> WebHookSubscriptionDetails V1WebhooksInstanceSessionPost (string instance, string session, WebHookSubscription body = null)

Create a new Webhook subscription.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1WebhooksInstanceSessionPostExample
    {
        public void main()
        {
            var apiInstance = new WebhooksApi();
            var instance = instance_example;  // string | 
            var session = session_example;  // string | 
            var body = new WebHookSubscription(); // WebHookSubscription |  (optional) 

            try
            {
                // Create a new Webhook subscription.
                WebHookSubscriptionDetails result = apiInstance.V1WebhooksInstanceSessionPost(instance, session, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.V1WebhooksInstanceSessionPost: " + e.Message );
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
 **body** | [**WebHookSubscription**](WebHookSubscription.md)|  | [optional] 

### Return type

[**WebHookSubscriptionDetails**](WebHookSubscriptionDetails.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
