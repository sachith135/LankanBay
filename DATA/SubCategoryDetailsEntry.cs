using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class SubCategoryDetailsEntry
    {
        public DataTable SelectSubCategoriesRelatedToMainCategory(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.CategoryId, subCategoryDetails.CategoryId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_MainMenuSubCategoriesRelatedToMainCategoryForNavigationBar, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public DataTable Select(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.IsActive, subCategoryDetails.IsActive);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.SubCategoryId, subCategoryDetails.SubCategoryId);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.CategoryId, subCategoryDetails.CategoryId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SubCatrgoryDetails, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void Insert(SubCategoryDetails subCategoryDetails,string operation)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.CategoryId, subCategoryDetails.CategoryId);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.Description, subCategoryDetails.Description);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.IsActive, subCategoryDetails.IsActive);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.IsViewInNavBar, subCategoryDetails.IsViewInNavBar);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.Name, subCategoryDetails.Name);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.SubCategoryId, subCategoryDetails.SubCategoryId);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.UserId, subCategoryDetails.UserId);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.Operation,operation);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.OrderId,subCategoryDetails.OrderId );  
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_SubCategoryDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(SubCategoryDetails subCategoryDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();                
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.SubCategoryId, subCategoryDetails.SubCategoryId);
                spParameters.Add(WellKnownParameters.Inventory.SubCategoryDetails.UserId, subCategoryDetails.UserId);               
                DataBaseUtilities.DataBaseUtilities.Delete(WellKnownStoredProcedures.Delete.Delete_SubCategoryDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}