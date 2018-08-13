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
using System.ServiceModel;
using Dwp.Adep.Ucb.WebServices.DataContracts;
using Dwp.Adep.Ucb.WebServices.FaultContracts;

namespace Dwp.Adep.Ucb.WebServices.ServiceContracts
{
    public partial interface IUcbService
    {
        #region Behaviour for ApplicationOrganisationTypeGroup
    
    	[FaultContract(typeof(UniqueConstraintFault))]
    	[FaultContract(typeof(DataIntegrityFault))]
    	[FaultContract(typeof(ServiceErrorFault))]
    	[OperationContract]
    	ApplicationOrganisationTypeGroupVMDC CreateApplicationOrganisationTypeGroup(string userName, string currentUserName, string appID, string overrideID, ApplicationOrganisationTypeGroupDC dc);
    
    	[FaultContract(typeof(ServiceErrorFault))]
    	[OperationContract]
    	ApplicationOrganisationTypeGroupVMDC GetApplicationOrganisationTypeGroup(string userName, string currentUserName, string appID, string overrideID, string code);
    
    	[FaultContract(typeof(ServiceErrorFault))]
    	[OperationContract]
    	List<ApplicationOrganisationTypeGroupDC> GetAllApplicationOrganisationTypeGroup(string userName, string currentUserName, string appID, string overrideID, bool includeInActive);
    
    	[FaultContract(typeof(ServiceErrorFault))]
    	[OperationContract]
    	ApplicationOrganisationTypeGroupSearchVMDC SearchApplicationOrganisationTypeGroup(string userName, string currentUserName, string appID, string overrideID, ApplicationOrganisationTypeGroupSearchCriteriaDC searchCriteria, int page, int pageSize, bool includeInActive);
    	
    	[FaultContract(typeof(UniqueConstraintFault))]
    	[FaultContract(typeof(DataConcurrencyFault))]
    	[FaultContract(typeof(DataIntegrityFault))]
    	[FaultContract(typeof(ServiceErrorFault))]
    	[OperationContract]
    	ApplicationOrganisationTypeGroupVMDC UpdateApplicationOrganisationTypeGroup(string userName, string currentUserName, string appID, string overrideID, ApplicationOrganisationTypeGroupDC dc);
    
    	[FaultContract(typeof(DataConcurrencyFault))]
    	[FaultContract(typeof(DataIntegrityFault))]
    	[FaultContract(typeof(ServiceErrorFault))]
    	[OperationContract]
    	void DeleteApplicationOrganisationTypeGroup(string userName, string currentUserName, string appID, string overrideID, string dcCode, string lockID);

        #endregion
    }
}