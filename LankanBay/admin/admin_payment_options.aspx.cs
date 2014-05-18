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
    public partial class admin_payment_options : System.Web.UI.Page
    {
        ItemConditionDetails itemConditionDetails = new ItemConditionDetails();
        ItemConditionDetailsService itemConditionDetailsService = new ItemConditionDetailsService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGrid();
            }
        }

        private void FillGrid()
        {
            dgItemCoditions.DataSource = null;
            itemConditionDetails = new ItemConditionDetails();
            dgItemCoditions.DataSource = itemConditionDetailsService.Select(itemConditionDetails);
            dgItemCoditions.DataBind();

        }
    }
}