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

namespace Dwp.Adep.Ucb.DataServices.Models
{
    [MetadataTypeAttribute(typeof(ContingencyArrangement.ContingencyArrangementMetadata))]
    public partial class ContingencyArrangement : IContingencyArrangement
    {
    	public partial class ContingencyArrangementMetadata
    	{
    		[Key]
    		public System.Guid Code{get; set;}
    	
    		[Association("FK_CustomerContingencyArrangement_ContingencyArrangement", "Code", "ContingencyArrangementCode", IsForeignKey = false)]
    		public virtual ICollection<CustomerContingencyArrangement> CustomerContingencyArrangement
    		{get; set;}
    
    		}
    }
}
