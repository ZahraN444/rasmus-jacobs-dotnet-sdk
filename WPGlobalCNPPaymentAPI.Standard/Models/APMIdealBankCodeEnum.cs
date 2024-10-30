// <copyright file="APMIdealBankCodeEnum.cs" company="APIMatic">
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
    /// APMIdealBankCodeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum APMIdealBankCodeEnum
    {
        /// <summary>
        /// Undefined.
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined,

        /// <summary>
        /// ABNAMRO.
        /// </summary>
        [EnumMember(Value = "ABN_AMRO")]
        ABNAMRO,

        /// <summary>
        /// ASN.
        /// </summary>
        [EnumMember(Value = "ASN")]
        ASN,

        /// <summary>
        /// BUNQ.
        /// </summary>
        [EnumMember(Value = "BUNQ")]
        BUNQ,

        /// <summary>
        /// ING.
        /// </summary>
        [EnumMember(Value = "ING")]
        ING,

        /// <summary>
        /// KNAB.
        /// </summary>
        [EnumMember(Value = "KNAB")]
        KNAB,

        /// <summary>
        /// RABOBANK.
        /// </summary>
        [EnumMember(Value = "RABOBANK")]
        RABOBANK,

        /// <summary>
        /// REVOLUT.
        /// </summary>
        [EnumMember(Value = "REVOLUT")]
        REVOLUT,

        /// <summary>
        /// SNS.
        /// </summary>
        [EnumMember(Value = "SNS")]
        SNS,

        /// <summary>
        /// SNSREGIO.
        /// </summary>
        [EnumMember(Value = "SNS_REGIO")]
        SNSREGIO,

        /// <summary>
        /// TRIODOS.
        /// </summary>
        [EnumMember(Value = "TRIODOS")]
        TRIODOS,

        /// <summary>
        /// VANLANSCHOT.
        /// </summary>
        [EnumMember(Value = "VAN_LANSCHOT")]
        VANLANSCHOT
    }
}