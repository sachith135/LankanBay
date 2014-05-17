using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Telerik.Web.UI;
using DOMAIN;
using SERVICE;
using System.Data;

namespace LankanBay
{
    public partial class yourcart : System.Web.UI.Page
    {
        ItemImageDetails itemImageDetails = new ItemImageDetails();
        ItemImageDetailsService itemImageDetailsService = new ItemImageDetailsService();

        private static decimal total = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGrid();
              
            }
        }

        private void FillGrid()
        {
            dgCart.DataSource = null;
            dgCart.DataBind();

            dgCart.DataSource = ((DataTable)Session["dtCart"]);
            dgCart.DataBind();           

            for (int i = 0; i < dgCart.Items.Count; i++)
            {                
                ((DataTable)Session["dtCart"]).Rows[i]["Total"] = (Convert.ToDecimal(((DataTable)Session["dtCart"]).Rows[i]["UnitPrice"]) * Convert.ToDecimal(((DataTable)Session["dtCart"]).Rows[i]["Qty"].ToString()));                
            }
            

            dgCart.DataSource = ((DataTable)Session["dtCart"]);
            dgCart.DataBind();

            GetTotal();
            
        }

        protected void dgCart_ItemCommand(object source, GridCommandEventArgs e)
        {
            if (e.CommandName == CommonParameterNames.ItemCommnads.Delete)
            {
                GridEditableItem EditItem = (GridEditableItem)e.Item;
                int rowindex = EditItem.ItemIndex;
                ((DataTable)Session["dtCart"]).Rows.RemoveAt(rowindex);            
                GetTotal();
            }
        }

        protected void txtReqQty_TextChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgCart.Items.Count; i++)
            {
               ((DataTable)Session["dtCart"]).Rows[i]["Qty"] = ((RadNumericTextBox)dgCart.MasterTableView.Items[i]["TempQty"].FindControl("txtReqQty")).Text;                              
            }

            for (int i = 0; i < dgCart.Items.Count; i++)
            {
                ((DataTable)Session["dtCart"]).Rows[i]["Total"] = (Convert.ToDecimal(((DataTable)Session["dtCart"]).Rows[i]["UnitPrice"]) * Convert.ToDecimal(((DataTable)Session["dtCart"]).Rows[i]["Qty"].ToString()));
            }
            
            dgCart.DataSource = ((DataTable)Session["dtCart"]);
            dgCart.DataBind();

            GetTotal();            
        }

        private void GetTotal()
        {
            total = 0;
            for (int i = 0; i < ((DataTable)Session["dtCart"]).Rows.Count; i++)
            {
                dgCart.Items[i]["Total"].Text = ((Convert.ToDecimal(((DataTable)Session["dtCart"]).Rows[i]["UnitPrice"].ToString()) * Convert.ToDecimal(((DataTable)Session["dtCart"]).Rows[i]["Qty"].ToString())) + Convert.ToDecimal(((DataTable)Session["dtCart"]).Rows[i]["DeliveryChargers"].ToString())).ToString();
               total = total + Convert.ToDecimal(dgCart.Items[i]["Total"].Text);
            }

            lblTotal.Text = CommonParameterNames.Curruncy.LKR + total;      

            for (int i = 0; i < ((DataTable)Session["dtCart"]).Rows.Count; i++)
            {
                ((System.Web.UI.WebControls.Image)dgCart.MasterTableView.Items[i]["TempImage"].FindControl("image")).ImageUrl = ((DataTable)Session["dtCart"]).Rows[i]["ImagePath"].ToString();

                ((RadNumericTextBox)dgCart.MasterTableView.Items[i]["TempQty"].FindControl("txtReqQty")).Text = ((DataTable)Session["dtCart"]).Rows[i]["Qty"].ToString();
                ((RadNumericTextBox)dgCart.MasterTableView.Items[i]["TempQty"].FindControl("txtReqQty")).Text = "";
            }

            
        }

        protected void dgCart_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            dgCart.DataSource = ((DataTable)Session["dtCart"]);
        }

        protected void dgCart_PageIndexChanged(object source, GridPageChangedEventArgs e)
        {
            FillGrid();
        }

        protected void dgCart_PdfExporting(object source, GridPdfExportingArgs e)
        {

        }

        protected void dgCart_PageSizeChanged(object source, GridPageSizeChangedEventArgs e)
        {
            FillGrid();
        }

        protected void btnCheckout0_Click(object sender, ImageClickEventArgs e)
        {
           
        }

        protected void btnContinue_Click(object sender, ImageClickEventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "CloseOnReload();", true);          
        }

        protected void btnCheckout_Click(object sender, ImageClickEventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "CloseScript", "RedirectParentPage('checkout.aspx');", true);      
        }
    }
}