using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using SERVICE;
using DOMAIN;

namespace LankanBay
{
                     

    public partial class search : System.Web.UI.Page
    {
        ItemDetails itemDetails = new DOMAIN.ItemDetails();
        ItemDetailsService itemDetailsService = new ItemDetailsService();

        ItemImageDetails itemImageDetails = new ItemImageDetails();
        ItemImageDetailsService itemImageDetailsService = new ItemImageDetailsService();


        ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails = new ItemPurchasingFeedbackDetails();
        ItemPurchasingFeedbackDetailsService itemPurchasingFeedbackDetailsService = new ItemPurchasingFeedbackDetailsService();

        DataTable dtItemPurchaseFeedbackDetails = new DataTable();
        DataTable dtItemDetails = new DataTable();
        DataTable dtItemImageDetails = new DataTable();
        DataTable dtSingleItemDetails = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }
              
    }
}