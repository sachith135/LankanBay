using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class DeleveryOptionsDetails
    {
        public int DeleveryOptionId { get; set; }
        public string DeleveryOption { get; set; }
        public decimal DeleveryChargersApply { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}