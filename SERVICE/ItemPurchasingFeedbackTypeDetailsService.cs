using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class ItemPurchasingFeedbackTypeDetailsService
    {
        ItemPurchasingFeedbackTypeDetailsEntry itemPurchasingFeedbackTypeDetailsEntry = new ItemPurchasingFeedbackTypeDetailsEntry();
        public DataTable Select(ItemPurchasingFeedbackTypeDetails itemPurchasingFeedbackTypeDetails)
        {
            return itemPurchasingFeedbackTypeDetailsEntry.Select(itemPurchasingFeedbackTypeDetails);
        }
    }
}