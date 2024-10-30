// <copyright file="Type13Enum.cs" company="APIMatic">
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
    /// Type13Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type13Enum
    {
        /// <summary>
        /// EnumIndustrylodging.
        /// </summary>
        [EnumMember(Value = "industry/lodging")]
        EnumIndustrylodging
    }
}