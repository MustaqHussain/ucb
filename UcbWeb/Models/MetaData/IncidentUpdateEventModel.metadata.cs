//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using Dwp.Adep.Ucb.ResourceLibrary;
using UcbWeb.DataAnnotation;

namespace UcbWeb.Models
{
    [MetadataTypeAttribute(typeof(IncidentUpdateEventModel.IncidentUpdateEventModelMetadata))]
    public partial class IncidentUpdateEventModel
    {
    	public partial class IncidentUpdateEventModelMetadata
    	{
    		[Key]
    		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_INCIDENTUPDATEEVENT_CODE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_INCIDENTUPDATEEVENT_CODE", ResourceType=typeof(Resources))]
    		public System.Guid Code {get; set;}
    
      		[StringLength(20)]
    		[Tooltip("TOOLTIP_INCIDENTUPDATEEVENT_TYPE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_INCIDENTUPDATEEVENT_TYPE", ResourceType=typeof(Resources))]
    		public string Type {get; set;}
    
      		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_INCIDENTUPDATEEVENT_INCIDENTCODE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_INCIDENTUPDATEEVENT_INCIDENTCODE", ResourceType=typeof(Resources))]
    		public System.Guid IncidentCode {get; set;}
    
      		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_INCIDENTUPDATEEVENT_DATETIME", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_INCIDENTUPDATEEVENT_DATETIME", ResourceType=typeof(Resources))]
    		public System.DateTime DateTime {get; set;}
    
      		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[StringLength(50)]
    		[Tooltip("TOOLTIP_INCIDENTUPDATEEVENT_UPDATEBY", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_INCIDENTUPDATEEVENT_UPDATEBY", ResourceType=typeof(Resources))]
    		public string UpdateBy {get; set;}
    
        }
    }
}