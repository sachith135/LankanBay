using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class BusinessPartnerReferenceDetails
    {
        public int BSPId { get; set; }
        public int BSPTypeId { get; set; }
        public string BSPCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PrimaryEmail { get; set; }
        public string PrimaryContactNo { get; set; }
        public string Fax { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }       
    }
}