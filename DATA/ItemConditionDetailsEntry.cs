using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;


namespace DATA
{
    public class ItemConditionDetailsEntry
    {
        public DataTable Select(ItemConditionDetails itemConditionDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemConditionDetails.IsActive, itemConditionDetails.IsActive);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_ItemConditionDetails, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}