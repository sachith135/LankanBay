using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA.COMMON;

namespace DATA
{
    public class ItemImageDetailsEntry
    {
        public DataTable SelectThisImageDetail(ItemImageDetails itemImageDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.ItemId, itemImageDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.IsMainImage, itemImageDetails.IsMainImage);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.IsLargeImage, itemImageDetails.IsLargeImage);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_ItemImageDetails, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void Insert(ItemImageDetails itemImageDetails, string operation)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.ImagePath, itemImageDetails.ImagePath);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.IsMainImage, itemImageDetails.IsMainImage);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.ItemId, itemImageDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.ItemWiseImageId, itemImageDetails.ItemWiseImageId);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.UserId, itemImageDetails.UserId);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.IsLargeImage, itemImageDetails.IsLargeImage);
                spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.Operation, operation);
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_ItemWiseImageDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SelectSellersItemImages(ItemImageDetails itemImageDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.ItemId, itemImageDetails.ItemId);
            spParameters.Add(WellKnownParameters.Inventory.ItemImageDetails.UserId, itemImageDetails.UserId);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SellersItemImages, spParameters);
        }
    }
}