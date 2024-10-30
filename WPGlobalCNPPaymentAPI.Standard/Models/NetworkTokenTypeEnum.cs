// <copyright file="NetworkTokenTypeEnum.cs" company="APIMatic">
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
    /// NetworkTokenTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NetworkTokenTypeEnum
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined,

        /// <summary>
        /// VISA.
        /// </summary>
        [EnumMember(Value = "VISA")]
        VISA,

        /// <summary>
        /// MC.
        /// </summary>
        [EnumMember(Value = "MC")]
        MC,

        /// <summary>
        /// AMEX.
        /// </summary>
        [EnumMember(Value = "AMEX")]
        AMEX
    }
}