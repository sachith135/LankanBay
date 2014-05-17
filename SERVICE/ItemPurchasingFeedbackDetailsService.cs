using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class ItemPurchasingFeedbackDetailsService
    {
        ItemPurchasingFeedbackDetailsEntry itemPurchasingFeedbackDetailsEntry = new ItemPurchasingFeedbackDetailsEntry();

        public DataTable SelectItemPerchasingFeedbackDetails(ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails)
        {
            try
            {
                return itemPurchasingFeedbackDetailsEntry.SelectItemPerchasingFeedbackDetails(itemPurchasingFeedbackDetails);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectSellersTotalFeedback(ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails)
        {
            try
            {
                return itemPurchasingFeedbackDetailsEntry.SelectSellersTotalFeedbackDetails(itemPurchasingFeedbackDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void InsertPurchasingFeedbackDetails(ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails)
        {
            try
            {
                itemPurchasingFeedbackDetailsEntry.InsertPurchasingFeedbackDetails(itemPurchasingFeedbackDetails,CommonParameterNames.Operations.Insert);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable SelectFeedbackStatusDetailsByUserAndItem(ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails)
        {
            try
            {
                return itemPurchasingFeedbackDetailsEntry.SelectFeedbackStatusDetailsByUserAndItem(itemPurchasingFeedbackDetails);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}