using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA.COMMON;
using DOMAIN;
using System.Data;

namespace DATA
{
    public class BusinessPartnerReferenceDetailsEntry
    {
        public DataTable Select(BusinessPartnerReferenceDetails businessPartnerReferenceDetails, BusinessPartnerTypeDetails businessPartnerTypeDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.BSPId, businessPartnerReferenceDetails.BSPId);
                spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.IsActive, businessPartnerReferenceDetails.IsActive);
                spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerTypeDetails.BSPShortCode, businessPartnerTypeDetails.BSPShortCode);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_BusinessPartnerReferenceDetails, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public DataTable Insert(BusinessPartnerReferenceDetails businessPartnerReferenceDetails, string operation)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.BSPCode, businessPartnerReferenceDetails.BSPCode);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.BSPId, businessPartnerReferenceDetails.BSPId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.BSPTypeId, businessPartnerReferenceDetails.BSPTypeId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.Fax, businessPartnerReferenceDetails.Fax);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.FirstName, businessPartnerReferenceDetails.FirstName);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.IsActive, businessPartnerReferenceDetails.IsActive);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.LastName, businessPartnerReferenceDetails.LastName);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.Operation, operation);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.PrimaryContactNo, businessPartnerReferenceDetails.PrimaryContactNo);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.PrimaryEmail, businessPartnerReferenceDetails.PrimaryEmail);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerReference.UserId, businessPartnerReferenceDetails.UserId);

            return DataBaseUtilities.DataBaseUtilities.InsertWithSelect(WellKnownStoredProcedures.Insert.Insert_BusinessPartnerReference, spParameters);
        }
    }
}