﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using System.Management.Automation;
using Microsoft.Azure.Commands.EventGrid.Models;
using Microsoft.Azure.Management.EventGrid.Models;
using Microsoft.Azure.Commands.EventGrid.Utilities;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.EventGrid
{
    /// <summary>
    /// 'Get-AzureEventGridVerifiedPartner' Cmdlet gives the details of a / List of EventGrid verified partner(s)
    /// <para> If VerifiedPartner name provided, a single VerifiedPartner details will be returned</para>
    /// <para> If VerifiedPartner name not provided, list of VerifiedPartner will be returned</para>
    /// </summary>

    [Cmdlet(
        "Get",
        ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "EventGridVerifiedPartner",
        DefaultParameterSetName = VerifiedPartnerNameParameterSet),
    OutputType(typeof(PSVerifiedPartnerListInstance), typeof(PSVerifiedPartner))]


    public class GetAzureEventGridVerifiedPartner : AzureEventGridCmdletBase
    {
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "EventGrid Verified Partner Name.",
            ParameterSetName = VerifiedPartnerNameParameterSet)]
        public string Name { get; set; }

        [CmdletParameterBreakingChangeWithVersion("ODataQuery", "12.0.0", "2.0.0", ChangeDescription = "This parameter will be deprecated.")]
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = EventGridConstants.ODataQueryHelp,
            ParameterSetName = VerifiedPartnerNameParameterSet)]
        [ValidateNotNullOrEmpty]
        public string ODataQuery { get; set; }

        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = EventGridConstants.TopHelp,
            ParameterSetName = VerifiedPartnerNameParameterSet)]
        [ValidateRange(1, 100)]
        public int Top { get; set; }

        [CmdletParameterBreakingChangeWithVersion("NextLink", "12.0.0", "2.0.0", ChangeDescription = "This parameter will be deprecated.")]
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = EventGridConstants.NextLinkHelp,
            ParameterSetName = NextLinkParameterSet)]
        [ValidateNotNullOrEmpty]
        public string NextLink { get; set; }

        public override void ExecuteCmdlet()
        {
            string verifiedPartnerName = string.Empty;
            IEnumerable<VerifiedPartner> verifiedPartnersList;
            string newNextLink = null;
            int? providedTop = null;

            if (MyInvocation.BoundParameters.ContainsKey(nameof(this.Top)))
            {
                providedTop = this.Top;
            }

            if (!string.IsNullOrEmpty(this.Name))
            {
                verifiedPartnerName = this.Name;
            }

            if (!string.IsNullOrEmpty(this.NextLink))
            {
                // Get Next page of verified partners. Get the proper next API to be called based on the nextLink.
                Uri uri = new Uri(this.NextLink);
                string path = uri.AbsolutePath;

                (verifiedPartnersList, newNextLink) = this.Client.ListVerifiedPartnerNext(this.NextLink);
                PSVerifiedPartnerListPagedInstance psVerifiedPartnerListPagedInstance = new PSVerifiedPartnerListPagedInstance(verifiedPartnersList, newNextLink);
                this.WriteObject(psVerifiedPartnerListPagedInstance, true);
            }
            else if (!string.IsNullOrEmpty(verifiedPartnerName))
            {
                // Get details of a specific verified partner.
                VerifiedPartner verifiedPartner = this.Client.GetVerifiedParter(verifiedPartnerName);
                PSVerifiedPartner psVerifiedPartner = new PSVerifiedPartner(verifiedPartner);
                this.WriteObject(psVerifiedPartner);
            }
            else if (string.IsNullOrEmpty(verifiedPartnerName))
            {
                // List all verified partners in the current tenant
                (verifiedPartnersList, newNextLink) = this.Client.ListVerifiedPartners(this.ODataQuery, providedTop);
                PSVerifiedPartnerListPagedInstance psVerifiedPartnerListPagedInstance = new PSVerifiedPartnerListPagedInstance(verifiedPartnersList, newNextLink);
                this.WriteObject(psVerifiedPartnerListPagedInstance, true);
            }
        }
    }
}
