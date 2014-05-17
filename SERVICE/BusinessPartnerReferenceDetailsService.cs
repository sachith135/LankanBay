using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;
using System.Data;

namespace SERVICE
{
    public class BusinessPartnerReferenceDetailsService
    {
        BusinessPartnerReferenceDetailsEntry businessPartnerReferenceDetailsEntry = new BusinessPartnerReferenceDetailsEntry();

        public DataTable Select(BusinessPartnerReferenceDetails businessPartnerReferenceDetails, BusinessPartnerTypeDetails businessPartnerTypeDetails)
        {
            try
            {
                return businessPartnerReferenceDetailsEntry.Select(businessPartnerReferenceDetails, businessPartnerTypeDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable Insert(BusinessPartnerReferenceDetails businessPartnerReferenceDetails)
        {
            return businessPartnerReferenceDetailsEntry.Insert(businessPartnerReferenceDetails, CommonParameterNames.Operations.Insert);
        }

        public void Update(BusinessPartnerReferenceDetails businessPartnerReferenceDetails)
        {
            businessPartnerReferenceDetailsEntry.Insert(businessPartnerReferenceDetails, CommonParameterNames.Operations.Update);
        }
    }
}