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
    [MetadataTypeAttribute(typeof(Content.ContentMetadata))]
    public partial class Content : IContent
    {
    	public partial class ContentMetadata
    	{
    		[Key]
    		public System.Guid Code{get; set;}
    		[Key]
    		public string Name{get; set;}
    		[Key]
    		public string Locale{get; set;}
    		[Key]
    		public byte[] RowIdentifier{get; set;}
    		}
    }
}
