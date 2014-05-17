<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="paypal_late_payment.aspx.cs"
    Inherits="LankanBay.paypal_late_payment" %>

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
<body style="background-color: #F2F2F2;">
    <form name="_xclick" action="https://www.paypal.com/cgi-bin/webscr" method="post">
    <input type="hidden" name="cmd" value="_xclick">
    <input type="hidden" name="business" value="paypal@lankanbay.com">
    <input type="hidden" name="currency_code" value="USD">
    <input type="hidden" name="item_name" value="LankanBay Purchasing">

    <%@ import namespace="System.Data" %>
    <%@ import namespace="SERVICE" %>
    <%@ import namespace="DOMAIN" %>
    <%
        
        try
        {
            if (Request.QueryString.Count != 0 && Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0 && Request.QueryString[2] != null && Request.QueryString[2].ToString().Length != 0)
            {
                Session["OrderId_LatePayment"] = Request.QueryString[0].ToString();
                Session["Total_LatePayment"] = Request.QueryString[1].ToString();
                Session["PaymentOption_LatePayment"] = Request.QueryString[2].ToString();
                
               string  oid = "ODR1352507" + Request.QueryString[0].ToString();
               string tot = Request.QueryString[1].ToString();
               string poid = Request.QueryString[2].ToString();

                if (poid == "1")
                {
                    string description = "Your prchasing @ LankanBay.Com : Order # " + oid;

                    Response.Write("<input type='hidden' name='item_name' value='" + description + "'>");
                    decimal amount = Math.Round(Convert.ToDecimal(Convert.ToDecimal(tot) / 131), 2);
                    Response.Write("<input type='hidden' name='amount' value='" + amount + "' ");
                    txtOrderNo.Text = "Your Order # : " + oid;
                    lblTotlinUSD.Text = "($" + Math.Round(Convert.ToDecimal(Convert.ToDecimal(tot) / 131), 2).ToString() + ")";
                    lblTotal.Text = "LKR" + tot;
                }
                else
                {
                    string PATH = "pay_on_delivery.aspx?oid=" + Session["OrderId_LatePayment"].ToString() + "&tot=" + Session["Total_LatePayment"].ToString() + "&poid=2";
                    Response.Redirect(PATH);
                }

            }
            else
            {
                string redirectTo = "bsp_customer_profile.aspx?bspid=" + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&placeorder=yes";
                Response.Redirect(redirectTo);
            }
        }
        catch (Exception)
        {
            Response.Redirect(CommonParameterNames.PageURLs.HomePage);
        }
    %>
    <center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <div class="itemImageContainer" style="padding: 10px; background-color: #E7E6E6;
            width: 600px; margin: auto;">
            <table class="style1">
                <tr>
                    <td class="style3" rowspan="6" style="text-align: center">
                        <br />
                        <br />
                        <img src="images/paypalbackground.png" width="150px" />
                        <br />
                        <br />
                    </td>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td style="text-align: center">
                        <img src="images/newlogo.png" width="300px" />
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td style="text-align: center; background-color: Maroon; padding: 5px; color: White;">
                        <asp:Label ID='txtOrderNo' runat='server' Font-Bold='True' Font-Size='Medium'></asp:Label>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td style="text-align: center">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Trebuchet MS"
                            Font-Size="Large" Text="You are about to pay "></asp:Label>
                        &nbsp;<br />
                        &nbsp;<asp:Label ID="lblTotal" runat="server" Text="LKR000.00" Font-Bold="True" Font-Size="Medium"
                            ForeColor="#FF3300"></asp:Label>
                        &nbsp;
                        <asp:Label ID="lblTotlinUSD" runat="server" Text="$0.00" Font-Bold="True" Font-Size="Medium"
                            ForeColor="#CC0000"></asp:Label>
                        &nbsp;
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Trebuchet MS"
                            Font-Size="Large" Text="from Paypal. "></asp:Label>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td rowspan="2" style="text-align: center">
                        <br />
                        CLICK BUY NOW BUTTON TO PAY YOUR AMOUNT USING PAYPAL.<br />
                        <br />
                        <%    
                            string link = "bsp_customer_profile.aspx?bspid=" + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&placeorder=yes";
                            Response.Write("<a href='" + link + "' style='text-decoration:none;' title='Pay it later... | Pay within three (3) days ...'>");                 
                        %>
                        <img src="images/paylater.png" border="0" />
                        </a>
                        <input type="image" src="images/paynowsmall.png" border="0" name="submit" alt="Make payments with PayPal - it's fast, free and secure!"><br />

                        <%    
                            string changePaymentOption = "pay_on_delivery.aspx?oid=" + Session["OrderId_LatePayment"].ToString() + "&tot=" + Session["Total_LatePayment"].ToString() + "&poid=2";
                            Response.Write("<a href='" + changePaymentOption + "' style='text-decoration:none;' title='Change payment option to PAY ON DELIVERY'>");                 
                        %>
                        <img src="images/changepaymentoption.png" border="0" width="220" />
                        </a>

                        <br />
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td style="text-align: center; font-weight: bold;">
                        All payments are coverd by LankanBay buyer protection.
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
        </div>
    </center>
    </form>
</body>
</html>
