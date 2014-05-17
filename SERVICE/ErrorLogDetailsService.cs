using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class ErrorLogDetailsService
    {
        ErrorLogDetailsEntry errorLogDetailsEntry = new ErrorLogDetailsEntry();

        public void Insert(ErrorLogDetails errorLogDetails)
        {
            try
            {
                errorLogDetailsEntry.Insert(errorLogDetails);
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}