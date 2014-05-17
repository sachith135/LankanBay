using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class BusinessPartnerTypesEntry
    {
        public DataTable Select()
        {
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SelectBusinessPartnerTypes);
        }
    }
}