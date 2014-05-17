using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class PaymetOptionDetailsService
    {
        PaymentOptionsDetailsEntry paymentOptionsDetailsEntry = new PaymentOptionsDetailsEntry();

        public DataTable SelectPaymentOptions()
        {
            try
            {
                return paymentOptionsDetailsEntry.SelectPaymentOptions();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}