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
    public partial class InterestedParty : IAuditable, IActiveAware 
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
    
        public virtual ICollection<IncidentInterestedParty> IncidentInterestedParty
        {
            get
            {
                if (_incidentInterestedParty == null)
                {
                    var newCollection = new FixupCollection<IncidentInterestedParty>();
                    newCollection.CollectionChanged += FixupIncidentInterestedParty;
                    _incidentInterestedParty = newCollection;
                }
                return _incidentInterestedParty;
            }
            set
            {
                if (!ReferenceEquals(_incidentInterestedParty, value))
                {
                    var previousValue = _incidentInterestedParty as FixupCollection<IncidentInterestedParty>;
                    if (previousValue != null)
                    {
                        previousValue.CollectionChanged -= FixupIncidentInterestedParty;
                    }
                    _incidentInterestedParty = value;
                    var newValue = value as FixupCollection<IncidentInterestedParty>;
                    if (newValue != null)
                    {
                        newValue.CollectionChanged += FixupIncidentInterestedParty;
                    }
                }
            }
        }
        private ICollection<IncidentInterestedParty> _incidentInterestedParty;

        #endregion
        #region Association Fixup
    
        private void FixupIncidentInterestedParty(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (IncidentInterestedParty item in e.NewItems)
                {
                    item.InterestedParty = this;
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (IncidentInterestedParty item in e.OldItems)
                {
                    if (ReferenceEquals(item.InterestedParty, this))
                    {
                        item.InterestedParty = null;
                    }
                }
            }
        }

        #endregion
    }
}
