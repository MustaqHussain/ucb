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
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ServiceModel;
using Dwp.Adep.Ucb.ResourceLibrary;
using AutoMapper;
using UcbWeb.Helpers;
using UcbWeb.ViewModels;
using UcbWeb.Models;
using UcbWeb.UcbService;


namespace UcbWeb.Controllers
{
    public partial class RelationshipToCustomerController : BaseController
    {

		private IUcbService UcbService;

		// Dependency Injection enabled constructors
        public RelationshipToCustomerController()
            : this(new UcbServiceClient(),new SessionManager(), new CacheManager())
        {
        }

        public RelationshipToCustomerController(IUcbService UcbService, ISessionManager sessionManager, ICacheManager cacheManager)
			:base(sessionManager,cacheManager)
        {
            this.UcbService = UcbService;
        }

		#region Edit
		
        // GET: /RelationshipToCustomer/Edit
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        public ActionResult Edit()
        {
			// Retrieve ID from session
			string code = sessionManager.RelationshipToCustomerCode;
			
            RelationshipToCustomerVM model = new RelationshipToCustomerVM();
			
            // Not from staff or error
            if (String.IsNullOrEmpty(code))
            {
                //If session has lists then use them
                RepopulateListsFromCacheSession(model);

                //Assume we are in create mode as no code passed
                model.RelationshipToCustomerItem = new RelationshipToCustomerModel(){IsActive = true};
            }
            //if we have been passed a code then assume we are in edit situation and we need to retrieve from the database.
            else
            {
				// Create service instance
				IUcbService sc = UcbService;
				
                try
                {
					// Call service to get RelationshipToCustomer item and any associated lookups    
                    RelationshipToCustomerVMDC returnedObject = sc.GetRelationshipToCustomer(CurrentUser, CurrentUser, appID, "", code);

					// Close service communication
					((ICommunicationObject)sc).Close();

                    //Get view model from service
                    model = ConvertRelationshipToCustomerDC(returnedObject);

                    ResolveFieldCodesToFieldNamesUsingLists(model);

                    //Store the service version
                    sessionManager.RelationshipToCustomerServiceVersion = model.RelationshipToCustomerItem;
                }
				catch (Exception e)
				{
					// Handle the exception
					string message = ExceptionManager.HandleException(e, (ICommunicationObject)sc);
					model.Message = message;
					
					return View(model);
				}
            }

            //Adds current retrieved RelationshipToCustomer to session
            sessionManager.CurrentRelationshipToCustomer = model.RelationshipToCustomerItem;
            SetAccessContext(model);
            
            return View(model);
        }    
		
		#endregion
		
		#region Create/Update

        // POST: /RelationshipToCustomer/Edit with Create button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult CreateRelationshipToCustomer(FormCollection collection)
        {
            return UpdateRelationshipToCustomer();
        }

        // POST: /RelationshipToCustomer/Edit with Save button submitting
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult SaveRelationshipToCustomer(FormCollection collection)
        {
            return UpdateRelationshipToCustomer();
        }

        //This method is shared between create and save
        private ActionResult UpdateRelationshipToCustomer()
        {
			// Get the updated model
            var model = GetUpdatedModel();

			// Test to see if there are any errors
            var errors = ModelState
                    .Where(x => x.Value.Errors.Count > 0)
                    .Select(x => new { x.Key, x.Value.Errors[0].ErrorMessage })
                    .ToArray();
            
			//Set flags false
            SetFlagsFalse(model);
			
			// Test to see if the model has validated correctly
            if (ModelState.IsValid)
            {
				// Create service instance
				IUcbService sc = UcbService;
				
                //Attempt update
                try
                {
                    // Map model to data contract
                    RelationshipToCustomerDC RelationshipToCustomerItem = Mapper.Map<RelationshipToCustomerDC>(model.RelationshipToCustomerItem);

					RelationshipToCustomerVMDC returnedObject = null;

                    if (null == model.RelationshipToCustomerItem.Code || model.RelationshipToCustomerItem.Code == Guid.Empty)
                    {
						// Call service to create new RelationshipToCustomer item
                        returnedObject = sc.CreateRelationshipToCustomer(CurrentUser, CurrentUser, appID, "", RelationshipToCustomerItem);
                    }
                    else
                    {
						// Call service to update RelationshipToCustomer item
                        returnedObject = sc.UpdateRelationshipToCustomer(CurrentUser, CurrentUser, appID, "", RelationshipToCustomerItem);
                    }

					// Close service communication
					((ICommunicationObject)sc).Close();
					
					// Retrieve item returned by service
                    var createdRelationshipToCustomer = returnedObject.RelationshipToCustomerItem;

					// Map data contract to model
                    model.RelationshipToCustomerItem = Mapper.Map<RelationshipToCustomerModel>(createdRelationshipToCustomer);
					
                    //After creation some of the fields are display only so we need the resolved look up nmames
                    ResolveFieldCodesToFieldNamesUsingLists(model);

					// Set access context to Edit mode
                    model.AccessContext = RelationshipToCustomerAccessContext.Edit;

					// Save version of item returned by service into session
                    sessionManager.RelationshipToCustomerServiceVersion = model.RelationshipToCustomerItem;
                    sessionManager.CurrentRelationshipToCustomer = model.RelationshipToCustomerItem;
                    
                    // Remove the state from the model as these are being populated by the controller and the HTML helpers are being populated with
					// the POSTED values and not the changed ones.
                    ModelState.Clear();
                    model.Message = Resources.MESSAGE_UPDATE_SUCCEEDED;
                }
				catch (Exception e)
				{
					// Handle the exception
					string message = ExceptionManager.HandleException(e, (ICommunicationObject)sc);
					model.Message = message;
					
					return View(model);
				}
            }

            return View(model);
        }

