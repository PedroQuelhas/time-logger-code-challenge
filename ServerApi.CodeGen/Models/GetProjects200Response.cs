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
    public class GetProjects200Response 
    {
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [Required]
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<ProjectDTO> Data { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [Required]
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public PaginationDTO Pagination { get; set; }

    }
}
