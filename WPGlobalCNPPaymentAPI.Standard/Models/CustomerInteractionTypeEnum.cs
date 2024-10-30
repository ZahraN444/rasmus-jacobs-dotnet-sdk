// <copyright file="CustomerInteractionTypeEnum.cs" company="APIMatic">
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
    /// CustomerInteractionTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerInteractionTypeEnum
    {
        /// <summary>
        /// ECOMMERCE.
        /// </summary>
        [EnumMember(Value = "ECOMMERCE")]
        ECOMMERCE,

        /// <summary>
        /// MOTO.
        /// </summary>
        [EnumMember(Value = "MOTO")]
        MOTO
    }
}