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
using System.Runtime.Serialization;

namespace Dwp.Adep.Ucb.WebServices.DataContracts
{
    [DataContract]
    public partial class AuditSearchCriteriaDC
    {
    
    	[DataMember]
        public virtual string TypeOfObject
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string AuditAction
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string ObjectCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.DateTime> DateUpdated
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string ChangedBy
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string AuditText
        {
    	    get;
            set;
        }
    }
}
