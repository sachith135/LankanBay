using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class BusinessPartnerAddressEntry
    {
        public void Insert(BusinessPartnerAddress businessPartnerAddress,string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.AddressCatId, businessPartnerAddress.AddressCatId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.AddressId, businessPartnerAddress.AddressId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.AddressLine01, businessPartnerAddress.AddressLine01);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.AddressLine02, businessPartnerAddress.AddressLine02);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.AddressLine03, businessPartnerAddress.AddressLine03);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.BSPId, businessPartnerAddress.BSPId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.City, businessPartnerAddress.City);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.ZipCode, businessPartnerAddress.ZipCode);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.IsCurrentMail, businessPartnerAddress.IsCurrentMail);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.IsShippingMail, businessPartnerAddress.IsShippingMail);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.Operation,operation);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.State, businessPartnerAddress.State);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.UserId, businessPartnerAddress.UserId);

            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_BusinessPartnerAddress, spParameters);
       
        }

        public DataTable Select(BusinessPartnerAddress businessPartnerAddress)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.BSPId, businessPartnerAddress.BSPId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.IsCurrentMail, businessPartnerAddress.IsCurrentMail);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerAddress.IsShippingMail, businessPartnerAddress.IsShippingMail);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_BusinessPartnerAddressDetails, spParameters);
        }
    }
}