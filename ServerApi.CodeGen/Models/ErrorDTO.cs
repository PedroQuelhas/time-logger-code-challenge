/*
 * Timelogger API
 *
 * CRUD management of timelogger
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using ServerApi.CodeGen.Converters;

namespace ServerApi.CodeGen.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ErrorDTO 
    {
        /// <summary>
        /// A human readable error message
        /// </summary>
        /// <value>A human readable error message</value>
        [Required]
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

    }
}