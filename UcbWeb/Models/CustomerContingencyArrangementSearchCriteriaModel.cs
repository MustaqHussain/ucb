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

namespace UcbWeb.Models
{
    public partial class CustomerContingencyArrangementSearchCriteriaModel
    {
    
        public virtual System.Guid CustomerCode
        {
    	    get;
            set;
        }
    
        public virtual string Customer
        {
    	    get;
            set;
        }
    
        public virtual System.Guid ContingencyArrangementCode
        {
    	    get;
            set;
        }
    
        public virtual string ContingencyArrangement
        {
    	    get;
            set;
        }
    }
}