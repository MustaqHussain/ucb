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
    [MetadataTypeAttribute(typeof(ContentModel.ContentModelMetadata))]
    public partial class ContentModel
    {
    	public partial class ContentModelMetadata
    	{
    		[Key]
    		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_CONTENT_CODE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_CONTENT_CODE", ResourceType=typeof(Resources))]
    		public System.Guid Code {get; set;}
    
      		[Key]
    		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[StringLength(100)]
    		[Tooltip("TOOLTIP_CONTENT_NAME", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_CONTENT_NAME", ResourceType=typeof(Resources))]
    		public string Name {get; set;}
    
      		[Tooltip("TOOLTIP_CONTENT_VALUE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_CONTENT_VALUE", ResourceType=typeof(Resources))]
    		public string Value {get; set;}
    
      		[Key]
    		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[StringLength(20)]
    		[Tooltip("TOOLTIP_CONTENT_LOCALE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_CONTENT_LOCALE", ResourceType=typeof(Resources))]
    		public string Locale {get; set;}
    
        }
    }
}