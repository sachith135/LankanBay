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
    public partial class pay_on_delivery : System.Web.UI.Page
    {
        OrderDetails orderDetails = new OrderDetails();
        OrderDetailsService orderDetailsService = new OrderDetailsService();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString.Count != 0 && Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0 && Request.QueryString[2] != null && Request.QueryString[2].ToString().Length != 0)
                { 
                    orderDetails.PaymentOptionId = 2;
                    orderDetails.OrderId = Convert.ToInt32(Request.QueryString[0].ToString());
                    orderDetailsService.UpdatePaymentOption(orderDetails);
                    DataBaseTransactionService.CommitTransactions();
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