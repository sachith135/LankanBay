using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class OrderDetailsInDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Qty { get; set; }          
        public int UserId { get; set; }
        public decimal DeliveryChargers { get; set; }
    }
}