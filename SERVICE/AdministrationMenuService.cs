using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;

namespace SERVICE
{
    public class AdministrationMenuService
    {
        AdministrationMenuEntry administrationMenuEntry = new AdministrationMenuEntry();
        
        public DataTable SelectCategories()
        {
            return administrationMenuEntry.SelectCategories();
        }

        public DataTable SelectSubCategories(AdministrationMenuDetails administrationMenuDetails)
        {
            return administrationMenuEntry.SelectSubCategories(administrationMenuDetails);
        }

        public DataTable SelectMenuItem(AdministrationMenuDetails administrationMenuDetails)
        {
            return administrationMenuEntry.SelectMenuItems(administrationMenuDetails);
        }
    }
}