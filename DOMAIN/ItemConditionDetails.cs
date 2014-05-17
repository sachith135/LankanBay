using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class ItemConditionDetails
    {
        public int ItemConditionId { get; set; }
        public string ItemCondition { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }  
    }
}