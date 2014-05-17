using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class ItemDetails
    { 
        public int ItemId { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int BSPId { get; set; }        
        public string ItemName { get; set; }
        public string Description { get; set; }
        public decimal QtyInHand { get; set; }
        public decimal AlertQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DeliveryChargers { get; set; }
        public string DelivaryDescription { get; set; }
        public string ReturnsDescription { get; set; }
        public int PurchasingMethodId { get; set; }
        public bool IsBuyerProtection { get; set; }        
        public int ItemConditionId { get; set; }
        public int DeleveryOptionId { get; set; }
        public string WarrantyDescription { get; set; }
        public bool IsViewInNavBar { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public string WebPageURL { get; set; }
        public string SearchKeyWord { get; set; }
        public bool isDaityDeal { get; set; }

    }
}