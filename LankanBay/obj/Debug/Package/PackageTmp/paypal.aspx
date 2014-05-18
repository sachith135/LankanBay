<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paypal.aspx.cs" Inherits="LankanBay.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

 
    <link href="styles/sitemaster.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style1
        {
            width: 600px;
        }
        .style2
        {
            width: 7px;
        }
        .style3
        {
            width: 137px;
        }
    </style>
</head>
<body style="background-color:#F2F2F2;">
<form name="_xclick" action="https://www.paypal.com/cgi-bin/webscr" method="post">
<input type="hidden" name="cmd" value="_xclick">
<input type="hidden" name="business" value="paypal@lankanbay.com">
<input type="hidden" name="currency_code" value="USD">
<input type="hidden" name="item_name" value="LankanBay Purchasing">


  
                   <%@ Import Namespace="System.Data" %>
                   <%@ Import Namespace="SERVICE" %>
                   <%@ Import Namespace="DOMAIN" %>

<%
    
    try
    {
        OrderDetails orderDetails = new DOMAIN.OrderDetails();
        OrderDetailsService orderDetailsService = new SERVICE.OrderDetailsService();

        OrderDetailsInDetail orderDetailsInDetail = new DOMAIN.OrderDetailsInDetail();
        OrderDetailsInDetailService orderDetailsInDetailService = new SERVICE.OrderDetailsInDetailService();
        
        int newOrderId = 0;
       
        if (!IsPostBack)
        {

            if (System.Web.HttpContext.Current.Session["OredeId"] == null)
            {
                orderDetails.BuyerBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);
                orderDetails.OrderId = 1;
                orderDetails.OrderStatus = "P";
                orderDetails.PaymentOptionId = 1;
                orderDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                newOrderId = Convert.ToInt32(orderDetailsService.Insert(orderDetails).Rows[0]["NewOrderId"].ToString());

                DataTable dtCart = ((DataTable)Session["dtCart"]);
                
                for (int i = 0; i < dtCart.Rows.Count; i++)
                {
                    orderDetailsInDetail.DeliveryChargers = Convert.ToDecimal(dtCart.Rows[i]["DeliveryChargers"].ToString());
                    orderDetailsInDetail.ItemId = Convert.ToInt32(dtCart.Rows[i]["ItemId"].ToString());
                    orderDetailsInDetail.OrderDetailId = 1;
                    orderDetailsInDetail.OrderId = newOrderId;
                    orderDetailsInDetail.Qty = Convert.ToInt32(dtCart.Rows[i]["Qty"].ToString());
                    orderDetailsInDetail.UnitPrice = Convert.ToDecimal(dtCart.Rows[i]["UnitPrice"].ToString());
                    orderDetailsInDetail.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                    orderDetailsInDetailService.Insert(orderDetailsInDetail);
                }                 
                
                DataBaseTransactionService.CommitTransactions();
                Session["OredeId"] = "ODR1352507" + newOrderId;

                string description = "Your prchasing @ LankanBay.Com : Order # " + Session["OredeId"].ToString();

                Response.Write("<input type='hidden' name='item_name' value='" + description + "'>");
                decimal amount = Math.Round(Convert.ToDecimal(Convert.ToDecimal(Session["lblTotal"]) / 131), 2);
                Response.Write("<input type='hidden' name='amount' value='" + amount + "' ");
                txtOrderNo.Text = "Your Order # : " + Session["OredeId"].ToString().Trim();

                Session["OrderId_LatePayment"] = newOrderId;
                Session["Total_LatePayment"] = amount;              
            }
            else
            {
                string redirectTo = "bsp_customer_profile.aspx?bspid=" + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&placeorder=yes";
                Response.Redirect(redirectTo);
            }  
            
        }
        
    }
    catch (Exception)
    {
        DataBaseTransactionService.RollbackTransactions();
        LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
        master.MessageBox(CommonParameterNames.MessageBoxType.InformationMessage, CommonUserMessages.InformationMessages.notloggedin);
        Response.Redirect(CommonParameterNames.PageURLs.HomePage);
    }
%>
<center>

<br /><br /><br /><br /><br />

<div class="itemImageContainer" style="padding:10px; background-color:#E7E6E6; width:600px; margin:auto;">
 <table class="style1">
     <tr>
         <td class="style3" rowspan="6" style="text-align:center">
         
             <br />
         
         <br />
         <img src="images/paypalbackground.png"  width="150px"/>
         <br />         
            <br />

         </td>
         <td class="style2">
             &nbsp;</td>
         <td style="text-align:center">
         <img src="images/newlogo.png"  width="300px"/>
         
          </td>
         <td>
             &nbsp;</td>
     </tr>
     <tr>
         <td class="style2">
             &nbsp;</td>
         <td style="text-align:center; background-color:Maroon; padding:5px;color:White;">           
          <asp:Label ID='txtOrderNo' runat='server' Font-Bold='True' Font-Size='Medium' ></asp:Label>             
         </td>

         <td>
             &nbsp;</td>
     </tr>
     <tr>
         <td class="style2">
             &nbsp;</td>
         <td style="text-align:center">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Trebuchet MS" 
                    Font-Size="Large" Text="You are about to pay "></asp:Label>
                    &nbsp;<br />
&nbsp;<asp:Label ID="lblTotal" runat="server" Text="LKR000.00" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
                                  &nbsp;

                                    <asp:Label ID="lblTotlinUSD" runat="server" Text="$0.00" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="#CC0000"></asp:Label>

                    &nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Trebuchet MS" 
                    Font-Size="Large" Text="from Paypal. "></asp:Label>
            </td>
         <td>
             &nbsp;</td>
     </tr>
     <tr>
         <td class="style2">
             &nbsp;</td>
         <td rowspan="2" style="text-align:center">
             <br />
             CLICK BUY NOW BUTTON TO PAY YOUR AMOUNT USING PAYPAL.<br />
             <%    
                 string link = "bsp_customer_profile.aspx?bspid=" + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&placeorder=yes";
                 Response.Write("<a href='"+link+"' style='text-decoration:none;' title='Pay it later... | Pay within three (3) days ...'>");                 
             %>

             <img src="images/paylater.png" border="0"/>
             </a>

<input type="image" src="images/paynowsmall.png" border="0" name="submit" alt="Make payments with PayPal - it's fast, free and secure!"><br />

             <br />
             
                        <%    
                            string changePaymentOption = "pay_on_delivery.aspx?oid=" + Session["OrderId_LatePayment"].ToString() + "&tot=" + Session["Total_LatePayment"].ToString() + "&poid=2";
                            Response.Write("<a href='" + changePaymentOption + "' style='text-decoration:none;' title='Change payment option to PAY ON DELIVERY'>");                 
                        %>
                        <img src="images/changepaymentoption.png" border="0" width="220" />
                        </a>

         </td>
         <td>
             &nbsp;</td>
     </tr>
     <tr>
         <td class="style2">
             &nbsp;</td>
         <td>
             &nbsp;</td>
     </tr>
     <tr>
         <td class="style2">
             &nbsp;</td>
         <td style="text-align:center; font-weight:bold;">
             All payments are coverd by LankanBay buyer protection.</td>
         <td>
             &nbsp;</td>
     </tr>
 </table>
 </div>
 </center>
    </form>
</body>
</html>
