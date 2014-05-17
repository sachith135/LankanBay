using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;


namespace DATA
{
    public class FeedbackStatusDetailsEntry
    {
        public DataTable Select()
        {
            try
            {                
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_FeedbackStatusDetails);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}