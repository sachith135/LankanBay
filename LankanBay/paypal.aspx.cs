using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
namespace LankanBay
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OrderDetails orderDetails = new OrderDetails();
        OrderDetailsService orderDetailsService = new OrderDetailsService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    lblTotal.Text = "LKR" + Session["lblTotal"].ToString();
                    lblTotlinUSD.Text = "($" + (Math.Round(Convert.ToDecimal(Convert.ToDecimal(Session["lblTotal"]) / 131), 2).ToString() + ")");

                   
                }
                catch (Exception)
                {
                    Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                if (Request.QueryString.Count != 0 && Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0 && Request.QueryString[2] != null && Request.QueryString[2].ToString().Length != 0)
                {
                    string oid = Session["OredeId"].ToString();
                    string tot = Session["lblTotal"].ToString();                   

                    orderDetails.PaymentOptionId = 2;
                    orderDetailsService.UpdatePaymentOption(orderDetails);
                    DataBaseTransactionService.CommitTransactions();

                    string PATH = "paypal_late_payment.aspx?oid=" + oid + "&tot=" + tot + "&poid=2";
                    Response.Redirect(PATH);

                }
                else
                {
                    string redirectTo = "bsp_customer_profile.aspx?bspid=" + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&placeorder=yes";
                    Response.Redirect(redirectTo);
                }
            }
            catch (Exception)
            {
                DataBaseTransactionService.RollbackTransactions();
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }
        }

        
    }
}