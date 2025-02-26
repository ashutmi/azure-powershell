
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
The operation to create or update the run command.
.Description
The operation to create or update the run command.
.Example
Set-AzVMRunCommand -ResourceGroupName MyRG0 -VMName MyVMEE -RunCommandName MyRunCommand -Location EastUS2EUAP -SourceScriptUri "https://myst.blob.core.windows.net/mycontainer/myscript.ps1?sp=r&st=2022-10-27T21:02:35Z&se=2022-10-28T05:02:35Z&spr=https&sv=2021-06-08&sr=b&sig=0I%2FIiYayRwHasfasasfdasdfasdeTsQjLnpZjA%3D"
.Example
Set-AzVMRunCommand -ResourceGroupName MyRG0 -VMName MyVMEE -RunCommandName MyRunCommand -Location EastUS2EUAP -ScriptLocalPath "C:\MyScriptsDir\MyScript.ps1"
.Example
Set-AzVMRunCommand -ResourceGroupName MyRG0 -VMName MyVML -RunCommandName MyRunCommand2 -Location EastUS2EUAP -SourceScript "id; echo HelloWorld"
.Example
Set-AzVMRunCommand -ResourceGroupName MyRG0 -VMName MyVMEE -RunCommandName MyRunCommand -Location EastUS2EUAP -SourceCommandId DisableWindowsUpdate
.Example
Set-AzVMRunCommand -ResourceGroupName MyRG0 -VMName MyVML -RunCommandName MyRunCommand3 -Location EastUS2EUAP -ScriptLocalPath "C:\MyScriptsDir\MyScript.ps1" -OutputBlobUri "https://vivst.blob.core.windows.net/vivcontainer/output.txt?sp=racw&st=2022-10-27T22:18:36Z&se=2022-10-28T06:18:36Z&spr=https&sv=2021-06-08&sr=b&sig=HQAu3Bl%2BKMofYTjMo8o5hasfadsfasdF4jIkRJra4S5FlEo%3D" -ErrorBlobUri "https://vivst.blob.core.windows.net/vivcontainer/error.txt?sp=racw&st=2022-10-27T22:18:36Z&se=2022-10-28T06:18:36Z&spr=https&sv=2021-06-08&sr=b&sig=HQAu3Bl%2BKMofYTjMo8o5h%asfasdfgdT%2F4jasfasdf5FlEo%3D"
.Example
Set-AzVMRunCommand -ResourceGroupName MyRG0 -VMName MyVMEE -RunCommandName MyRunCommand -Location EastUS2EUAP -ScriptLocalPath "C:\MyScriptsDir\MyScript.ps1" -RunAsUser myusername -RunAsPassword mypassword

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IVirtualMachineRunCommand
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

PARAMETER <IRunCommandInputParameter[]>: The parameters used by the script.
  Name <String>: The run command parameter name.
  Value <String>: The run command parameter value.

PROTECTEDPARAMETER <IRunCommandInputParameter[]>: The parameters used by the script.
  Name <String>: The run command parameter name.
  Value <String>: The run command parameter value.
