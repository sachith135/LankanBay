using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class ItemDetailsEntry
    {
        
        public DataTable SelectItemDetailsForNavigationBar(ItemDetails itemDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.SubCategoryId, itemDetails.SubCategoryId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_ItemDetailsForNavigationBar, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public DataTable SelectItemDetailsForMainPage()
        {
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_ItemDetailsToPages);
        }

        public DataTable SelectItemDetailsForMainPage(ItemDetails itemDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ItemId, itemDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.SubCategoryId, itemDetails.SubCategoryId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.CategoryId, itemDetails.CategoryId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.BSPId, itemDetails.BSPId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_ItemDetailsToPages, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public DataTable SelectItemDetailsBySullpier(ItemDetails itemDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ItemId, itemDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.BSPId, itemDetails.BSPId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SellersTotalItems, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void Insert(ItemDetails itemDetails, string operation)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.AlertQty, itemDetails.AlertQty);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.BSPId, itemDetails.BSPId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.DeleveryOptionId, itemDetails.DeleveryOptionId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.DelivaryDescription, itemDetails.DelivaryDescription);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.DeliveryChargers, itemDetails.DeliveryChargers);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.Description, itemDetails.Description);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.IsActive, itemDetails.IsActive);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.IsBuyerProtection, itemDetails.IsBuyerProtection);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.IsViewInNavBar, itemDetails.IsViewInNavBar);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ItemConditionId, itemDetails.ItemConditionId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ItemId, itemDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ItemName, itemDetails.ItemName);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.PurchasingMethodId, itemDetails.PurchasingMethodId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.Operation, operation);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.QtyInHand, itemDetails.QtyInHand);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ReturnsDescription, itemDetails.ReturnsDescription);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.SubCategoryId, itemDetails.SubCategoryId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.UnitPrice, itemDetails.UnitPrice);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.UserId, itemDetails.UserId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.WarrantyDescription, itemDetails.WarrantyDescription);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.WebPageURL, itemDetails.WebPageURL);

                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_ItemDetails, spParameters);                
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public DataTable SelectSellersActiveItems(ItemDetails itemDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.Inventory.ItemDetails.UserId, itemDetails.UserId);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SellersActiveTotalItems, spParameters);
        }

        public DataTable ItemSearch(ItemDetails itemDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.SearchKeyWords, itemDetails.SearchKeyWord);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.IsDailyDeals, itemDetails.isDaityDeal);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SearchItem, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}