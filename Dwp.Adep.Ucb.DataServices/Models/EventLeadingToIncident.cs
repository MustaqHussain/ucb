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
    public partial class EventLeadingToIncident : IAuditable, IActiveAware 
    {
        #region Primitive Properties
    
        public virtual System.Guid Code
        {
            get;
            set;
        }
    
        public virtual string Description
        {
            get;
            set;
        }
    
        public virtual bool IsActive
        {
            get;
            set;
        }
    
        public virtual byte[] RowIdentifier
        {
            get;
            set;
        }

        #endregion
        #region Navigation Properties
    
        public virtual ICollection<Incident> Incident
        {
            get
            {
                if (_incident == null)
                {
                    var newCollection = new FixupCollection<Incident>();
                    newCollection.CollectionChanged += FixupIncident;
                    _incident = newCollection;
                }
                return _incident;
            }
            set
            {
                if (!ReferenceEquals(_incident, value))
                {
                    var previousValue = _incident as FixupCollection<Incident>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupIncident;
                    }
                    _incident = value;
                    var newValue = value as FixupCollection<Incident>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupIncident;
                    }
                }
            }
        }
        private ICollection<Incident> _incident;

        #endregion
        #region Association Fixup
    
        private void FixupIncident(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Incident item in e.NewItems)
                {
                    item.EventLeadingToIncident = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Incident item in e.OldItems)
                {
                    if (ReferenceEquals(item.EventLeadingToIncident, this))
                    {
                        item.EventLeadingToIncident = null;
                    }
                }
            }
        }

        #endregion
    }
}