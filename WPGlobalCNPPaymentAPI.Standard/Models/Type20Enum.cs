// <copyright file="Type20Enum.cs" company="APIMatic">
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
    /// Type20Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Type20Enum
    {
        /// <summary>
        /// EnumWalletgooglepay.
        /// </summary>
        [EnumMember(Value = "wallet/googlepay")]
        EnumWalletgooglepay
    }
}