using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public int BuyerBSPId { get; set; }
        public string OrderStatus { get; set; }
        public int PaymentOptionId { get; set; }
        public int UserId { get; set; }       
    }
}