using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA.COMMON;

namespace DATA
{
    public class ItemPurchasingFeedbackTypeDetailsEntry
    {
        public DataTable Select(ItemPurchasingFeedbackTypeDetails itemPurchasingFeedbackTypeDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.Feedback.ItemPurchasingFeedbackTypeDetails.ForSellerOrCustomer, itemPurchasingFeedbackTypeDetails.ForSellerOrCustomer);
            spParameters.Add(WellKnownParameters.Feedback.ItemPurchasingFeedbackTypeDetails.IsActive, itemPurchasingFeedbackTypeDetails.IsActive);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_ItemPurchasingFeedbackTypeDetails, spParameters);
        }
    }
}