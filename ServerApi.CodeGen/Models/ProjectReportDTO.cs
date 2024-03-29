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
    public class ProjectReportDTO 
    {
        /// <summary>
        /// The unique identifier
        /// </summary>
        /// <value>The unique identifier</value>
        [Required]
        [DataMember(Name="project_id", EmitDefaultValue=false)]
        public Guid ProjectId { get; set; }

        /// <summary>
        /// Gets or Sets ProjectName
        /// </summary>
        [Required]
        [DataMember(Name="project_name", EmitDefaultValue=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [Required]
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets Deadline
        /// </summary>
        [DataMember(Name="deadline", EmitDefaultValue=false)]
        public string Deadline { get; set; }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=true)]
        public bool Completed { get; set; }

        /// <summary>
        /// Gets or Sets TotalTime
        /// </summary>
        [Required]
        [DataMember(Name="total_time", EmitDefaultValue=true)]
        public int TotalTime { get; set; }

        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [Required]
        [DataMember(Name="total_records", EmitDefaultValue=true)]
        public int TotalRecords { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name="customer_name", EmitDefaultValue=false)]
        public string CustomerName { get; set; }

    }
}
