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
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using AutoMapper;
using Dwp.Adep.Ucb.WebServices.DataContracts;
using Dwp.Adep.Ucb.WebServices.Exceptions;
using Dwp.Adep.Ucb.Mapping;
using Dwp.Adep.Ucb.DataServices;
using Dwp.Adep.Ucb.DataServices.Models;
using Dwp.Adep.Ucb.WebServices.MessageContracts.Exceptions;
using Dwp.Adep.Ucb.WebServices.ServiceContracts;

namespace Dwp.Adep.Ucb.WebServices.ServiceContracts
{
        #region generated code for EventLeadingToIncident
    /// <summary>
    /// Service
    /// Class containing service behaviour for EventLeadingToIncident
    /// </summary>
    public partial class UcbService
    {
            #region Behaviour for EventLeadingToIncident
    
    		#region Create
    
    		/// <summary>
            /// Create a EventLeadingToIncident
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="dc"></param>
            public EventLeadingToIncidentVMDC CreateEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, EventLeadingToIncidentDC dc)
            {
    			// Create unit of work
                IUnitOfWork uow = new UnitOfWork(currentUser);
    	
    			// Create repository
                Repository<EventLeadingToIncident> dataRepository = new Repository<EventLeadingToIncident>(uow.ObjectContext, currentUser, user, appID, overrideID);
    			
    			//Create ExceptionManager
    			IExceptionManager exceptionManager = new ExceptionManager();
    			
    			//Create MappingService
    			IMappingService mappingService = new MappingService();
    			
    			
    			// Call overload with injected objects
                return CreateEventLeadingToIncident(currentUser, user, appID, overrideID, dc, dataRepository, uow,exceptionManager, mappingService);
            }
    
