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
    [MetadataTypeAttribute(typeof(EventLeadingToIncidentModel.EventLeadingToIncidentModelMetadata))]
    public partial class EventLeadingToIncidentModel
    {
    	public partial class EventLeadingToIncidentModelMetadata
    	{
    		[Key]
    		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_EVENTLEADINGTOINCIDENT_CODE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_EVENTLEADINGTOINCIDENT_CODE", ResourceType=typeof(Resources))]
    		public System.Guid Code {get; set;}
    
      		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[StringLength(50)]
    		[Tooltip("TOOLTIP_EVENTLEADINGTOINCIDENT_DESCRIPTION", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_EVENTLEADINGTOINCIDENT_DESCRIPTION", ResourceType=typeof(Resources))]
    		public string Description {get; set;}
    
      		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_EVENTLEADINGTOINCIDENT_ISACTIVE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_EVENTLEADINGTOINCIDENT_ISACTIVE", ResourceType=typeof(Resources))]
    		public bool IsActive {get; set;}
    
        }
    }
}
