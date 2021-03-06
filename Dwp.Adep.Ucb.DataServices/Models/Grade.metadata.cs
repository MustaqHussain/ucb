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
    [MetadataTypeAttribute(typeof(Grade.GradeMetadata))]
    public partial class Grade : IGrade
    {
    	public partial class GradeMetadata
    	{
    		[Key]
    		public System.Guid Code{get; set;}
    	
    		[Association("FK_Staff_Grade", "Code", "GradeCode", IsForeignKey = false)]
    		public virtual ICollection<Staff> Staff
    		{get; set;}
    
    	
    		[Association("FK_Grade_Organisation", "SecurityLabel", "Code", IsForeignKey = true)]
    		public virtual Organisation Organisation
    		{get; set;}
    
    		}
    }
}
