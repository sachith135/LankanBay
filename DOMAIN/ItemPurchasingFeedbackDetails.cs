using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class ItemPurchasingFeedbackDetails
    {
        private int receiversBspId;
        public int ReceiversBspId
        {
            get { return receiversBspId; }
            set { receiversBspId = value; }
        }

        public int ItemPurchasingFeedBackId { get; set; }
        public int ItemId { get; set; }
        public int SenderBSPId { get; set; }
        public int FeedbackStatusId { get; set; }
        public int ItemPurchasingFeedbackTypeId { get; set; }
        public string FeedbackTo { get; set; }


        public int UserId { get; set; }
        public string Feedback { get; set; }
    }
}