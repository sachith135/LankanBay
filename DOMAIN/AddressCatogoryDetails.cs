using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class AddressCatogoryDetails
    {
        public int AddressCatId { get; set; }
        public string AddressCategory { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }

    }
}