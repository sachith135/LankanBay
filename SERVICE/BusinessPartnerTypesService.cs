using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using System.Data;

namespace SERVICE
{
    public class BusinessPartnerTypesService
    {
        BusinessPartnerTypesEntry businessPartnerTypesEntry = new BusinessPartnerTypesEntry();

        public DataTable Select()
        {
            return businessPartnerTypesEntry.Select();
        }
    }
}