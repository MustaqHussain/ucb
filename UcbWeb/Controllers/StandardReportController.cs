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
    public partial class StandardReportController : BaseController
    {

		private IUcbService UcbService;

		// Dependency Injection enabled constructors
        public StandardReportController()
            : this(new UcbServiceClient(),new SessionManager(), new CacheManager())
        {
        }

        public StandardReportController(IUcbService UcbService, ISessionManager sessionManager, ICacheManager cacheManager)
			:base(sessionManager,cacheManager)
        {
            this.UcbService = UcbService;
        }

		#region Edit
		
        // GET: /StandardReport/Edit
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        public ActionResult Edit()
        {
			// Retrieve ID from session
			string code = sessionManager.StandardReportCode;
			
            StandardReportVM model = new StandardReportVM();
			
            // Not from staff or error
            if (String.IsNullOrEmpty(code))
            {
                //If session has lists then use them
                RepopulateListsFromCacheSession(model);

                //Assume we are in create mode as no code passed
                model.StandardReportItem = new StandardReportModel();
            }
            //if we have been passed a code then assume we are in edit situation and we need to retrieve from the database.
            else
            {
				// Create service instance
				IUcbService sc = UcbService;
				
                try
                {
					// Call service to get StandardReport item and any associated lookups    
                    StandardReportVMDC returnedObject = sc.GetStandardReport(CurrentUser, CurrentUser, appID, "", code);

					// Close service communication
					((ICommunicationObject)sc).Close();

                    //Get view model from service
                    model = ConvertStandardReportDC(returnedObject);

                    ResolveFieldCodesToFieldNamesUsingLists(model);

                    //Store the service version
                    sessionManager.StandardReportServiceVersion = model.StandardReportItem;
                }
				catch (Exception e)
				{
					// Handle the exception
					string message = ExceptionManager.HandleException(e, (ICommunicationObject)sc);
					model.Message = message;
					
					return View(model);
				}
            }

            //Adds current retrieved StandardReport to session
            sessionManager.CurrentStandardReport = model.StandardReportItem;
            SetAccessContext(model);
            
            return View(model);
        }    
		
		#endregion
		
		#region Create/Update

        // POST: /StandardReport/Edit with Create button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult CreateStandardReport(FormCollection collection)
        {
            return UpdateStandardReport();
        }

        // POST: /StandardReport/Edit with Save button submitting
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult SaveStandardReport(FormCollection collection)
        {
            return UpdateStandardReport();
        }

        //This method is shared between create and save
        private ActionResult UpdateStandardReport()
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
                    StandardReportDC StandardReportItem = Mapper.Map<StandardReportDC>(model.StandardReportItem);

					StandardReportVMDC returnedObject = null;

                    if (null == model.StandardReportItem.Code || model.StandardReportItem.Code == Guid.Empty)
                    {
						// Call service to create new StandardReport item
                        returnedObject = sc.CreateStandardReport(CurrentUser, CurrentUser, appID, "", StandardReportItem);
                    }
                    else
                    {
						// Call service to update StandardReport item
                        returnedObject = sc.UpdateStandardReport(CurrentUser, CurrentUser, appID, "", StandardReportItem);
                    }

					// Close service communication
					((ICommunicationObject)sc).Close();
					
					// Retrieve item returned by service
                    var createdStandardReport = returnedObject.StandardReportItem;

					// Map data contract to model
                    model.StandardReportItem = Mapper.Map<StandardReportModel>(createdStandardReport);
					
                    //After creation some of the fields are display only so we need the resolved look up nmames
                    ResolveFieldCodesToFieldNamesUsingLists(model);

					// Set access context to Edit mode
                    model.AccessContext = StandardReportAccessContext.Edit;

					// Save version of item returned by service into session
                    sessionManager.StandardReportServiceVersion = model.StandardReportItem;
                    sessionManager.CurrentStandardReport = model.StandardReportItem;
                    
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

        // POST: /StandardReport/Edit with Exit button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult ExitStandardReport(FormCollection collection)
        {
            var model = GetUpdatedModel();
            if (model.IsExitConfirmed == "True" || !model.IsViewDirty)
            {
                //Set flags false
                SetFlagsFalse(model);

                model.IsExitConfirmed = "False";
                
                //remove the current values from session
                sessionManager.CurrentStandardReport = null;
                sessionManager.StandardReportServiceVersion = null;

                return RedirectToAction("Search", "StandardReport");
                
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

        // POST: /StandardReport/Edit with Delete button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamEdit(Prefix = "Edit::")]
        [HttpPost]
        public ActionResult DeleteStandardReport(FormCollection collection)
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
                    sc.DeleteStandardReport(CurrentUser, CurrentUser, appID, "", model.StandardReportItem.Code.ToString(), model.StandardReportItem.RowIdentifier.ToString());

					// Close service communication
					((ICommunicationObject)sc).Close();
					
                    // Remove the current values from session
                    sessionManager.CurrentStandardReport = null;
                    sessionManager.StandardReportServiceVersion = null;

                    // Remove the state from the model as these are being populated by the controller and the HTML helpers are being populated with
					// the POSTED values and not the changed ones.
                    ModelState.Clear();
					
					// Create new item but keep any lists
					model.StandardReportItem = new StandardReportModel();
					
					// Set message to return to user
                    model.Message = Resources.MESSAGE_DELETE_SUCCEEDED;
					
					// Set access context to Edit mode
                    model.AccessContext = StandardReportAccessContext.Create;
					
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

        // POST: /StandardReport/Edit with New button submitting
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        [HttpParamSearch(Prefix = "Search::")]
        [HttpPost]
        public ActionResult NewStandardReport(FormCollection collection)
        {
            var model = GetUpdatedModel();
            //Set flags false
            SetFlagsFalse(model);
            
            //Clear Down Session
			sessionManager.StandardReportCode = null;
            sessionManager.CurrentStandardReport = null;
            sessionManager.StandardReportServiceVersion = null;
            
            //Go to the Edit Screen
            return RedirectToAction("Edit", "StandardReport");
        }
		
		#endregion

		#region Search

        // GET: /StandardReport/Search
        //This is called when first entering search StandardReport screen or when paging
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
        public ActionResult Search(int page = 1)
        {   
			// Create service instance
			IUcbService sc = UcbService;
			
			// Create model
			StandardReportSearchVM model = new StandardReportSearchVM();
			
			try
			{
				StandardReportSearchVMDC response = sc.SearchStandardReport(CurrentUser, CurrentUser, appID, "", null, page, PageSize);

				// Close service communication
				((ICommunicationObject)sc).Close();

				//Map response back to view model
				model.MatchList = Mapper.Map<IEnumerable<StandardReportSearchMatchDC>, List<StandardReportSearchMatchModel>>(response.MatchList);

				// Set paging values
				model.TotalRows = response.RecordCount;
				model.PageSize = sessionManager.PageSize;
				model.PageNumber = page;
				
				// Store the page number we were on
				sessionManager.StandardReportPageNumber = model.PageNumber;
	        
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

        // POST: /StandardReport/Search
        //This is called when clicking search button
		[CustomAuthorize(Roles = AppRoles.ADMIN)]
		[HttpParamSearch(Prefix = "Search::")]
        [HttpPost]
        public ActionResult SearchPost(StandardReportSearchVM model, int page = 1)
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
					sessionManager.StandardReportCode = Value.ToString();
					
					// Call out to Edit screen
                    return RedirectToAction("Edit", "StandardReport", new { code = Value });

                }
            }

            // Return to the Screen
            return View(model);
        }

        #endregion
		
		#region Private methods
		
        private void SetFlagsFalse(StandardReportVM model)
        {
            model.IsDeleteConfirmed = "False";
            model.IsExitConfirmed = "False";
            model.IsNewConfirmed = "False";

            //Stop the binder resetting the posted values
            ModelState.Remove("IsDeleteConfirmed");
            ModelState.Remove("IsExitConfirmed");
            ModelState.Remove("IsNewConfirmed");
        }

        private void ResolveFieldCodesToFieldNamesUsingLists(StandardReportVM model)
        {
			//TODO:
        }

        /// <summary>
        /// Private method to merge in the model 
        /// </summary>
        /// <returns></returns>
        private StandardReportVM GetUpdatedModel()
        {
            StandardReportVM model = new StandardReportVM();
            RepopulateListsFromCacheSession(model);
            model.Message = "";

            if (sessionManager.CurrentStandardReport != null)
            {
                model.StandardReportItem = sessionManager.CurrentStandardReport;
            }

            //***************************************NEED WHITE LIST ---- BLACK LIST ------ TO PREVENT OVERPOSTING **************************
            bool result = TryUpdateModel(model);//This also validates and sets ModelState
            //*******************************************************************************************************************************
            if (sessionManager.CurrentStandardReport != null)
            {
                //*****************************************PREVENT OVER POSTING ATTACKS******************************************************
                //Get the values for read only fields from session
                MergeNewValuesWithOriginal(model.StandardReportItem);
                //***************************************************************************************************************************
            }

            SetAccessContext(model);

            return model;
        }
		
        private StandardReportVM ConvertStandardReportDC(StandardReportVMDC returnedObject)
        {
            StandardReportVM model = new StandardReportVM();
            
			// Map StandardReport Item
			model.StandardReportItem = Mapper.Map<StandardReportDC, StandardReportModel>(returnedObject.StandardReportItem);
            
			// Map lookup data lists
			model.ReportCategoryList = Mapper.Map<IEnumerable<ReportCategoryDC>, List<ReportCategoryModel>>(returnedObject.ReportCategoryList);
        
            return model;
        }
		
		private void RepopulateListsFromCacheSession(StandardReportVM model)
        {
			// Populate cached lists if they are empty. Will invoke service call
            StandardReportLookupListsCacheObject CachedLists = cacheManager.StandardReportListCache;

			// Retrieve any cached lists to model
			model.ReportCategoryList = CachedLists.ReportCategoryList;
   
        }

        private void MergeNewValuesWithOriginal(StandardReportModel modelFromView)
        {
            //***************************The values that are display only will not be posted back so need to get them from session**************************

            StandardReportModel OriginalValuesFromSession = sessionManager.CurrentStandardReport;

        }
		
		private void SetAccessContext(StandardReportVM model)
        {
            //Decide on access context
            if (null == model.StandardReportItem || model.StandardReportItem.Code == Guid.Empty)
            {
				// Create context
                model.AccessContext = StandardReportAccessContext.Create;
            }
            else
            {
				// Edit context
                model.AccessContext = StandardReportAccessContext.Edit;
            }
        }
		
		private void DetermineIsDirty(StandardReportVM model)
        {
            //Compare the StandardReport to the original session
            if (model.StandardReportItem.PublicInstancePropertiesEqual(sessionManager.StandardReportServiceVersion, "RowIdentifier"))
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
