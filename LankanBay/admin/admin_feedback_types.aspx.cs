using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using System.Data;
using Telerik.Web.UI;

namespace LankanBay.admin
{
    public partial class admin_feedback_types : System.Web.UI.Page
    {
        ItemPurchasingFeedbackTypeDetails itemPurchasingFeedbackTypeDetails = new ItemPurchasingFeedbackTypeDetails();
        ItemPurchasingFeedbackTypeDetailsService itemPurchasingFeedbackTypeDetailsService = new ItemPurchasingFeedbackTypeDetailsService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGrid();
            }
        }

        private void FillGrid()
        {
            itemPurchasingFeedbackTypeDetails = new ItemPurchasingFeedbackTypeDetails();
            dgFeedbackTypes.DataSource = itemPurchasingFeedbackTypeDetailsService.Select(itemPurchasingFeedbackTypeDetails);
            dgFeedbackTypes.DataBind();
        }

        protected void dgFeedbackTypes_ItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {
            FillGrid();
        }

        protected void dgFeedbackTypes_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {
            itemPurchasingFeedbackTypeDetails = new ItemPurchasingFeedbackTypeDetails();
            dgFeedbackTypes.DataSource = itemPurchasingFeedbackTypeDetailsService.Select(itemPurchasingFeedbackTypeDetails);
            
        }

        protected void dgFeedbackTypes_PageIndexChanged(object source, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
          
        }

        protected void dgFeedbackTypes_PageSizeChanged(object source, Telerik.Web.UI.GridPageSizeChangedEventArgs e)
        {
            FillGrid();
        }
       
        protected void dgFeedbackTypes_SortCommand(object source, Telerik.Web.UI.GridSortCommandEventArgs e)
        {
            FillGrid();
        }

       
    }
}