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
    public partial class IncidentSearchCriteriaDC
    {
    
    	[DataMember]
        public virtual int IncidentID
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string Type
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> ReferrerCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string Referrer
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IncidentStatus
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string StaffMemberTitle
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string StaffMemberOtherTitle
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string StaffMemberFirstName
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string StaffMemberLastName
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> JobRoleCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string JobRole
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual System.Guid StaffMemberHomeOfficeSiteCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string StaffMemberHomeOfficeSite
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IsStaffHadAppropriateTraining
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<int> StaffMemberYearsInCurrentPost
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<int> StaffMemberMonthsInCurrentRole
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string ManagerFirstName
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string ManagerLastName
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual System.DateTime IncidentDate
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual int FiscalYear
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual int FiscalQuarter
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual int FiscalMonth
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string FiscalMonthAsText
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IncidentTime
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> CustomerCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string Customer
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual bool IsOthersPresent
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string OthersPresent
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> EventLeadingToIncidentCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string EventLeadingToIncident
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> IncidentLocationCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IncidentLocation
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual System.Guid IncidentCategoryCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IncidentCategory
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> IncidentTypeCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IncidentType
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> IncidentDetailsCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IncidentDetails
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> AbuseTypeCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string AbuseType
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> IncidentNarrativeCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string IncidentNarrative
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsLineManageFastTrack
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsLineManagerRIDDOR
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsPoliceCalled
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> HasLineManagerReadReport
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> LineManagerNarrativeCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string LineManagerNarrative
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsNominatedFastTrack
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsNominatedRIDDOR
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsOralWarning
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.DateTime> OralWarningDate
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsWrittenWarning
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.DateTime> WrittenWarningDate
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsAssailantInterviewed
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.DateTime> AssailantInterviewedDate
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsSolicitorLetter
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.DateTime> SolicitorLetterDate
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsBanningOrder
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.DateTime> BanningOrderRequestedDate
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> FurtherInfoNarrativeCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string FurtherInfoNarrative
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsDeficienciesInProcess
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsImplementControlMeasures
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string NamedOfficer
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string TelephoneContactNumber
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsITMarkersSet
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsPapersMarked
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsNotifiedParties
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.DateTime> ReviewDate
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsPreviousEvidenceReviewed
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsPreviousPartiesNotified
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsRepeatBehaviour
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<bool> IsControlMeasuresStillApply
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual System.Guid SiteCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string Site
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<int> NumberOfRecords
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> DeficienciesNarrativeCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string DeficienciesNarrative
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string OtherIncidentLocation
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> CurrentOwnerStaffCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string CurrentOwnerStaff
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string ManagerTelephoneContactNumber
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual Nullable<System.Guid> ReviewActionNarrativeCode
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string ReviewActionNarrative
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string BannedFromOffices
        {
    	    get;
            set;
        }
    
    	[DataMember]
        public virtual string BannedFromOfficesEndDate
        {
    	    get;
            set;
        }
    }
}
