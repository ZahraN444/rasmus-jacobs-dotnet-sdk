// <copyright file="CurrencyCodeEnum.cs" company="APIMatic">
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
    /// CurrencyCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CurrencyCodeEnum
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined,

        /// <summary>
        /// CAD.
        /// </summary>
        [EnumMember(Value = "CAD")]
        CAD,

        /// <summary>
        /// EUR.
        /// </summary>
        [EnumMember(Value = "EUR")]
        EUR,

        /// <summary>
        /// GBP.
        /// </summary>
        [EnumMember(Value = "GBP")]
        GBP,

        /// <summary>
        /// USD.
        /// </summary>
        [EnumMember(Value = "USD")]
        USD
    }
}