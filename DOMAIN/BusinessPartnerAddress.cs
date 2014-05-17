using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class BusinessPartnerAddress
    {
        public int AddressId { get; set; }
        public int BSPId { get; set; }
        public int AddressCatId { get; set; }
        public string AddressLine01 { get; set; }
        public string AddressLine02 { get; set; }
        public string AddressLine03 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public bool IsCurrentMail { get; set; }
        public bool IsShippingMail { get; set; }
        public int UserId { get; set; }
        
    }
}