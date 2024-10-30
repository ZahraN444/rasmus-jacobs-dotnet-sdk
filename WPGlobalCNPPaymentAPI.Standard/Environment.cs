// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WPGlobalCNPPaymentAPI.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// Production.
        /// </summary>
        [EnumMember(Value = "Production")]
        Production,

        /// <summary>
        /// Staging.
        /// </summary>
        [EnumMember(Value = "Staging")]
        Staging,

        /// <summary>
        /// Dev.
        /// </summary>
        [EnumMember(Value = "Dev")]
        Dev,

        /// <summary>
        /// Qa.
        /// </summary>
        [EnumMember(Value = "Qa")]
        Qa,

        /// <summary>
        /// MockServerOnlyAvailableForThingspaceM2mAPIs.
        /// </summary>
        [EnumMember(Value = "Mock Server (only available for Thingspace M2M APIs)")]
        MockServerOnlyAvailableForThingspaceM2mAPIs,
    }
}
