// <copyright file="Type12Enum.cs" company="APIMatic">
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
    /// Type12Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type12Enum
    {
        /// <summary>
        /// EnumIndustrylevel23.
        /// </summary>
        [EnumMember(Value = "industry/level2_3")]
        EnumIndustrylevel23
    }
}