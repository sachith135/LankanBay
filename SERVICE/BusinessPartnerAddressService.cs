using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA;
using DOMAIN;


namespace SERVICE
{
    public class BusinessPartnerAddressService
    {
        BusinessPartnerAddressEntry businessPartnerAddressEntry = new BusinessPartnerAddressEntry();
        public void Insert(BusinessPartnerAddress businessPartnerAddress)
        {
            businessPartnerAddressEntry.Insert(businessPartnerAddress, CommonParameterNames.Operations.Insert);
        }

        public void Update(BusinessPartnerAddress businessPartnerAddress)
        {
            businessPartnerAddressEntry.Insert(businessPartnerAddress, CommonParameterNames.Operations.Update);
        }

        public DataTable Select(BusinessPartnerAddress businessPartnerAddress)
        {
            return businessPartnerAddressEntry.Select(businessPartnerAddress);
        }
    }
}