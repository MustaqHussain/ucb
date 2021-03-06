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
    [MetadataTypeAttribute(typeof(RelationshipToCustomerModel.RelationshipToCustomerModelMetadata))]
    public partial class RelationshipToCustomerModel
    {
    	public partial class RelationshipToCustomerModelMetadata
    	{
    		[Key]
    		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_RELATIONSHIPTOCUSTOMER_CODE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_RELATIONSHIPTOCUSTOMER_CODE", ResourceType=typeof(Resources))]
    		public System.Guid Code {get; set;}
    
      		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[StringLength(50)]
    		[Tooltip("TOOLTIP_RELATIONSHIPTOCUSTOMER_DESCRIPTION", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_RELATIONSHIPTOCUSTOMER_DESCRIPTION", ResourceType=typeof(Resources))]
    		public string Description {get; set;}
    
      		[Required(ErrorMessageResourceName = "VAL_REQUIRED", ErrorMessageResourceType = typeof(Resources))]
    		[Tooltip("TOOLTIP_RELATIONSHIPTOCUSTOMER_ISACTIVE", ResourceType=typeof(Resources))]
    		[Display(Name="LABEL_RELATIONSHIPTOCUSTOMER_ISACTIVE", ResourceType=typeof(Resources))]
    		public bool IsActive {get; set;}
    
        }
    }
}
