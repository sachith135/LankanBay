using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA.COMMON;

namespace DATA
{
    public class ErrorLogDetailsEntry
    {
        public void Insert(ErrorLogDetails errorLogDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.SystemMaintenance.ErrorLog.ErrorLineNo, 0);
                spParameters.Add(WellKnownParameters.SystemMaintenance.ErrorLog.ErrorMessage, errorLogDetails.ErrorMessage);
                spParameters.Add(WellKnownParameters.SystemMaintenance.ErrorLog.ErrorNo, 0);
                spParameters.Add(WellKnownParameters.SystemMaintenance.ErrorLog.IsFromCodeEnd, 1);
                spParameters.Add(WellKnownParameters.SystemMaintenance.ErrorLog.IsFromDBEnd, 0);
                spParameters.Add(WellKnownParameters.SystemMaintenance.ErrorLog.StoredProcedure, errorLogDetails.ClassNamePlusFunctionName);
                spParameters.Add(WellKnownParameters.SystemMaintenance.ErrorLog.UserId, errorLogDetails.UserId);

                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_ErrorLog, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
            
        }
    }
}