        #endregion
		
		#region Exit

        // POST: /RelationshipToCustomer/Edit with Exit button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult ExitRelationshipToCustomer(FormCollection collection)
        {
            var model = GetUpdatedModel();
            if (model.IsExitConfirmed == "True" || !model.IsViewDirty)
            {
                //Set flags false
                SetFlagsFalse(model);

                model.IsExitConfirmed = "False";
                
                //remove the current values from session
                sessionManager.CurrentRelationshipToCustomer = null;
                sessionManager.RelationshipToCustomerServiceVersion = null;

                return RedirectToAction("Search", "RelationshipToCustomer");
                
            }
            else
            {
                //Set flags false
                SetFlagsFalse(model);
                model.Message = Resources.MESSAGE_EXITCONFIRMATION;
                model.IsExitConfirmed = "True";
            }
            
            return View(model);
        }
		
		#endregion
		
		#region Delete

        // POST: /RelationshipToCustomer/Edit with Delete button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult DeleteRelationshipToCustomer(FormCollection collection)
        {
            var model = GetUpdatedModel();
            if (model.IsDeleteConfirmed == "True")
            {
                //Set flags false
                SetFlagsFalse(model);
            
                model.IsDeleteConfirmed = "False";
				
				// Create service instance
				IUcbService sc = UcbService;
				
                try
                {
					// Call service to delete the item
                    sc.DeleteRelationshipToCustomer(CurrentUser, CurrentUser, appID, "", model.RelationshipToCustomerItem.Code.ToString(), model.RelationshipToCustomerItem.RowIdentifier.ToString());

					// Close service communication
					((ICommunicationObject)sc).Close();
					
                    // Remove the current values from session
                    sessionManager.CurrentRelationshipToCustomer = null;
                    sessionManager.RelationshipToCustomerServiceVersion = null;

                    // Remove the state from the model as these are being populated by the controller and the HTML helpers are being populated with
					// the POSTED values and not the changed ones.
                    ModelState.Clear();
					
					// Create new item but keep any lists
					model.RelationshipToCustomerItem = new RelationshipToCustomerModel(){IsActive = true};
					
					// Set message to return to user
                    model.Message = Resources.MESSAGE_DELETE_SUCCEEDED;
					
					// Set access context to Edit mode
                    model.AccessContext = RelationshipToCustomerAccessContext.Create;
					
					// Redirect to the search screen
                    return View(model);
                }
				catch (Exception e)
                {
					// Handle the exception
					string message = ExceptionManager.HandleException(e, (ICommunicationObject)sc);
					model.Message = message;
					
					return View(model);
                }
            }
            else
            {
                //Set flags false
                SetFlagsFalse(model);
                model.Message = Resources.MESSAGE_DELETECONFIRMATION;
                model.IsDeleteConfirmed = "True";
            }
            
            return View(model);
        }
		
		#endregion
		
		#region New

        // POST: /RelationshipToCustomer/Edit with New button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamSearch(Prefix = "Search::")]
        [HttpPost]
        public ActionResult NewRelationshipToCustomer(FormCollection collection)
        {
            var model = GetUpdatedModel();
            //Set flags false
            SetFlagsFalse(model);
            
            //Clear Down Session
			sessionManager.RelationshipToCustomerCode = null;
            sessionManager.CurrentRelationshipToCustomer = null;
            sessionManager.RelationshipToCustomerServiceVersion = null;
            
            //Go to the Edit Screen
            return RedirectToAction("Edit", "RelationshipToCustomer");
        }
		
		#endregion

		#region Search

        // GET: /RelationshipToCustomer/Search
        //This is called when first entering search RelationshipToCustomer screen or when paging
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        public ActionResult Search(int page = 1)
        {   
			// Create service instance
			IUcbService sc = UcbService;
			
			// Create model
			RelationshipToCustomerSearchVM model = new RelationshipToCustomerSearchVM();
			
			try
			{
				RelationshipToCustomerSearchVMDC response = sc.SearchRelationshipToCustomer(CurrentUser, CurrentUser, appID, "", null, page, PageSize, true);

				// Close service communication
				((ICommunicationObject)sc).Close();

				//Map response back to view model
				model.MatchList = Mapper.Map<IEnumerable<RelationshipToCustomerSearchMatchDC>, List<RelationshipToCustomerSearchMatchModel>>(response.MatchList);

				// Set paging values
				model.TotalRows = response.RecordCount;
				model.PageSize = sessionManager.PageSize;
				model.PageNumber = page;
				
				// Store the page number we were on
				sessionManager.RelationshipToCustomerPageNumber = model.PageNumber;
	        
				return View(model);
			}
			catch (Exception e)
			{
				// Handle the exception
				string message = ExceptionManager.HandleException(e, (ICommunicationObject)sc);
				model.Message = message;
				
				return View(model);
			}

        }