.Link
https://learn.microsoft.com/powershell/module/az.compute/set-azvmruncommand
#>
function Set-AzVMRunCommand {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IVirtualMachineRunCommand])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [System.String]
    # The name of the resource group.
    ${ResourceGroupName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [System.String]
    # The name of the virtual machine run command.
    ${RunCommandName},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [System.String]
    # The name of the virtual machine where the run command should be created or updated.
    ${VMName},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # Subscription credentials which uniquely identify Microsoft Azure subscription.
    # The subscription ID forms part of the URI for every service call.
    ${SubscriptionId},

    [Parameter(Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Resource location
    ${Location},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Optional.
    # If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
    ${AsyncExecution},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Client Id (GUID value) of the user-assigned managed identity.
    # ObjectId should not be used if this is provided.
    ${ErrorBlobManagedIdentityClientId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Object Id (GUID value) of the user-assigned managed identity.
    # ClientId should not be used if this is provided.
    ${ErrorBlobManagedIdentityObjectId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Specifies the Azure storage blob where script error stream will be uploaded.
    # Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob.
    # Refer errorBlobManagedIdentity parameter.
    ${ErrorBlobUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Client Id (GUID value) of the user-assigned managed identity.
    # ObjectId should not be used if this is provided.
    ${OutputBlobManagedIdentityClientId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Object Id (GUID value) of the user-assigned managed identity.
    # ClientId should not be used if this is provided.
    ${OutputBlobManagedIdentityObjectId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Specifies the Azure storage blob where script output stream will be uploaded.
    # Use a SAS URI with read, append, create, write access OR use managed identity to provide the VM access to the blob.
    # Refer outputBlobManagedIdentity parameter.
    ${OutputBlobUri},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandInputParameter[]]
    # The parameters used by the script.
    # To construct, see NOTES section for PARAMETER properties and create a hash table.
    ${Parameter},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20230701.IRunCommandInputParameter[]]
    # The parameters used by the script.
    # To construct, see NOTES section for PROTECTEDPARAMETER properties and create a hash table.
    ${ProtectedParameter},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Specifies the user account password on the VM when executing the run command.
    ${RunAsPassword},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Specifies the user account on the VM when executing the run command.
    ${RunAsUser},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Client Id (GUID value) of the user-assigned managed identity.
    # ObjectId should not be used if this is provided.
    ${ScriptUriManagedIdentityClientId},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Object Id (GUID value) of the user-assigned managed identity.
    # ClientId should not be used if this is provided.
    ${ScriptUriManagedIdentityObjectId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Specifies a commandId of predefined built-in script.
    ${SourceCommandId},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Specifies the script content to be executed on the VM.
    ${SourceScript},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    # Specifies the script download location.
    # It can be either SAS URI of an Azure storage blob with read access or public URI.
    ${SourceScriptUri},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Info(PossibleTypes=([Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IResourceTags]))]
    [System.Collections.Hashtable]
    # Resource tags
    ${Tag},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.Int32]
    # The timeout in seconds to execute the run command.
    ${TimeoutInSecond},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.Management.Automation.SwitchParameter]
    # Optional.
    # If set to true, any failure in the script will fail the deployment and ProvisioningState will be marked as Failed.
    # If set to false, ProvisioningState would only reflect whether the run command was run or not by the extensions platform, it would not indicate whether script failed in case of script failures.
    # See instance view of run command in case of script failures to see executionMessage, output, error: https://aka.ms/runcommandmanaged#get-execution-status-and-results
    ${TreatFailureAsDeploymentFailure},

    [Parameter(ParameterSetName='ScriptLocalPath', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Body')]
    [System.String]
    ${ScriptLocalPath},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The DefaultProfile parameter is not functional.
    # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
    ${DefaultProfile},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Run the command asynchronously
    ${NoWait},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.Compute.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $PSVersionTable.PSVersion.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.Compute.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            UpdateExpanded = 'Az.Compute.private\Set-AzVMRunCommand_UpdateExpanded';
            ScriptLocalPath = 'Az.Compute.custom\Set-AzVMRunCommand_ScriptLocalPath';
        }
        if (('UpdateExpanded', 'ScriptLocalPath') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $testPlayback = $false
            $PSBoundParameters['HttpPipelinePrepend'] | Foreach-Object { if ($_) { $testPlayback = $testPlayback -or ('Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PipelineMock' -eq $_.Target.GetType().FullName -and 'Playback' -eq $_.Target.Mode) } }
            if ($testPlayback) {
                $PSBoundParameters['SubscriptionId'] = . (Join-Path $PSScriptRoot '..' 'utils' 'Get-SubscriptionIdTestSafe.ps1')
            } else {
                $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
            }
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        if ($null -ne $MyInvocation.MyCommand -and [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets -notcontains $MyInvocation.MyCommand.Name -and [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.MessageAttributeHelper]::ContainsPreviewAttribute($cmdInfo, $MyInvocation)){
            [Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.MessageAttributeHelper]::ProcessPreviewMessageAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PromptedPreviewMessageCmdlets.Enqueue($MyInvocation.MyCommand.Name)
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.Compute.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
