using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class AdministrationMenuEntry
    {
        public DataTable SelectMenuItems(AdministrationMenuDetails administrationMenuDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.SystemMaintenance.AdministrationMenu.UserId, administrationMenuDetails.UserId);
            spParameters.Add(WellKnownParameters.SystemMaintenance.AdministrationMenu.SubCategoryId, administrationMenuDetails.SubCategoryId);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SystemMaintenanceAdministrationMenuItems, spParameters);

        }

        public DataTable SelectSubCategories(AdministrationMenuDetails administrationMenuDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.SystemMaintenance.AdministrationMenu.CategoryId, administrationMenuDetails.CategoryId);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SystemMaintenanceAdministrationMenuSubCategories, spParameters);

        }

        public DataTable SelectCategories()
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();        
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SystemMaintenanceAdministrationMenuCategories);

        }
    }
}