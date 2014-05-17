using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class SubCategoryDetails
    {
        private int categoryId;
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public int SubCategoryId { get; set; }       
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsViewInNavBar { get; set; }
        public bool IsActive { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; } 
    }
}