using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;


namespace DATA
{
    public class ItemWiseTotalViewDetailsEntry
    {
        public void UpdateItemWiseTotalViewDetails(ItemDetails itemDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ItemId, itemDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.UserId, itemDetails.UserId);
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Update_ItemWiseTotalViewDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}