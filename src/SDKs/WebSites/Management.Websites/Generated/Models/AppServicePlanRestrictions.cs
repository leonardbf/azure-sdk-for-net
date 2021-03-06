// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AppServicePlanRestrictions.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AppServicePlanRestrictions
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Free")]
        Free,
        [EnumMember(Value = "Shared")]
        Shared,
        [EnumMember(Value = "Basic")]
        Basic,
        [EnumMember(Value = "Standard")]
        Standard,
        [EnumMember(Value = "Premium")]
        Premium
    }
    internal static class AppServicePlanRestrictionsEnumExtension
    {
        internal static string ToSerializedValue(this AppServicePlanRestrictions? value)
        {
            return value == null ? null : ((AppServicePlanRestrictions)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AppServicePlanRestrictions value)
        {
            switch( value )
            {
                case AppServicePlanRestrictions.None:
                    return "None";
                case AppServicePlanRestrictions.Free:
                    return "Free";
                case AppServicePlanRestrictions.Shared:
                    return "Shared";
                case AppServicePlanRestrictions.Basic:
                    return "Basic";
                case AppServicePlanRestrictions.Standard:
                    return "Standard";
                case AppServicePlanRestrictions.Premium:
                    return "Premium";
            }
            return null;
        }

        internal static AppServicePlanRestrictions? ParseAppServicePlanRestrictions(this string value)
        {
            switch( value )
            {
                case "None":
                    return AppServicePlanRestrictions.None;
                case "Free":
                    return AppServicePlanRestrictions.Free;
                case "Shared":
                    return AppServicePlanRestrictions.Shared;
                case "Basic":
                    return AppServicePlanRestrictions.Basic;
                case "Standard":
                    return AppServicePlanRestrictions.Standard;
                case "Premium":
                    return AppServicePlanRestrictions.Premium;
            }
            return null;
        }
    }
}
