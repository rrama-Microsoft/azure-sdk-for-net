// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Hyak.Common.Internals;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// Represents all the operations for Azure SQL Database Server Upgrade
    /// </summary>
    internal partial class ServerUpgradeOperations : IServiceOperations<SqlManagementClient>, IServerUpgradeOperations
    {
        /// <summary>
        /// Initializes a new instance of the ServerUpgradeOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ServerUpgradeOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.Azure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Cancel a pending upgrade for the Azure SQL Database server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to cancel
        /// upgrade.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<AzureOperationResponse> CancelAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                TracingAdapter.Enter(invocationId, this, "CancelAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/operationResults/versionUpgrade";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Delete;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    AzureOperationResponse result = null;
                    // Deserialize Response
                    result = new AzureOperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns information about Upgrade status of an Azure SQL Database
        /// Server.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to upgrade.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a Get request for Upgrade status of an
        /// Azure SQL Database Server.
        /// </returns>
        public async Task<ServerUpgradeGetResponse> GetAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/operationResults/versionUpgrade";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK && statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    ServerUpgradeGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK || statusCode == HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new ServerUpgradeGetResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            JToken statusValue = responseDoc["status"];
                            if (statusValue != null && statusValue.Type != JTokenType.Null)
                            {
                                string statusInstance = ((string)statusValue);
                                result.Status = statusInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Start an Azure SQL Database Server Upgrade.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group to which the server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to upgrade.
        /// </param>
        /// <param name='parameters'>
        /// Required. The required parameters for the Azure SQL Database Server
        /// Upgrade.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public async Task<AzureOperationResponse> StartAsync(string resourceGroupName, string serverName, ServerUpgradeStartParameters parameters, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException("resourceGroupName");
            }
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }
            if (parameters.Properties == null)
            {
                throw new ArgumentNullException("parameters.Properties");
            }
            if (parameters.Properties.Version == null)
            {
                throw new ArgumentNullException("parameters.Properties.Version");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceGroupName", resourceGroupName);
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("parameters", parameters);
                TracingAdapter.Enter(invocationId, this, "StartAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/subscriptions/";
            if (this.Client.Credentials.SubscriptionId != null)
            {
                url = url + Uri.EscapeDataString(this.Client.Credentials.SubscriptionId);
            }
            url = url + "/resourceGroups/";
            url = url + Uri.EscapeDataString(resourceGroupName);
            url = url + "/providers/";
            url = url + "Microsoft.Sql";
            url = url + "/servers/";
            url = url + Uri.EscapeDataString(serverName);
            url = url + "/upgrade";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2014-04-01");
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Post;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Serialize Request
                string requestContent = null;
                JToken requestDoc = null;
                
                JObject serverUpgradeStartParametersValue = new JObject();
                requestDoc = serverUpgradeStartParametersValue;
                
                JObject serverUpgradePropertiesValue = new JObject();
                serverUpgradeStartParametersValue["serverUpgradeProperties"] = serverUpgradePropertiesValue;
                
                serverUpgradePropertiesValue["Version"] = parameters.Properties.Version;
                
                if (parameters.Properties.ScheduleUpgradeAfterUtcDateTime != null)
                {
                    serverUpgradePropertiesValue["ScheduleUpgradeAfterUtcDateTime"] = parameters.Properties.ScheduleUpgradeAfterUtcDateTime.Value;
                }
                
                if (parameters.Properties.DatabaseCollection != null)
                {
                    if (parameters.Properties.DatabaseCollection is ILazyCollection == false || ((ILazyCollection)parameters.Properties.DatabaseCollection).IsInitialized)
                    {
                        JArray databaseCollectionArray = new JArray();
                        foreach (RecommendedDatabaseProperties databaseCollectionItem in parameters.Properties.DatabaseCollection)
                        {
                            JObject recommendedDatabasePropertiesValue = new JObject();
                            databaseCollectionArray.Add(recommendedDatabasePropertiesValue);
                            
                            if (databaseCollectionItem.Name != null)
                            {
                                recommendedDatabasePropertiesValue["Name"] = databaseCollectionItem.Name;
                            }
                            
                            if (databaseCollectionItem.TargetEdition != null)
                            {
                                recommendedDatabasePropertiesValue["TargetEdition"] = databaseCollectionItem.TargetEdition;
                            }
                            
                            if (databaseCollectionItem.TargetServiceLevelObjective != null)
                            {
                                recommendedDatabasePropertiesValue["TargetServiceLevelObjective"] = databaseCollectionItem.TargetServiceLevelObjective;
                            }
                        }
                        serverUpgradePropertiesValue["DatabaseCollection"] = databaseCollectionArray;
                    }
                }
                
                requestContent = requestDoc.ToString(Newtonsoft.Json.Formatting.Indented);
                httpRequest.Content = new StringContent(requestContent, Encoding.UTF8);
                httpRequest.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.Accepted)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, requestContent, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    AzureOperationResponse result = null;
                    // Deserialize Response
                    result = new AzureOperationResponse();
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
