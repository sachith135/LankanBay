using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class ItemImageDetails
    {
        private int itemId;
        public int ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }

        private bool isMainImage;
        public bool IsMainImage
        {
            get { return isMainImage; }
            set { isMainImage = value; }
        }

        public int ItemWiseImageId { get; set; }
        public string ImagePath { get; set; }
        public int UserId { get; set; }
        public bool IsLargeImage { get; set; }


    }
}