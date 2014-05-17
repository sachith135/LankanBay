using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class CategoryDetails
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsViewInNavBar { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
    }
}