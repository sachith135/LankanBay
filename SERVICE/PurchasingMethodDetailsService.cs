using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class PurchasingMethodDetailsService
    {
        PurchasingMethodDetailsEntry purchasingMethodDetailsEntry = new PurchasingMethodDetailsEntry();

        public DataTable Select(PurchasingMethodDetails purchasingMethodDetails)
        {
            try
            {
                return purchasingMethodDetailsEntry.Select(purchasingMethodDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}