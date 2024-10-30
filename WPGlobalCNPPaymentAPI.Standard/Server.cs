// <copyright file="Server.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>

namespace WPGlobalCNPPaymentAPI.Standard
{
    /// <summary>
    /// Available servers.
    /// </summary>
    public enum Server
    {
        /// <summary>
        /// EdgeDiscovery.
        /// </summary>
        EdgeDiscovery,

        /// <summary>
        /// Thingspace.
        /// </summary>
        Thingspace,

        /// <summary>
        /// OauthServer.
        /// </summary>
        OauthServer,

        /// <summary>
        /// M2m.
        /// </summary>
        M2m,

        /// <summary>
        /// DeviceLocation.
        /// </summary>
        DeviceLocation,

        /// <summary>
        /// SubscriptionServer.
        /// </summary>
        SubscriptionServer,

        /// <summary>
        /// SoftwareManagementV1.
        /// </summary>
        SoftwareManagementV1,

        /// <summary>
        /// SoftwareManagementV2.
        /// </summary>
        SoftwareManagementV2,

        /// <summary>
        /// SoftwareManagementV3.
        /// </summary>
        SoftwareManagementV3,

        /// <summary>
        /// Performance.
        /// </summary>
        Performance,

        /// <summary>
        /// DeviceDiagnostics.
        /// </summary>
        DeviceDiagnostics,

        /// <summary>
        /// CloudConnector.
        /// </summary>
        CloudConnector,

        /// <summary>
        /// HyperPreciseLocation.
        /// </summary>
        HyperPreciseLocation,

        /// <summary>
        /// Services.
        /// </summary>
        Services,

        /// <summary>
        /// QualityOfService.
        /// </summary>
        QualityOfService,
    }
}
