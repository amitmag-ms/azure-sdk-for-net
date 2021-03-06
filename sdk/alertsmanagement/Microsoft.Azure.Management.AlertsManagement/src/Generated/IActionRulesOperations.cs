// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ActionRulesOperations operations.
    /// </summary>
    public partial interface IActionRulesOperations
    {
        /// <summary>
        /// Get all action rule in a given subscription
        /// </summary>
        /// <remarks>
        /// List all action rules of the subscription and given input filters
        /// </remarks>
        /// <param name='targetResourceGroup'>
        /// Filter by target resource group name. Default value is select all.
        /// </param>
        /// <param name='targetResourceType'>
        /// Filter by target resource type. Default value is select all.
        /// </param>
        /// <param name='targetResource'>
        /// Filter by target resource( which is full ARM ID) Default value is
        /// select all.
        /// </param>
        /// <param name='severity'>
        /// Filter by severity.  Default value is select all. Possible values
        /// include: 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
        /// </param>
        /// <param name='monitorService'>
        /// Filter by monitor service which generates the alert instance.
        /// Default value is select all. Possible values include: 'Application
        /// Insights', 'ActivityLog Administrative', 'ActivityLog Security',
        /// 'ActivityLog Recommendation', 'ActivityLog Policy', 'ActivityLog
        /// Autoscale', 'Log Analytics', 'Nagios', 'Platform', 'SCOM',
        /// 'ServiceHealth', 'SmartDetector', 'VM Insights', 'Zabbix'
        /// </param>
        /// <param name='impactedScope'>
        /// filter by impacted/target scope (provide comma separated list for
        /// multiple scopes). The value should be an well constructed ARM id of
        /// the scope.
        /// </param>
        /// <param name='description'>
        /// filter by alert rule description
        /// </param>
        /// <param name='alertRuleId'>
        /// filter by alert rule id
        /// </param>
        /// <param name='actionGroup'>
        /// filter by action group configured as part of action rule
        /// </param>
        /// <param name='name'>
        /// filter by action rule name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ActionRule>,ActionRulesListBySubscriptionHeaders>> ListBySubscriptionWithHttpMessagesAsync(string targetResourceGroup = default(string), string targetResourceType = default(string), string targetResource = default(string), string severity = default(string), string monitorService = default(string), string impactedScope = default(string), string description = default(string), string alertRuleId = default(string), string actionGroup = default(string), string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all action rules created in a resource group
        /// </summary>
        /// <remarks>
        /// List all action rules of the subscription, created in given
        /// resource group and given input filters
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group name where the resource is created.
        /// </param>
        /// <param name='targetResourceGroup'>
        /// Filter by target resource group name. Default value is select all.
        /// </param>
        /// <param name='targetResourceType'>
        /// Filter by target resource type. Default value is select all.
        /// </param>
        /// <param name='targetResource'>
        /// Filter by target resource( which is full ARM ID) Default value is
        /// select all.
        /// </param>
        /// <param name='severity'>
        /// Filter by severity.  Default value is select all. Possible values
        /// include: 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
        /// </param>
        /// <param name='monitorService'>
        /// Filter by monitor service which generates the alert instance.
        /// Default value is select all. Possible values include: 'Application
        /// Insights', 'ActivityLog Administrative', 'ActivityLog Security',
        /// 'ActivityLog Recommendation', 'ActivityLog Policy', 'ActivityLog
        /// Autoscale', 'Log Analytics', 'Nagios', 'Platform', 'SCOM',
        /// 'ServiceHealth', 'SmartDetector', 'VM Insights', 'Zabbix'
        /// </param>
        /// <param name='impactedScope'>
        /// filter by impacted/target scope (provide comma separated list for
        /// multiple scopes). The value should be an well constructed ARM id of
        /// the scope.
        /// </param>
        /// <param name='description'>
        /// filter by alert rule description
        /// </param>
        /// <param name='alertRuleId'>
        /// filter by alert rule id
        /// </param>
        /// <param name='actionGroup'>
        /// filter by action group configured as part of action rule
        /// </param>
        /// <param name='name'>
        /// filter by action rule name
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ActionRule>,ActionRulesListByResourceGroupHeaders>> ListByResourceGroupWithHttpMessagesAsync(string resourceGroupName, string targetResourceGroup = default(string), string targetResourceType = default(string), string targetResource = default(string), string severity = default(string), string monitorService = default(string), string impactedScope = default(string), string description = default(string), string alertRuleId = default(string), string actionGroup = default(string), string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get action rule by name
        /// </summary>
        /// <remarks>
        /// Get a specific action rule
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group name where the resource is created.
        /// </param>
        /// <param name='actionRuleName'>
        /// The name of action rule that needs to be fetched
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ActionRule,ActionRulesGetByNameHeaders>> GetByNameWithHttpMessagesAsync(string resourceGroupName, string actionRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create/update an action rule
        /// </summary>
        /// <remarks>
        /// Creates/Updates a specific action rule
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group name where the resource is created.
        /// </param>
        /// <param name='actionRuleName'>
        /// The name of action rule that needs to be created/updated
        /// </param>
        /// <param name='actionRule'>
        /// action rule to be created/updated
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ActionRule,ActionRulesCreateUpdateHeaders>> CreateUpdateWithHttpMessagesAsync(string resourceGroupName, string actionRuleName, ActionRule actionRule, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete action rule
        /// </summary>
        /// <remarks>
        /// Deletes a given action rule
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group name where the resource is created.
        /// </param>
        /// <param name='actionRuleName'>
        /// The name that needs to be deleted
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<bool?,ActionRulesDeleteHeaders>> DeleteWithHttpMessagesAsync(string resourceGroupName, string actionRuleName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch action rule
        /// </summary>
        /// <remarks>
        /// Update enabled flag and/or tags for the given action rule
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// Resource group name where the resource is created.
        /// </param>
        /// <param name='actionRuleName'>
        /// The name that needs to be updated
        /// </param>
        /// <param name='actionRulePatch'>
        /// Parameters supplied to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<ActionRule,ActionRulesUpdateHeaders>> UpdateWithHttpMessagesAsync(string resourceGroupName, string actionRuleName, PatchObject actionRulePatch, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all action rule in a given subscription
        /// </summary>
        /// <remarks>
        /// List all action rules of the subscription and given input filters
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ActionRule>,ActionRulesListBySubscriptionHeaders>> ListBySubscriptionNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get all action rules created in a resource group
        /// </summary>
        /// <remarks>
        /// List all action rules of the subscription, created in given
        /// resource group and given input filters
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<ActionRule>,ActionRulesListByResourceGroupHeaders>> ListByResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
