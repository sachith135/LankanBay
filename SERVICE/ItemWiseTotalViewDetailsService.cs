using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{
    public class ItemWiseTotalViewDetailsService
    {
        ItemWiseTotalViewDetailsEntry itemWiseTotalViewDetailsEntry = new ItemWiseTotalViewDetailsEntry();

        public void UpdateItemWiseTotalViews(ItemDetails itemDetails)
        {
            itemWiseTotalViewDetailsEntry.UpdateItemWiseTotalViewDetails(itemDetails);
        }
    }
}