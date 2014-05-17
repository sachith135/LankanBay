using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Telerik.Web.UI;
using DOMAIN;

public partial class Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dtCart = new DataTable();
            dtCart.Columns.Add("ImagePath");
            dtCart.Columns.Add("ItemId");
            dtCart.Columns.Add("ItemName");
            dtCart.Columns.Add("Description");
            dtCart.Columns.Add("Qty");
            dtCart.Columns.Add("QtyInHand");
            dtCart.Columns.Add("UnitPrice");
            dtCart.Columns.Add("DeliveryChargers");
            dtCart.Columns.Add("Total");
            Session["dtCart"] = dtCart;

            Session["ItemId"] = null;           
            Session["FromMySrilankanBay"] = null;
            Session["OredeId"] = null;

            Session["OrderId_LatePayment"] = "";
            Session["Total_LatePayment"] = "";
            Session["PaymentOption_LatePayment"] = "";

            Session[CommonParameterNames.LoggedUserDetails.bspId] = null;
            Session[CommonParameterNames.LoggedUserDetails.userId] = null;

            Response.Redirect(CommonParameterNames.PageURLs.HomePage);
        }
    }
}