    		/// <summary>
            ///  Create a EventLeadingToIncident
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="dc"></param>
            /// <param name="dataRepository"></param>
            /// <param name="uow"></param>
            public EventLeadingToIncidentVMDC CreateEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, EventLeadingToIncidentDC dc, IRepository<EventLeadingToIncident> dataRepository, IUnitOfWork uow,IExceptionManager exceptionManager, IMappingService mappingService)
            {
                try
                {
    				#region Parameter validation
    
    				// Validate parameters
    				if (string.IsNullOrEmpty(currentUser)) throw new ArgumentOutOfRangeException("currentUser");
    				if (string.IsNullOrEmpty(user)) throw new ArgumentOutOfRangeException("user");
    				if (string.IsNullOrEmpty(appID)) throw new ArgumentOutOfRangeException("appID");
    				if (null == dc) throw new ArgumentOutOfRangeException("dc");
    				if (null == dataRepository) throw new ArgumentOutOfRangeException("dataRepository");
    				if (null == uow) throw new ArgumentOutOfRangeException("uow");
    				if (null == exceptionManager) throw new ArgumentOutOfRangeException("exceptionManager");
    				if (null == mappingService) throw new ArgumentOutOfRangeException("mappingService");
    				
    				#endregion
    
                    using (uow)
                    {
    					// Create a new ID for the EventLeadingToIncident item
    					dc.Code = Guid.NewGuid();
    					
    					// Map data contract to model
                        EventLeadingToIncident destination = mappingService.Map<EventLeadingToIncidentDC, EventLeadingToIncident>(dc);
    
    					// Add the new item
                        dataRepository.Add(destination);
    
    					// Commit unit of work
                        uow.Commit();
    					
    					// Map model back to data contract to return new row id.
    					dc = mappingService.Map<EventLeadingToIncident, EventLeadingToIncidentDC>(destination);
                    }
    				
    				// Create aggregate data contract
    				EventLeadingToIncidentVMDC returnObject = new EventLeadingToIncidentVMDC();
    				
    				// Add new item to aggregate
    				returnObject.EventLeadingToIncidentItem = dc;
    				
    				return returnObject;
                }
                catch (Exception e)
                {
                    //Prevent exception from propogating across the service interface
                    exceptionManager.ShieldException(e);
    				
    				return null;
                }
            }
    
            #endregion
    
    		#region Update
    
    		/// <summary>
            /// Update a EventLeadingToIncident
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="dc"></param>
            public EventLeadingToIncidentVMDC UpdateEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, EventLeadingToIncidentDC dc)
            {
    			// Create unit of work
                IUnitOfWork uow = new UnitOfWork(currentUser);
    			
    			// Create repository
                IRepository<EventLeadingToIncident> dataRepository = new Repository<EventLeadingToIncident>(uow.ObjectContext, currentUser, user, appID, overrideID);
    
    			//Create ExceptionManager
    			IExceptionManager exceptionManager = new ExceptionManager();
    			
    			//Create MappingService
    			IMappingService mappingService = new MappingService();
    			
    			// Call overload with injected objects
                return UpdateEventLeadingToIncident(currentUser, user, appID, overrideID, dc, dataRepository, uow,exceptionManager, mappingService);
            }
    
    		/// <summary>
            /// Update a EventLeadingToIncident
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="dc"></param>
            /// <param name="dataRepository"></param>
            /// <param name="uow"></param>
            public EventLeadingToIncidentVMDC UpdateEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, EventLeadingToIncidentDC dc, IRepository<EventLeadingToIncident> dataRepository, IUnitOfWork uow,IExceptionManager exceptionManager, IMappingService mappingService)
            {
                try
                {
    				#region Parameter validation
    
    				// Validate parameters
    				if (string.IsNullOrEmpty(currentUser)) throw new ArgumentOutOfRangeException("currentUser");
    				if (string.IsNullOrEmpty(user)) throw new ArgumentOutOfRangeException("user");
    				if (string.IsNullOrEmpty(appID)) throw new ArgumentOutOfRangeException("appID");
    				if (null == dc) throw new ArgumentOutOfRangeException("dc");
    				if (null == dataRepository) throw new ArgumentOutOfRangeException("dataRepository");
    				if (null == uow) throw new ArgumentOutOfRangeException("uow");
    				if (null == exceptionManager) throw new ArgumentOutOfRangeException("exceptionManager");
    				if (null == mappingService) throw new ArgumentOutOfRangeException("mappingService");
    				
    				#endregion
    
                    using (uow)
                    {
    					// Map data contract to model
                        EventLeadingToIncident destination = mappingService.Map<EventLeadingToIncidentDC, EventLeadingToIncident>(dc);
    
    					// Add the new item
                        dataRepository.Update(destination);
    
    					// Commit unit of work
                        uow.Commit();
    					
    					// Map model back to data contract to return new row id.
    					dc = mappingService.Map<EventLeadingToIncident, EventLeadingToIncidentDC>(destination);
                    }
    				
    				// Create new data contract to return
    				EventLeadingToIncidentVMDC returnObject = new EventLeadingToIncidentVMDC();
    				
    				// Add new item to datacontract
    				returnObject.EventLeadingToIncidentItem = dc;
    				
    				// Commit unit of work
    				return returnObject;
    				
                }
                catch (Exception e)
                {
                    //Prevent exception from propogating across the service interface
                    exceptionManager.ShieldException(e);
    				
    				return null;
                }
            }
    
            #endregion
    
    		#region Delete
    
    		/// <summary>
            /// Delete a EventLeadingToIncident
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="code"></param>
            /// <param name="lockID"></param>
            public void DeleteEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, string code, string lockID)
            {
    			// Create unit of work
                IUnitOfWork uow = new UnitOfWork(currentUser);
    
    			// Create repository
                IRepository<EventLeadingToIncident> dataRepository = new Repository<EventLeadingToIncident>(uow.ObjectContext, currentUser, user, appID, overrideID);
    			
    			//Create ExceptionManager
    			IExceptionManager exceptionManager = new ExceptionManager();
    			
    			//Create MappingService
    			IMappingService mappingService = new MappingService();
    			
    			// Call overload with injected objects
                DeleteEventLeadingToIncident(currentUser, user, appID, overrideID, code, lockID, dataRepository, uow,exceptionManager, mappingService);
            }
    
    		/// <summary>
            /// Update a EventLeadingToIncident
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="code"></param>
            /// <param name="lockID"></param>
            /// <param name="dataRepository"></param>
            /// <param name="uow"></param>
            public void DeleteEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, string code, string lockID, IRepository<EventLeadingToIncident> dataRepository, IUnitOfWork uow,IExceptionManager exceptionManager, IMappingService mappingService)
            {
                try
                {
    				#region Parameter validation
    
    				// Validate parameters
    				if (string.IsNullOrEmpty(currentUser)) throw new ArgumentOutOfRangeException("currentUser");
    				if (string.IsNullOrEmpty(user)) throw new ArgumentOutOfRangeException("user");
    				if (string.IsNullOrEmpty(appID)) throw new ArgumentOutOfRangeException("appID");
    				if (string.IsNullOrEmpty(code)) throw new ArgumentOutOfRangeException("code");
    				if (string.IsNullOrEmpty(lockID)) throw new ArgumentOutOfRangeException("lockID");
    				if (null == dataRepository) throw new ArgumentOutOfRangeException("dataRepository");
    				if (null == uow) throw new ArgumentOutOfRangeException("uow");
    				if (null == exceptionManager) throw new ArgumentOutOfRangeException("exceptionManager");
    				if (null == mappingService) throw new ArgumentOutOfRangeException("mappingService");
    				
    				#endregion
    
                    using (uow)
                    {
    					// Convert string to guid
                        Guid codeGuid = Guid.Parse(code);	
    					
    					// Find item based on ID
                        EventLeadingToIncident dataEntity = dataRepository.Single(x => x.Code == codeGuid);
    					
    					// Delete the item
                        dataRepository.Delete(dataEntity);
    
    					// Commit unit of work
                        uow.Commit();
                    }
                }
                catch (Exception e)
                {
                    //Prevent exception from propogating across the service interface
                    exceptionManager.ShieldException(e);
                }
            }
    
            #endregion
    
    		#region SearchEventLeadingToIncident
    
    		/// <summary>
            /// Search for EventLeadingToIncident items
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="searchCriteria"></param>
            /// <param name="page"></param>
            /// <param name="pageSize"></param>
            /// <param name="includeInActive"></param>
            /// <returns></returns>
    		public EventLeadingToIncidentSearchVMDC SearchEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, EventLeadingToIncidentSearchCriteriaDC searchCriteria, int page, int pageSize, bool includeInActive)
            {
    			// Create unit of work
    		    IUnitOfWork uow = new UnitOfWork(currentUser);
    
    			// Create repository
                IRepository<EventLeadingToIncident> dataRepository = new Repository<EventLeadingToIncident>(uow.ObjectContext, currentUser, user, appID, overrideID);
    			
    			// Create specification for filtering
    			ISpecification<EventLeadingToIncident> specification = new Specification<EventLeadingToIncident>();
    
    		    // Create isActive specification
                ISpecification<EventLeadingToIncident> isActiveSpecification = new IsActiveSpecification<EventLeadingToIncident>();
    			
    			//Create ExceptionManager
    			IExceptionManager exceptionManager = new ExceptionManager();
    			
    			//Create MappingService
    			IMappingService mappingService = new MappingService();
    			
    			// Call overload with injected objects
                return SearchEventLeadingToIncident(currentUser, user, appID, overrideID, searchCriteria, page, pageSize, includeInActive, specification, isActiveSpecification, dataRepository, uow,exceptionManager, mappingService);
    		}
    
    		/// <summary>
            /// Search for EventLeadingToIncident items
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="searchCriteria"></param>
            /// <param name="page"></param>
            /// <param name="pageSize"></param>
            /// <param name="includeInActive"></param>
    		/// <param name="specification"></param>
            /// <param name="dataRepository"></param>
            /// <param name="uow"></param>
            /// <returns></returns>
    		public EventLeadingToIncidentSearchVMDC SearchEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, EventLeadingToIncidentSearchCriteriaDC searchCriteria, int page, int pageSize, bool includeInActive,
    		ISpecification<EventLeadingToIncident> specification, ISpecification<EventLeadingToIncident> isActiveSpecification, IRepository<EventLeadingToIncident> dataRepository, IUnitOfWork uow,IExceptionManager exceptionManager, IMappingService mappingService)
            {
    		    try
                {
    				#region Parameter validation
    
    				// Validate parameters
    				if (string.IsNullOrEmpty(currentUser)) throw new ArgumentOutOfRangeException("currentUser");
    				if (string.IsNullOrEmpty(user)) throw new ArgumentOutOfRangeException("user");
    				if (string.IsNullOrEmpty(appID)) throw new ArgumentOutOfRangeException("appID");
    				if (null == dataRepository) throw new ArgumentOutOfRangeException("dataRepository");
    				if (null == specification) throw new ArgumentOutOfRangeException("specification");
    				if (null == uow) throw new ArgumentOutOfRangeException("uow");
    				if (null == exceptionManager) throw new ArgumentOutOfRangeException("exceptionManager");
    				if (null == mappingService) throw new ArgumentOutOfRangeException("mappingService");
    				
    				#endregion
    
                    using (uow)
                    {
    		    // Evaluate search criteria if supplied
                        if (null != searchCriteria)
                        {
                            EvaluateEventLeadingToIncidentSearchCriteria(searchCriteria, ref specification);
                        }
    
                        if (!includeInActive)
                        {
                            specification = specification.And(isActiveSpecification);
                        }
    
    					// Set default sort expression
    					System.Linq.Expressions.Expression<Func<EventLeadingToIncident, Object>> sortExpression = x => new { x.Description };
    					
    				    // Find all items that satisfy the specification created above.
                        IEnumerable<EventLeadingToIncident> dataEntities = dataRepository.Find(specification, sortExpression, page, pageSize);
    					
    					// Get total count of items for search critera
    					int itemCount = dataRepository.Count(specification);
    
    					EventLeadingToIncidentSearchVMDC results = new EventLeadingToIncidentSearchVMDC();
    
    					// Convert to data contracts
                        List<EventLeadingToIncidentSearchMatchDC> destinations = mappingService.Map<IEnumerable<EventLeadingToIncident>, List<EventLeadingToIncidentSearchMatchDC>>(dataEntities);
    
    					results.MatchList = destinations;
    					results.SearchCriteria = searchCriteria;
    					results.RecordCount = itemCount;
    
                        return results;
                    }
                }
                catch (Exception e)
                {
                    //Prevent exception from propogating across the service interface
                    exceptionManager.ShieldException(e);
    
                    return null;
                }
    		}
    		
    		// Partial method for evaluation of EventLeadingToIncident search criteria
            partial void EvaluateEventLeadingToIncidentSearchCriteria(EventLeadingToIncidentSearchCriteriaDC searchCriteria, ref ISpecification<EventLeadingToIncident> specification);
    		
    		#endregion
    		
    		#region GetAllEventLeadingToIncident
    		/// <summary>
            /// 
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
    		/// <param name="includeInActive"></param>
            /// <returns></returns>
            public List<EventLeadingToIncidentDC> GetAllEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, bool includeInActive)
            {
    			// Create unit of work
                IUnitOfWork uow = new UnitOfWork(currentUser);
    
    			// Create repository
                Repository<EventLeadingToIncident> dataRepository = new Repository<EventLeadingToIncident>(uow.ObjectContext, currentUser, user, appID, overrideID);
    			
    			// Create specification for filtering
    			ISpecification<EventLeadingToIncident> specification = new Specification<EventLeadingToIncident>();
    			
    			// Create isActive specification
                ISpecification<EventLeadingToIncident> isActiveSpecification =  new IsActiveSpecification<EventLeadingToIncident>();
    
    			//Create ExceptionManager
    			IExceptionManager exceptionManager = new ExceptionManager();
    			
    			//Create MappingService
    			IMappingService mappingService = new MappingService();
    			
    			// Call overload with injected objects
                return GetAllEventLeadingToIncident(currentUser, user, appID, overrideID, includeInActive, specification, isActiveSpecification, dataRepository, uow, exceptionManager, mappingService);
            }
    
    		/// <summary>
            /// 
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
    		/// <param name="includeInActive"></param>
    		/// <param name="specification"></param>
            /// <param name="dataRepository"></param>
            /// <param name="uow"></param>
            /// <returns></returns>
            public List<EventLeadingToIncidentDC> GetAllEventLeadingToIncident(string currentUser, string user, string appID, string overrideID,  bool includeInActive, ISpecification<EventLeadingToIncident> specification, ISpecification<EventLeadingToIncident> isActiveSpecification, IRepository<EventLeadingToIncident> dataRepository, IUnitOfWork uow,IExceptionManager exceptionManager, IMappingService mappingService)
            {
                try
                {
    				#region Parameter validation
    
    				// Validate parameters
    				if (string.IsNullOrEmpty(currentUser)) throw new ArgumentOutOfRangeException("currentUser");
    				if (string.IsNullOrEmpty(user)) throw new ArgumentOutOfRangeException("user");
    				if (string.IsNullOrEmpty(appID)) throw new ArgumentOutOfRangeException("appID");
    				if (null == dataRepository) throw new ArgumentOutOfRangeException("dataRepository");
    				if (null == specification) throw new ArgumentOutOfRangeException("specification");
    				if (null == uow) throw new ArgumentOutOfRangeException("uow");
    				if (null == exceptionManager) throw new ArgumentOutOfRangeException("exceptionManager");
    				if (null == mappingService) throw new ArgumentOutOfRangeException("mappingService");
    				
    				#endregion
    
                    using (uow)
                    {
    					// Build specification
                        if (!includeInActive)
                        {
                            specification = specification.And(isActiveSpecification);
                        }
    
    					// Set default sort expression
    					System.Linq.Expressions.Expression<Func<EventLeadingToIncident, Object>> sortExpression = x => new { x.Description };
    					
                        // Find all items that satisfy the specification created above.
                        IEnumerable<EventLeadingToIncident> dataEntities = dataRepository.Find(specification, sortExpression);
    					
    					// Convert to data contracts
                        List<EventLeadingToIncidentDC> destinations = mappingService.Map<IEnumerable<EventLeadingToIncident>, List<EventLeadingToIncidentDC>>(dataEntities);
    
                        return destinations;
                    }
                }
                catch (Exception e)
                {
                    //Prevent exception from propogating across the service interface
                    exceptionManager.ShieldException(e);
    
                    return null;
                }
            }
    		#endregion
    
            #region GetEventLeadingToIncident
    	
    		/// <summary>
        	/// Retrieve a EventLeadingToIncident with associated lookups
        	/// </summary>
        	/// <param name="currentUser"></param>
        	/// <param name="user"></param>
        	/// <param name="appID"></param>
        	/// <param name="overrideID"></param>
        	/// <param name="code"></param>
        	/// <returns></returns>
            public EventLeadingToIncidentVMDC GetEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, string code)
            {
    			//Create ExceptionManager
    			IExceptionManager exceptionManager = new ExceptionManager();
    			
    			//Create MappingService
    			IMappingService mappingService = new MappingService();
    			
    			// Create unit of work
                IUnitOfWork uow = new UnitOfWork(currentUser);
    
    			// Create repository
                IRepository<EventLeadingToIncident> dataRepository = new Repository<EventLeadingToIncident>(uow.ObjectContext, currentUser, user, appID, overrideID);
    
    			// Create repositories for lookup data
    
    			// Call overload with injected objects
                return GetEventLeadingToIncident(currentUser, user, appID, overrideID, code, uow, dataRepository
    			, exceptionManager, mappingService);
            }
    
    		/// <summary>
            /// Retrieve a EventLeadingToIncident with associated lookups
            /// </summary>
            /// <param name="currentUser"></param>
            /// <param name="user"></param>
            /// <param name="appID"></param>
            /// <param name="overrideID"></param>
            /// <param name="code"></param>
            /// <param name="dataRepository"></param>
            /// <param name="uow"></param>
            /// <returns></returns>
            public EventLeadingToIncidentVMDC GetEventLeadingToIncident(string currentUser, string user, string appID, string overrideID, string code, IUnitOfWork uow, IRepository<EventLeadingToIncident> dataRepository
    			, IExceptionManager exceptionManager, IMappingService mappingService)
    		
            {
                try
                {
    				#region Parameter validation
    
    				// Validate parameters
    				if (string.IsNullOrEmpty(currentUser)) throw new ArgumentOutOfRangeException("currentUser");
    				if (string.IsNullOrEmpty(user)) throw new ArgumentOutOfRangeException("user");
    				if (string.IsNullOrEmpty(appID)) throw new ArgumentOutOfRangeException("appID");
    				if (null == dataRepository) throw new ArgumentOutOfRangeException("dataRepository");
    				if (null == uow) throw new ArgumentOutOfRangeException("uow");
    				if (null == exceptionManager) throw new ArgumentOutOfRangeException("exceptionManager");
    				if (null == mappingService) throw new ArgumentOutOfRangeException("mappingService");
    				
    				#endregion
    
                    using (uow)
                    {
    				
    					EventLeadingToIncidentDC destination = null;
    					
    					// If code is null then just return supporting lists
    					if (!string.IsNullOrEmpty(code))
    					{
    						// Convert code to Guid
    	                    Guid codeGuid = Guid.Parse(code);
    
    						// Retrieve specific EventLeadingToIncident
    	                    EventLeadingToIncident dataEntity = dataRepository.Single(x => x.Code == codeGuid);
    
    						// Convert to data contract for passing through service interface
    	                    destination = mappingService.Map<EventLeadingToIncident, EventLeadingToIncidentDC>(dataEntity);
    					}
    
    
    
        				// Create aggregate contract
                        EventLeadingToIncidentVMDC returnObject = new EventLeadingToIncidentVMDC();
    
                        returnObject.EventLeadingToIncidentItem = destination;
                        
    					return returnObject;
                    }
                }
                catch (Exception e)
                {
                    //Prevent exception from propogating across the service interface
                    exceptionManager.ShieldException(e);
    
                    return null;
                }
            }
    	
    		#endregion	
    
    	

            #endregion
    }

        #endregion
}