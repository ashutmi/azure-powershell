// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Extensions;

    /// <summary>Properties of the NewRelic account</summary>
    public partial class NewRelicAccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicAccountProperties,
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicAccountPropertiesInternal
    {

        /// <summary>Backing field for <see cref="AccountInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfo _accountInfo;

        /// <summary>NewRelic Account Information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfo AccountInfo { get => (this._accountInfo = this._accountInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.AccountInfo()); set => this._accountInfo = value; }

        /// <summary>Account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string AccountInfoAccountId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfoInternal)AccountInfo).AccountId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfoInternal)AccountInfo).AccountId = value ?? null; }

        /// <summary>ingestion key of account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public System.Security.SecureString AccountInfoIngestionKey { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfoInternal)AccountInfo).IngestionKey; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfoInternal)AccountInfo).IngestionKey = value ?? null; }

        /// <summary>NewRelic account region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string AccountInfoRegion { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfoInternal)AccountInfo).Region; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfoInternal)AccountInfo).Region = value ?? null; }

        /// <summary>Internal Acessors for AccountInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfo Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicAccountPropertiesInternal.AccountInfo { get => (this._accountInfo = this._accountInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.AccountInfo()); set { {_accountInfo = value;} } }

        /// <summary>Internal Acessors for OrganizationInfo</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IOrganizationInfo Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicAccountPropertiesInternal.OrganizationInfo { get => (this._organizationInfo = this._organizationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.OrganizationInfo()); set { {_organizationInfo = value;} } }

        /// <summary>Internal Acessors for SingleSignOnProperty</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnProperties Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicAccountPropertiesInternal.SingleSignOnProperty { get => (this._singleSignOnProperty = this._singleSignOnProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.NewRelicSingleSignOnProperties()); set { {_singleSignOnProperty = value;} } }

        /// <summary>Backing field for <see cref="OrganizationInfo" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IOrganizationInfo _organizationInfo;

        /// <summary>NewRelic Organization Information</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IOrganizationInfo OrganizationInfo { get => (this._organizationInfo = this._organizationInfo ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.OrganizationInfo()); set => this._organizationInfo = value; }

        /// <summary>Organization id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string OrganizationInfoOrganizationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IOrganizationInfoInternal)OrganizationInfo).OrganizationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IOrganizationInfoInternal)OrganizationInfo).OrganizationId = value ?? null; }

        /// <summary>Backing field for <see cref="SingleSignOnProperty" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnProperties _singleSignOnProperty;

        /// <summary>date when plan was applied</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnProperties SingleSignOnProperty { get => (this._singleSignOnProperty = this._singleSignOnProperty ?? new Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.NewRelicSingleSignOnProperties()); set => this._singleSignOnProperty = value; }

        /// <summary>The Id of the Enterprise App used for Single sign-on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertyEnterpriseAppId { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).EnterpriseAppId; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).EnterpriseAppId = value ?? null; }

        /// <summary>Provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState? SingleSignOnPropertyProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).ProvisioningState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState)""); }

        /// <summary>Single sign-on state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SingleSignOnStates? SingleSignOnPropertySingleSignOnState { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnState; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SingleSignOnStates)""); }

        /// <summary>The login URL specific to this NewRelic Organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Inlined)]
        public string SingleSignOnPropertySingleSignOnUrl { get => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnUrl; set => ((Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnPropertiesInternal)SingleSignOnProperty).SingleSignOnUrl = value ?? null; }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>User id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Origin(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.PropertyOrigin.Owned)]
        public string UserId { get => this._userId; set => this._userId = value; }

        /// <summary>Creates an new <see cref="NewRelicAccountProperties" /> instance.</summary>
        public NewRelicAccountProperties()
        {

        }
    }
    /// Properties of the NewRelic account
    public partial interface INewRelicAccountProperties :
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.IJsonSerializable
    {
        /// <summary>Account id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Account id",
        SerializedName = @"accountId",
        PossibleTypes = new [] { typeof(string) })]
        string AccountInfoAccountId { get; set; }
        /// <summary>ingestion key of account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ingestion key of account",
        SerializedName = @"ingestionKey",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AccountInfoIngestionKey { get; set; }
        /// <summary>NewRelic account region</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"NewRelic account region",
        SerializedName = @"region",
        PossibleTypes = new [] { typeof(string) })]
        string AccountInfoRegion { get; set; }
        /// <summary>Organization id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Organization id",
        SerializedName = @"organizationId",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationInfoOrganizationId { get; set; }
        /// <summary>The Id of the Enterprise App used for Single sign-on.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the Enterprise App used for Single sign-on.",
        SerializedName = @"enterpriseAppId",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>Provisioning state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Provisioning state",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState? SingleSignOnPropertyProvisioningState { get; set; }
        /// <summary>Single sign-on state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Single sign-on state",
        SerializedName = @"singleSignOnState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SingleSignOnStates) })]
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SingleSignOnStates? SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>The login URL specific to this NewRelic Organization</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The login URL specific to this NewRelic Organization",
        SerializedName = @"singleSignOnUrl",
        PossibleTypes = new [] { typeof(string) })]
        string SingleSignOnPropertySingleSignOnUrl { get; set; }
        /// <summary>User id</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"User id",
        SerializedName = @"userId",
        PossibleTypes = new [] { typeof(string) })]
        string UserId { get; set; }

    }
    /// Properties of the NewRelic account
    internal partial interface INewRelicAccountPropertiesInternal

    {
        /// <summary>NewRelic Account Information</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IAccountInfo AccountInfo { get; set; }
        /// <summary>Account id</summary>
        string AccountInfoAccountId { get; set; }
        /// <summary>ingestion key of account</summary>
        System.Security.SecureString AccountInfoIngestionKey { get; set; }
        /// <summary>NewRelic account region</summary>
        string AccountInfoRegion { get; set; }
        /// <summary>NewRelic Organization Information</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.IOrganizationInfo OrganizationInfo { get; set; }
        /// <summary>Organization id</summary>
        string OrganizationInfoOrganizationId { get; set; }
        /// <summary>date when plan was applied</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Models.Api20220701.INewRelicSingleSignOnProperties SingleSignOnProperty { get; set; }
        /// <summary>The Id of the Enterprise App used for Single sign-on.</summary>
        string SingleSignOnPropertyEnterpriseAppId { get; set; }
        /// <summary>Provisioning state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.ProvisioningState? SingleSignOnPropertyProvisioningState { get; set; }
        /// <summary>Single sign-on state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.NewRelic.Support.SingleSignOnStates? SingleSignOnPropertySingleSignOnState { get; set; }
        /// <summary>The login URL specific to this NewRelic Organization</summary>
        string SingleSignOnPropertySingleSignOnUrl { get; set; }
        /// <summary>User id</summary>
        string UserId { get; set; }

    }
}