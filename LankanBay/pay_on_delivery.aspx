<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pay_on_delivery.aspx.cs" Inherits="LankanBay.pay_on_delivery" %>

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
<form id="form1" runat="server"> 
 
                   <%@ Import Namespace="System.Data" %>
                   <%@ Import Namespace="SERVICE" %>
                   <%@ Import Namespace="DOMAIN" %>

<%
    
    try
    {
        if (Request.QueryString.Count != 0 && Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0 && Request.QueryString[2] != null && Request.QueryString[2].ToString().Length != 0)
        {
            string oid = "ODR1352507" + Request.QueryString[0].ToString();
            string tot = Request.QueryString[1].ToString();
            string poid = Request.QueryString[2].ToString();

            Session["OrderId_LatePayment"] = Request.QueryString[0].ToString();
            Session["Total_LatePayment"] = Request.QueryString[1].ToString();
            Session["PaymentOption_LatePayment"] = Request.QueryString[2].ToString();

            if (poid == "2")
            {      
                decimal amount = Math.Round(Convert.ToDecimal(Convert.ToDecimal(tot) / 131), 2);                
                txtOrderNo.Text = "Your Order # : " + oid;
                lblTotlinUSD.Text = "($" + Math.Round(Convert.ToDecimal(Convert.ToDecimal(tot) / 131), 2).ToString() + ")";
                lblTotal.Text = "LKR" + tot;
            }
            else
            {
                string PATH = "paypal_late_payment.aspx?oid=" + Session["OrderId_LatePayment"].ToString() + "&tot=" + Session["Total_LatePayment"] .ToString()+ "&poid=1";
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

<br /><br /><br /><br /><br />

<div class="itemImageContainer" style="padding:10px; background-color:#E7E6E6; width:600px; margin:auto;">
 <table class="style1">
     <tr>
         <td class="style3" rowspan="6" style="text-align:center">
         
             <br />
         
             <br />
         
         <br />
         <img src="images/payondelevery.png"  width="150px"/>
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
                    Font-Size="Large" Text="You have to pay"></asp:Label>
                    &nbsp;<br />
&nbsp;<asp:Label ID="lblTotal" runat="server" Text="LKR000.00" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="#FF3300"></asp:Label>
                                  &nbsp;

                                    <asp:Label ID="lblTotlinUSD" runat="server" Text="$0.00" Font-Bold="True" 
                    Font-Size="Medium" ForeColor="#CC0000"></asp:Label>

                    &nbsp;
                <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Trebuchet MS" 
                    Font-Size="Large" Text="on delivery. "></asp:Label>
            </td>
         <td>
             &nbsp;</td>
     </tr>
     <tr>
         <td class="style2">
             &nbsp;</td>
         <td rowspan="2" style="text-align:center">
             <br />
             YOU HAVE TO PAY ON DELIVERY DATE TO OUR AGENT + ADITIONAL DELIVERY CHARGERS (IF 
             ANY).<br />
             <%    
                 string link = "bsp_customer_profile.aspx?bspid=" + Session[CommonParameterNames.LoggedUserDetails.bspId].ToString() + "&placeorder=yes";
                 Response.Write("<a href='"+link+"' style='text-decoration:none;' title='Pay it later... | Pay within three (3) days ...'>");                 
             %>

             <img src="images/back.png" border="0"/>
             </a>

             <br />
        
                        <%    
                            string changePaymentOption = "paypal_late_payment.aspx?oid=" + Session["OrderId_LatePayment"].ToString() + "&tot=" + Session["Total_LatePayment"].ToString() + "&poid=1";
                            Response.Write("<a href='" + changePaymentOption + "' style='text-decoration:none;' title='Change payment option to PAYPAL'>");                 
                        %> &nbsp;<img src="images/changepaymentoption.png" border="0" width="220" />
                        </a>

&nbsp;</td>
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
