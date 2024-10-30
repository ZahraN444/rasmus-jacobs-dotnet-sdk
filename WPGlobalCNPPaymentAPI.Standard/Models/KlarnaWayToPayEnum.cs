// <copyright file="KlarnaWayToPayEnum.cs" company="APIMatic">
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
    /// KlarnaWayToPayEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum KlarnaWayToPayEnum
    {
        /// <summary>
        /// UNKNOWN.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// PAYNOW.
        /// </summary>
        [EnumMember(Value = "PAY_NOW")]
        PAYNOW,

        /// <summary>
        /// PAYLATER.
        /// </summary>
        [EnumMember(Value = "PAY_LATER")]
        PAYLATER,

        /// <summary>
        /// PAYOVERTIME.
        /// </summary>
        [EnumMember(Value = "PAY_OVER_TIME")]
        PAYOVERTIME
    }
}