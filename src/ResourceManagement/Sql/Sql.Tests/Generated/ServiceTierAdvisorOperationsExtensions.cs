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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Sql;
using Microsoft.Azure.Management.Sql.Models;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public static partial class ServiceTierAdvisorOperationsExtensions
    {
        /// <summary>
        /// Returns information about a service tier advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServiceTierAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of database.
        /// </param>
        /// <param name='serviceTierAdvisorName'>
        /// Required. The name of service tier advisor.
        /// </param>
        /// <returns>
        /// Represents the response to a get service tier advisor request.
        /// </returns>
        public static ServiceTierAdvisorGetResponse Get(this IServiceTierAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string serviceTierAdvisorName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceTierAdvisorOperations)s).GetAsync(resourceGroupName, serverName, databaseName, serviceTierAdvisorName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about a service tier advisor.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServiceTierAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of database.
        /// </param>
        /// <param name='serviceTierAdvisorName'>
        /// Required. The name of service tier advisor.
        /// </param>
        /// <returns>
        /// Represents the response to a get service tier advisor request.
        /// </returns>
        public static Task<ServiceTierAdvisorGetResponse> GetAsync(this IServiceTierAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName, string serviceTierAdvisorName)
        {
            return operations.GetAsync(resourceGroupName, serverName, databaseName, serviceTierAdvisorName, CancellationToken.None);
        }
        
        /// <summary>
        /// Returns information about service tier advisors for specified
        /// database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServiceTierAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of database.
        /// </param>
        /// <returns>
        /// Represents the response to a list service tier advisor request.
        /// </returns>
        public static ServiceTierAdvisorListResponse List(this IServiceTierAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IServiceTierAdvisorOperations)s).ListAsync(resourceGroupName, serverName, databaseName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Returns information about service tier advisors for specified
        /// database.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Sql.IServiceTierAdvisorOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. The name of the Resource Group.
        /// </param>
        /// <param name='serverName'>
        /// Required. The name of server.
        /// </param>
        /// <param name='databaseName'>
        /// Required. The name of database.
        /// </param>
        /// <returns>
        /// Represents the response to a list service tier advisor request.
        /// </returns>
        public static Task<ServiceTierAdvisorListResponse> ListAsync(this IServiceTierAdvisorOperations operations, string resourceGroupName, string serverName, string databaseName)
        {
            return operations.ListAsync(resourceGroupName, serverName, databaseName, CancellationToken.None);
        }
    }
}
