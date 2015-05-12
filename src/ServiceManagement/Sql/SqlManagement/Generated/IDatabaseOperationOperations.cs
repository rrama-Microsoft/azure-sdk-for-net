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
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// The Azure SQL Database Management API includes operations for getting
    /// database operations. Specifically, this API allows you to get a
    /// specific operation, or to list all the operations that happened on a
    /// specific database or on all databases in the Azure SQL Database Server.
    /// </summary>
    public partial interface IDatabaseOperationOperations
    {
        /// <summary>
        /// Returns information about a specific operation by using the
        /// operation Guid.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server where the database is
        /// hosted.
        /// </param>
        /// <param name='operationGuid'>
        /// The Guid of the Azure SQL Database operation to be obtained.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the database operation for a given operation Guid.
        /// </returns>
        Task<DatabaseOperationGetResponse> GetAsync(string serverName, string operationGuid, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves all of the operations that took place on a specific
        /// database.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server that hosts the database.
        /// </param>
        /// <param name='databaseName'>
        /// The name of the database for which the operations should be
        /// retrieved.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response containing the list of database operations
        /// for a given server or database.
        /// </returns>
        Task<DatabaseOperationListResponse> ListByDatabaseAsync(string serverName, string databaseName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Retrieves all of the operations that occured on the Azure SQL
        /// Database Server.
        /// </summary>
        /// <param name='serverName'>
        /// The name of the Azure SQL Database Server to be queried.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response containing the list of database operations
        /// for a given server or database.
        /// </returns>
        Task<DatabaseOperationListResponse> ListByServerAsync(string serverName, CancellationToken cancellationToken);
    }
}
