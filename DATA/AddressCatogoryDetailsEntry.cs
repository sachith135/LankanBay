using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class AddressCatogoryDetailsEntry
    {
        public DataTable Select(AddressCatogoryDetails addressCatogoryDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.BusinessPartner.AddressCatogoryDetails.AddressCategory, addressCatogoryDetails.AddressCategory);
            spParameters.Add(WellKnownParameters.BusinessPartner.AddressCatogoryDetails.AddressCatId, addressCatogoryDetails.AddressCatId);
            spParameters.Add(WellKnownParameters.BusinessPartner.AddressCatogoryDetails.IsActive, addressCatogoryDetails.IsActive);

            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_AddressCategoryDetails, spParameters);
        }
    }

}