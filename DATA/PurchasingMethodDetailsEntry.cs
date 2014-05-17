using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA.COMMON;

namespace DATA
{
    public class PurchasingMethodDetailsEntry
    {
        public DataTable Select(PurchasingMethodDetails purchasingMethodDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.PurchasingMethodDetails.IsActive, purchasingMethodDetails.IsActive);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_PurchasingMethodDetails, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}