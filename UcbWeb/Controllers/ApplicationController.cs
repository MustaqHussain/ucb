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
    public partial class ApplicationController : BaseController
    {

		private IUcbService UcbService;

		// Dependency Injection enabled constructors
        public ApplicationController()
            : this(new UcbServiceClient(),new SessionManager(), new CacheManager())
        {
        }

        public ApplicationController(IUcbService UcbService, ISessionManager sessionManager, ICacheManager cacheManager)
			:base(sessionManager,cacheManager)
        {
            this.UcbService = UcbService;
        }

		#region Edit
		
        // GET: /Application/Edit
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        public ActionResult Edit()
        {
			// Retrieve ID from session
			string code = sessionManager.ApplicationCode;
			
            ApplicationVM model = new ApplicationVM();
			
            // Not from staff or error
            if (String.IsNullOrEmpty(code))
            {
                //If session has lists then use them
                RepopulateListsFromCacheSession(model);

                //Assume we are in create mode as no code passed
                model.ApplicationItem = new ApplicationModel(){IsActive = true};
            }
            //if we have been passed a code then assume we are in edit situation and we need to retrieve from the database.
            else
            {
				// Create service instance
				IUcbService sc = UcbService;
				
                try
                {
					// Call service to get Application item and any associated lookups    
                    ApplicationVMDC returnedObject = sc.GetApplication(CurrentUser, CurrentUser, appID, "", code);

					// Close service communication
					((ICommunicationObject)sc).Close();

                    //Get view model from service
                    model = ConvertApplicationDC(returnedObject);

                    ResolveFieldCodesToFieldNamesUsingLists(model);

                    //Store the service version
                    sessionManager.ApplicationServiceVersion = model.ApplicationItem;
                }
				catch (Exception e)
				{
					// Handle the exception
					string message = ExceptionManager.HandleException(e, (ICommunicationObject)sc);
					model.Message = message;
					
					return View(model);
				}
            }

            //Adds current retrieved Application to session
            sessionManager.CurrentApplication = model.ApplicationItem;
            SetAccessContext(model);
            
            return View(model);
        }    
		
		#endregion
		
		#region Create/Update

        // POST: /Application/Edit with Create button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult CreateApplication(FormCollection collection)
        {
            return UpdateApplication();
        }

        // POST: /Application/Edit with Save button submitting
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult SaveApplication(FormCollection collection)
        {
            return UpdateApplication();
        }

        //This method is shared between create and save
        private ActionResult UpdateApplication()
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
                    ApplicationDC ApplicationItem = Mapper.Map<ApplicationDC>(model.ApplicationItem);

					ApplicationVMDC returnedObject = null;

                    if (null == model.ApplicationItem.Code || model.ApplicationItem.Code == Guid.Empty)
                    {
						// Call service to create new Application item
                        returnedObject = sc.CreateApplication(CurrentUser, CurrentUser, appID, "", ApplicationItem);
                    }
                    else
                    {
						// Call service to update Application item
                        returnedObject = sc.UpdateApplication(CurrentUser, CurrentUser, appID, "", ApplicationItem);
                    }

					// Close service communication
					((ICommunicationObject)sc).Close();
					
					// Retrieve item returned by service
                    var createdApplication = returnedObject.ApplicationItem;

					// Map data contract to model
                    model.ApplicationItem = Mapper.Map<ApplicationModel>(createdApplication);
					
                    //After creation some of the fields are display only so we need the resolved look up nmames
                    ResolveFieldCodesToFieldNamesUsingLists(model);

					// Set access context to Edit mode
                    model.AccessContext = ApplicationAccessContext.Edit;

					// Save version of item returned by service into session
                    sessionManager.ApplicationServiceVersion = model.ApplicationItem;
                    sessionManager.CurrentApplication = model.ApplicationItem;
                    
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

        // POST: /Application/Edit with Exit button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult ExitApplication(FormCollection collection)
        {
            var model = GetUpdatedModel();
            if (model.IsExitConfirmed == "True" || !model.IsViewDirty)
            {
                //Set flags false
                SetFlagsFalse(model);

                model.IsExitConfirmed = "False";
                
                //remove the current values from session
                sessionManager.CurrentApplication = null;
                sessionManager.ApplicationServiceVersion = null;

                return RedirectToAction("Search", "Application");
                
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

        // POST: /Application/Edit with Delete button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult DeleteApplication(FormCollection collection)
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
                    sc.DeleteApplication(CurrentUser, CurrentUser, appID, "", model.ApplicationItem.Code.ToString(), model.ApplicationItem.RowIdentifier.ToString());

					// Close service communication
					((ICommunicationObject)sc).Close();
					
                    // Remove the current values from session
                    sessionManager.CurrentApplication = null;
                    sessionManager.ApplicationServiceVersion = null;

                    // Remove the state from the model as these are being populated by the controller and the HTML helpers are being populated with
					// the POSTED values and not the changed ones.
                    ModelState.Clear();
					
					// Create new item but keep any lists
					model.ApplicationItem = new ApplicationModel(){IsActive = true};
					
					// Set message to return to user
                    model.Message = Resources.MESSAGE_DELETE_SUCCEEDED;
					
					// Set access context to Edit mode
                    model.AccessContext = ApplicationAccessContext.Create;
					
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

        // POST: /Application/Edit with New button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamSearch(Prefix = "Search::")]
        [HttpPost]
        public ActionResult NewApplication(FormCollection collection)
        {
            var model = GetUpdatedModel();
            //Set flags false
            SetFlagsFalse(model);
            
            //Clear Down Session
			sessionManager.ApplicationCode = null;
            sessionManager.CurrentApplication = null;
            sessionManager.ApplicationServiceVersion = null;
            
            //Go to the Edit Screen
            return RedirectToAction("Edit", "Application");
        }
		
		#endregion

		#region Search

        // GET: /Application/Search
        //This is called when first entering search Application screen or when paging
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        public ActionResult Search(int page = 1)
        {   
			// Create service instance
			IUcbService sc = UcbService;
			
			// Create model
			ApplicationSearchVM model = new ApplicationSearchVM();
			
			try
			{
				ApplicationSearchVMDC response = sc.SearchApplication(CurrentUser, CurrentUser, appID, "", null, page, PageSize, true);

				// Close service communication
				((ICommunicationObject)sc).Close();

				//Map response back to view model
				model.MatchList = Mapper.Map<IEnumerable<ApplicationSearchMatchDC>, List<ApplicationSearchMatchModel>>(response.MatchList);

				// Set paging values
				model.TotalRows = response.RecordCount;
				model.PageSize = sessionManager.PageSize;
				model.PageNumber = page;
				
				// Store the page number we were on
				sessionManager.ApplicationPageNumber = model.PageNumber;
	        
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

        // POST: /Application/Search
        //This is called when clicking search button
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
		[HttpParamSearch(Prefix = "Search::")]
        [HttpPost]
        public ActionResult SearchPost(ApplicationSearchVM model, int page = 1)
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
					sessionManager.ApplicationCode = Value.ToString();
					
					// Call out to Edit screen
                    return RedirectToAction("Edit", "Application", new { code = Value });

                }
            }

            // Return to the Screen
            return View(model);
        }

        #endregion
		
		#region Private methods
		
        private void SetFlagsFalse(ApplicationVM model)
        {
            model.IsDeleteConfirmed = "False";
            model.IsExitConfirmed = "False";
            model.IsNewConfirmed = "False";

            //Stop the binder resetting the posted values
            ModelState.Remove("IsDeleteConfirmed");
            ModelState.Remove("IsExitConfirmed");
            ModelState.Remove("IsNewConfirmed");
        }

        private void ResolveFieldCodesToFieldNamesUsingLists(ApplicationVM model)
        {
			//TODO:
        }

        /// <summary>
        /// Private method to merge in the model 
        /// </summary>
        /// <returns></returns>
        private ApplicationVM GetUpdatedModel()
        {
            ApplicationVM model = new ApplicationVM();
            RepopulateListsFromCacheSession(model);
            model.Message = "";

            if (sessionManager.CurrentApplication != null)
            {
                model.ApplicationItem = sessionManager.CurrentApplication;
            }

            //***************************************NEED WHITE LIST ---- BLACK LIST ------ TO PREVENT OVERPOSTING **************************
            bool result = TryUpdateModel(model);//This also validates and sets ModelState
            //*******************************************************************************************************************************
            if (sessionManager.CurrentApplication != null)
            {
                //*****************************************PREVENT OVER POSTING ATTACKS******************************************************
                //Get the values for read only fields from session
                MergeNewValuesWithOriginal(model.ApplicationItem);
                //***************************************************************************************************************************
            }

            SetAccessContext(model);

            return model;
        }
		
        private ApplicationVM ConvertApplicationDC(ApplicationVMDC returnedObject)
        {
            ApplicationVM model = new ApplicationVM();
            
			// Map Application Item
			model.ApplicationItem = Mapper.Map<ApplicationDC, ApplicationModel>(returnedObject.ApplicationItem);
            
			// Map lookup data lists
        
            return model;
        }
		
		private void RepopulateListsFromCacheSession(ApplicationVM model)
        {
			// Populate cached lists if they are empty. Will invoke service call
            ApplicationLookupListsCacheObject CachedLists = cacheManager.ApplicationListCache;

			// Retrieve any cached lists to model
   
        }

        private void MergeNewValuesWithOriginal(ApplicationModel modelFromView)
        {
            //***************************The values that are display only will not be posted back so need to get them from session**************************

            ApplicationModel OriginalValuesFromSession = sessionManager.CurrentApplication;

        }
		
		private void SetAccessContext(ApplicationVM model)
        {
            //Decide on access context
            if (null == model.ApplicationItem || model.ApplicationItem.Code == Guid.Empty)
            {
				// Create context
                model.AccessContext = ApplicationAccessContext.Create;
            }
            else
            {
				// Edit context
                model.AccessContext = ApplicationAccessContext.Edit;
            }
        }
		
		private void DetermineIsDirty(ApplicationVM model)
        {
            //Compare the Application to the original session
            if (model.ApplicationItem.PublicInstancePropertiesEqual(sessionManager.ApplicationServiceVersion, "RowIdentifier"))
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
