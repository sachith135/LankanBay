using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class DeleveryOptionDetailsService
    {
        DeleveryOptionDetailsEntry deleveryOptionDetailsEntry = new DeleveryOptionDetailsEntry();

        public DataTable Select(DeleveryOptionsDetails deleveryOptionsDetails)
        {
            try
            {
                return deleveryOptionDetailsEntry.Select(deleveryOptionsDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}