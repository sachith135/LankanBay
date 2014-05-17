using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class CategoryDetailsEntry
    {
        public DataTable SelectCategoriesFornavigationBar()
        {
            try
            {

                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_MainMenuCategoriesForNavigationBar);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public DataTable Select(CategoryDetails categoryDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.CategoryId, categoryDetails.CategoryId);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.IsActive, categoryDetails.IsActive);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_CategoryDetails, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void Insert(CategoryDetails categoryDetails,string operation)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.CategoryId, categoryDetails.CategoryId);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.Description, categoryDetails.Description);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.IsActive, categoryDetails.IsActive);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.IsViewInNavBar, categoryDetails.IsViewInNavBar);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.Name, categoryDetails.Name);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.Operation,operation);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.UserId, categoryDetails.UserId);
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.OrderId, categoryDetails.OrderId);
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_CategoryDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(CategoryDetails categoryDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.CategoryId, categoryDetails.CategoryId);        
                spParameters.Add(WellKnownParameters.Inventory.CatrgoryDetails.UserId, categoryDetails.UserId);
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Delete.Delete_CategoryDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}