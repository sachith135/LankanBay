using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class ItemImageDetailsService
    {
        ItemImageDetailsEntry itemImageDetailsEntry = new ItemImageDetailsEntry();

        public DataTable SelectThisImageDetail(ItemImageDetails itemImageDetails)
        {
            try
            {
                return itemImageDetailsEntry.SelectThisImageDetail(itemImageDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Insert(ItemImageDetails itemImageDetails)
        {
            try
            {
                itemImageDetailsEntry.Insert(itemImageDetails,CommonParameterNames.Operations.Insert);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(ItemImageDetails itemImageDetails)
        {
            try
            {
                itemImageDetailsEntry.Insert(itemImageDetails, CommonParameterNames.Operations.Update);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable SelectSellersItemImages(ItemImageDetails itemImageDetails)
        {
            return itemImageDetailsEntry.SelectSellersItemImages(itemImageDetails);
        }
    }
}