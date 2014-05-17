using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DATA;
using DOMAIN;
using System.Data;

namespace SERVICE
{
    public class UserWiseItemViewDetailsService
    {
        UserWiseItemViewDetailsEntry userWiseItemViewDetailsEntry = new UserWiseItemViewDetailsEntry();

        public void UpdateUserWiseItemViews(ItemDetails itemDetails)
        {
            try
            {
                userWiseItemViewDetailsEntry.UpdateUserWiseItemViewDetails(itemDetails);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable SelectUserWiseItemViewedDetails(int userId)
        {
            try
            {
                return userWiseItemViewDetailsEntry.SelectUserWiseItemViewedDetails(userId);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}