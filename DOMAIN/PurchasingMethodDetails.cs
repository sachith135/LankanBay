using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class PurchasingMethodDetails
    {
        public int ItemPurchasingMethodId { get; set; }
        public string ItemPurchasingMethod { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}