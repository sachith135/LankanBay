using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class ItemConditionDetailsService
    {
        ItemConditionDetailsEntry itemConditionDetailsEntry = new ItemConditionDetailsEntry();

        public DataTable Select(ItemConditionDetails itemConditionDetails)
        {
            try
            {
                return itemConditionDetailsEntry.Select(itemConditionDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}