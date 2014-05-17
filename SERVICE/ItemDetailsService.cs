using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DOMAIN;
using DATA;

namespace SERVICE
{   
    public class ItemDetailsService
    {
        ItemDetailsEntry itemDetailsEntry = new ItemDetailsEntry();

        public DataTable SelectItemDetailsForNavigationBar(ItemDetails itemDetails)
        {
            try
            {
                return itemDetailsEntry.SelectItemDetailsForNavigationBar(itemDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable SelectItemDetailsForMainPage()
        {
            try
            {
                return itemDetailsEntry.SelectItemDetailsForMainPage();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable SelectThisItemDetailsForMainPage(ItemDetails itemDetails)
        {
            try
            {
                return itemDetailsEntry.SelectItemDetailsForMainPage(itemDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable SelectSellersItems(ItemDetails itemDetails)
        {
            try
            {
                return itemDetailsEntry.SelectItemDetailsBySullpier(itemDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void Insert(ItemDetails itemDetails)
        {
            itemDetailsEntry.Insert(itemDetails,CommonParameterNames.Operations.Insert);
        }

        public void Update(ItemDetails itemDetails)
        {
            itemDetailsEntry.Insert(itemDetails, CommonParameterNames.Operations.Update);
        }

        public DataTable SelectSellersActiveItems(ItemDetails itemDetails)
        {
            return itemDetailsEntry.SelectSellersActiveItems(itemDetails);
        }

        public DataTable ItemSearch(ItemDetails itemDetails)
        {
            return itemDetailsEntry.ItemSearch(itemDetails);
        }
    }
}