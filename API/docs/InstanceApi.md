# IO.Swagger.Api.InstanceApi

All URIs are relative to */*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1InstanceGet**](InstanceApi.md#v1instanceget) | **GET** /v1/Instance | 

<a name="v1instanceget"></a>
# **V1InstanceGet**
> string V1InstanceGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1InstanceGetExample
    {
        public void main()
        {
            var apiInstance = new InstanceApi();

            try
            {
                string result = apiInstance.V1InstanceGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InstanceApi.V1InstanceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
