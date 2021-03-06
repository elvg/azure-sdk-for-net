// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// VirtualMachineScaleSetsOperations operations.
    /// </summary>
    public partial interface IVirtualMachineScaleSetsOperations
    {
        /// <summary>
        /// Allows you to create or update a virtual machine scale set by
        /// providing parameters or a path to pre-configured parameter file.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// Parameters supplied to the Create Virtual Machine Scale Set
        /// operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Virtual Machine Scale Set
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineScaleSet>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string name, VirtualMachineScaleSet parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to create or update a virtual machine scale set by
        /// providing parameters or a path to pre-configured parameter file.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='name'>
        /// Parameters supplied to the Create Virtual Machine Scale Set
        /// operation.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Virtual Machine Scale Set
        /// operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineScaleSet>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string name, VirtualMachineScaleSet parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to deallocate virtual machines in a virtual machine
        /// scale set. Shuts down the virtual machines and releases the
        /// compute resources. You are not billed for the compute resources
        /// that this virtual machine scale set uses.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeallocateWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to deallocate virtual machines in a virtual machine
        /// scale set. Shuts down the virtual machines and releases the
        /// compute resources. You are not billed for the compute resources
        /// that this virtual machine scale set uses.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeallocateWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to delete a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to delete a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Display information about a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineScaleSet>> GetWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to delete virtual machines in a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> DeleteInstancesWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to delete virtual machines in a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginDeleteInstancesWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Displays status of a virtual machine scale set instance.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<VirtualMachineScaleSetInstanceView>> GetInstanceViewWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all virtual machine scale sets under a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSet>>> ListWithHttpMessagesAsync(string resourceGroupName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all Virtual Machine Scale Sets in the subscription. Use
        /// nextLink property in the response to get the next page of Virtual
        /// Machine Scale Sets. Do this till nextLink is not null to fetch
        /// all the Virtual Machine Scale Sets.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSet>>> ListAllWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Displays available skus for your virtual machine scale set
        /// including the minimum and maximum vm instances allowed for a
        /// particular sku.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSetSku>>> ListSkusWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to power off (stop) virtual machines in a virtual
        /// machine scale set. Note that resources are still attached and you
        /// are getting charged for the resources. Use deallocate to release
        /// resources.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> PowerOffWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to power off (stop) virtual machines in a virtual
        /// machine scale set. Note that resources are still attached and you
        /// are getting charged for the resources. Use deallocate to release
        /// resources.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginPowerOffWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to restart virtual machines in a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> RestartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to restart virtual machines in a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginRestartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to start virtual machines in a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> StartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to start virtual machines in a virtual machine scale
        /// set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginStartWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to manually upgrade virtual machines in a virtual
        /// machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> UpdateInstancesWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to manually upgrade virtual machines in a virtual
        /// machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='instanceIds'>
        /// the virtual machine scale set instance ids.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginUpdateInstancesWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, IList<string> instanceIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to re-image(update the version of the installed
        /// operating system) virtual machines in a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> ReimageWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Allows you to re-image(update the version of the installed
        /// operating system) virtual machines in a virtual machine scale set.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='vmScaleSetName'>
        /// The name of the virtual machine scale set.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse> BeginReimageWithHttpMessagesAsync(string resourceGroupName, string vmScaleSetName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all virtual machine scale sets under a resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSet>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Lists all Virtual Machine Scale Sets in the subscription. Use
        /// nextLink property in the response to get the next page of Virtual
        /// Machine Scale Sets. Do this till nextLink is not null to fetch
        /// all the Virtual Machine Scale Sets.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSet>>> ListAllNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Displays available skus for your virtual machine scale set
        /// including the minimum and maximum vm instances allowed for a
        /// particular sku.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<IPage<VirtualMachineScaleSetSku>>> ListSkusNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
