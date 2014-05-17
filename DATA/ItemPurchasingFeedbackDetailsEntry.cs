using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class ItemPurchasingFeedbackDetailsEntry
    {
        public DataTable SelectItemPerchasingFeedbackDetails(ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Feedback.ItemPurchasingFeedbackDetails.ReceiersBSPId, itemPurchasingFeedbackDetails.ReceiversBspId);
                spParameters.Add(WellKnownParameters.Feedback.ItemPurchasingFeedbackDetails.SendersBSPId, itemPurchasingFeedbackDetails.SenderBSPId);
                spParameters.Add(WellKnownParameters.Feedback.ItemPurchasingFeedbackDetails.FeedbackTo, itemPurchasingFeedbackDetails.FeedbackTo);
                spParameters.Add(WellKnownParameters.Feedback.ItemPurchasingFeedbackDetails.ItemPurchasingFeedbackTypeId, itemPurchasingFeedbackDetails.ItemPurchasingFeedbackTypeId);
                spParameters.Add(WellKnownParameters.Feedback.ItemPurchasingFeedbackDetails.FeedbackStatusId, itemPurchasingFeedbackDetails.FeedbackStatusId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_ItemPerchasingFeedbackDetails, spParameters);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectSellersTotalFeedbackDetails(ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.ReceiverBSPId, itemPurchasingFeedbackDetails.ReceiversBspId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_SellersTotalFeedback, spParameters);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void InsertPurchasingFeedbackDetails(ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails, string operation)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.Feedback, itemPurchasingFeedbackDetails.Feedback);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.FeedbackStatusId, itemPurchasingFeedbackDetails.FeedbackStatusId);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.ItemId, itemPurchasingFeedbackDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.ItemPurchasingFeedBackId, itemPurchasingFeedbackDetails.ItemPurchasingFeedBackId); 
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.ItemPurchasingFeedbackTypeId, itemPurchasingFeedbackDetails.ItemPurchasingFeedbackTypeId);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.Operation,operation);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.ReceiverBSPId, itemPurchasingFeedbackDetails.ReceiversBspId);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.SenderBSPId, itemPurchasingFeedbackDetails.SenderBSPId);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.UserId, itemPurchasingFeedbackDetails.UserId);              
                DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Insert_ItemPurchasingFeedbackDetails, spParameters);

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
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.ItemId, itemPurchasingFeedbackDetails.ItemId);
                spParameters.Add(WellKnownParameters.Inventory.ItemPurchasigFeedbackDetails.SenderBSPId, itemPurchasingFeedbackDetails.SenderBSPId);
                return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_FeedbackStatusDetailsByUserAndItem, spParameters);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}