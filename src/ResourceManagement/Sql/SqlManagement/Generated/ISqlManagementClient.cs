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
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql;

namespace Microsoft.Azure.Management.Sql
{
    /// <summary>
    /// The Windows Azure SQL Database management API provides a RESTful set of
    /// web services that interact with Windows Azure SQL Database services to
    /// manage your databases. The API enables users to create, retrieve,
    /// update, and delete databases and servers.
    /// </summary>
    public partial interface ISqlManagementClient : IDisposable
    {
        /// <summary>
        /// Gets the API version.
        /// </summary>
        string ApiVersion
        {
            get; 
        }
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        Uri BaseUri
        {
            get; 
        }
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; 
        }
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationInitialTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        int LongRunningOperationRetryTimeout
        {
            get; set; 
        }
        
        /// <summary>
        /// Represents all the operations to manage Azure SQL Database and
        /// Database Server Audit policy.  Contains operations to: Create,
        /// Retrieve and Update audit policy.
        /// </summary>
        IAuditingPolicyOperations AuditingPolicy
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Databases.
        /// Contains operations to: Create, Retrieve, Update, and Delete
        /// databases, and also includes the ability to get the event logs for
        /// a database.
        /// </summary>
        IDatabaseOperations Databases
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// data masking. Contains operations to: Create, Retrieve, Update,
        /// and Delete data masking rules, as well as Create, Retreive and
        /// Update data masking policy.
        /// </summary>
        IDataMaskingOperations DataMasking
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Elastic Pools.  Contains operations to: Create, Retrieve, Update,
        /// and Delete.
        /// </summary>
        IElasticPoolOperations ElasticPools
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Server Firewall Rules.  Contains operations to: Create, Retrieve,
        /// Update, and Delete firewall rules.
        /// </summary>
        IFirewallRuleOperations FirewallRules
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL
        /// Recommended Elastic Pools.  Contains operations to: Retrieve.
        /// </summary>
        IRecommendedElasticPoolOperations RecommendedElasticPools
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for managing Azure SQL Database
        /// secure connection.  Contains operations to: Create, Retrieve and
        /// Update secure connection policy .
        /// </summary>
        ISecureConnectionPolicyOperations SecureConnection
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Servers.  Contains operations to: Create, Retrieve, Update, and
        /// Delete servers.
        /// </summary>
        IServerOperations Servers
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for Azure SQL Database Server Upgrade
        /// </summary>
        IServerUpgradeOperations ServerUpgrades
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on Azure SQL Database
        /// Service Objectives.   Contains operations to: Retrieve service
        /// objectives.
        /// </summary>
        IServiceObjectiveOperations ServiceObjectives
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations for operating on service tier
        /// advisors.  Contains operations to: Retrieve.
        /// </summary>
        IServiceTierAdvisorOperations ServiceTierAdvisors
        {
            get; 
        }
        
        /// <summary>
        /// Represents all the operations of Azure SQL Database Transparent
        /// Data Encryption.  Contains operations to: Retrieve, and Update
        /// Transparent Data Encryption.
        /// </summary>
        ITransparentDataEncryptionOperations TransparentDataEncryption
        {
            get; 
        }
    }
}
