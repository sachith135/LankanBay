using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class BusinessPartnerTypeDetails
    {
        public int BSPTypeId { get; set; }   
        public string Description { get; set; }
        public string BSPShortCode { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
    }
}