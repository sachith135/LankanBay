using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA.COMMON;

namespace DATA
{
    public class DeleveryOptionDetailsEntry
    {
        public DataTable Select(DeleveryOptionsDetails deleveryOptionsDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.DeleveryOptionsDetails.IsActive, deleveryOptionsDetails.IsActive);
                spParameters.Add(WellKnownParameters.Inventory.DeleveryOptionsDetails.DeleveryOptionId, deleveryOptionsDetails.DeleveryOptionId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_DeleveryOptions, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}