        // POST: /RelationshipToCustomer/Search
        //This is called when clicking search button
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
		[HttpParamSearch(Prefix = "Search::")]
        [HttpPost]
        public ActionResult SearchPost(RelationshipToCustomerSearchVM model, int page = 1)
        {
		
			// Iterate through form keys
            foreach (string Key in Request.Form.Keys)
            {
				// Test if Select button was clicked...
                if (Key.StartsWith("Search::SearchPost_"))
                {
					// Retrieve ID for entity which was selected
                    Guid Value = Guid.Parse(Key.Substring(19));
									
					// Store ID for Edit screen
					sessionManager.RelationshipToCustomerCode = Value.ToString();
					
					// Call out to Edit screen
                    return RedirectToAction("Edit", "RelationshipToCustomer", new { code = Value });

                }
            }

            // Return to the Screen
            return View(model);
        }

        #endregion
		
		#region Private methods
		
        private void SetFlagsFalse(RelationshipToCustomerVM model)
        {
            model.IsDeleteConfirmed = "False";
            model.IsExitConfirmed = "False";
            model.IsNewConfirmed = "False";

            //Stop the binder resetting the posted values
            ModelState.Remove("IsDeleteConfirmed");
            ModelState.Remove("IsExitConfirmed");
            ModelState.Remove("IsNewConfirmed");
        }

        private void ResolveFieldCodesToFieldNamesUsingLists(RelationshipToCustomerVM model)
        {
			//TODO:
        }

        /// <summary>
        /// Private method to merge in the model 
        /// </summary>
        /// <returns></returns>
        private RelationshipToCustomerVM GetUpdatedModel()
        {
            RelationshipToCustomerVM model = new RelationshipToCustomerVM();
            RepopulateListsFromCacheSession(model);
            model.Message = "";

            if (sessionManager.CurrentRelationshipToCustomer != null)
            {
                model.RelationshipToCustomerItem = sessionManager.CurrentRelationshipToCustomer;
            }

            //***************************************NEED WHITE LIST ---- BLACK LIST ------ TO PREVENT OVERPOSTING **************************
            bool result = TryUpdateModel(model);//This also validates and sets ModelState
            //*******************************************************************************************************************************
            if (sessionManager.CurrentRelationshipToCustomer != null)
            {
                //*****************************************PREVENT OVER POSTING ATTACKS******************************************************
                //Get the values for read only fields from session
                MergeNewValuesWithOriginal(model.RelationshipToCustomerItem);
                //***************************************************************************************************************************
            }

            SetAccessContext(model);

            return model;
        }
		
        private RelationshipToCustomerVM ConvertRelationshipToCustomerDC(RelationshipToCustomerVMDC returnedObject)
        {
            RelationshipToCustomerVM model = new RelationshipToCustomerVM();
            
			// Map RelationshipToCustomer Item
			model.RelationshipToCustomerItem = Mapper.Map<RelationshipToCustomerDC, RelationshipToCustomerModel>(returnedObject.RelationshipToCustomerItem);
            
			// Map lookup data lists
        
            return model;
        }
		
		private void RepopulateListsFromCacheSession(RelationshipToCustomerVM model)
        {
			// Populate cached lists if they are empty. Will invoke service call
            RelationshipToCustomerLookupListsCacheObject CachedLists = cacheManager.RelationshipToCustomerListCache;

			// Retrieve any cached lists to model
   
        }

        private void MergeNewValuesWithOriginal(RelationshipToCustomerModel modelFromView)
        {
            //***************************The values that are display only will not be posted back so need to get them from session**************************

            RelationshipToCustomerModel OriginalValuesFromSession = sessionManager.CurrentRelationshipToCustomer;

        }
		
		private void SetAccessContext(RelationshipToCustomerVM model)
        {
            //Decide on access context
            if (null == model.RelationshipToCustomerItem || model.RelationshipToCustomerItem.Code == Guid.Empty)
            {
				// Create context
                model.AccessContext = RelationshipToCustomerAccessContext.Create;
            }
            else
            {
				// Edit context
                model.AccessContext = RelationshipToCustomerAccessContext.Edit;
            }
        }
		
		private void DetermineIsDirty(RelationshipToCustomerVM model)
        {
            //Compare the RelationshipToCustomer to the original session
            if (model.RelationshipToCustomerItem.PublicInstancePropertiesEqual(sessionManager.RelationshipToCustomerServiceVersion, "RowIdentifier"))
            {
                model.IsViewDirty = false;
            }
            else
            {
                model.IsViewDirty = true;
            }

        }
        #endregion
       
    }
}
