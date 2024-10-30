// <copyright file="DirectDebitACHAccountTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using WPGlobalCNPPaymentAPI.Standard;
using WPGlobalCNPPaymentAPI.Standard.Utilities;

namespace WPGlobalCNPPaymentAPI.Standard.Models
{
    /// <summary>
    /// DirectDebitACHAccountTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectDebitACHAccountTypeEnum
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined,

        /// <summary>
        /// Checking.
        /// </summary>
        [EnumMember(Value = "checking")]
        Checking,

        /// <summary>
        /// Savings.
        /// </summary>
        [EnumMember(Value = "savings")]
        Savings,

        /// <summary>
        /// Corporate.
        /// </summary>
        [EnumMember(Value = "corporate")]
        Corporate,

        /// <summary>
        /// CorporateSavings.
        /// </summary>
        [EnumMember(Value = "corporateSavings")]
        CorporateSavings
    }
}