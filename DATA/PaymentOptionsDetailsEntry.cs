using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA.COMMON;

namespace DATA
{
    public class PaymentOptionsDetailsEntry
    {
        public DataTable SelectPaymentOptions()
        {
            try
            {
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_PaymentOptions);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}