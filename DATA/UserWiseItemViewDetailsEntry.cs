using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class UserWiseItemViewDetailsEntry
    {
        public void UpdateUserWiseItemViewDetails(ItemDetails itemDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.ItemId, itemDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.UserId, itemDetails.UserId);
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Update_UserWiseItemViewDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SelectUserWiseItemViewedDetails(int userId)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();             
                spParameters.Add(WellKnownParameters.Inventory.ItemDetails.UserId, userId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_UserWiseItemViewedDetails, spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}