// <copyright file="Type8Enum.cs" company="APIMatic">
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
    /// Type8Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type8Enum
    {
        /// <summary>
        /// EnumCardschemeEncrypted.
        /// </summary>
        [EnumMember(Value = "card/scheme_encrypted")]
        EnumCardschemeEncrypted
    }
}