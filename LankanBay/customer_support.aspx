<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer_support.aspx.cs" Inherits="LankanBay.customer_support" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 600px;
            height: 400px;
        }
        .style2
        {
            font-size: medium;
            font-family: "Trebuchet MS";
        }
        .style3
        {
            color: #FFFFFF;
        }
        .style4
        {
            font-size: 13px;
        }
        .style5
        {
            color: #0033CC;
        }
    </style>
    <link href="styles/sitemaster.css" rel="stylesheet" type="text/css" />
    <link href="styles/adminmaster.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td colspan="6">
                <br />
                    <asp:Image ID="Image1" runat="server" Height="41px" 
                        ImageUrl="~/images/newlogo.png" Width="372px" />
                    <br />
&nbsp;&nbsp; <strong><span class="style2">Customer Support Request</span></strong></td>
            </tr>
            <tr>
                <td colspan="6">
                    <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style3">                
                    11</td>
                <td colspan="5" class="style5">                
                    <strong class="style4">In order to serve you quickly and efficiently, please provide the information below. Once we receive your information, we will be in touch with you as soon as possible.
                    </strong>
                   </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="5">
               <b> How Can We Help You? *</b>
               </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="5">
                    <telerik:RadComboBox ID="RadComboBox1" Runat="server" Width="590px">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="I did not receive my item yet" 
                                Value="0" />
                            <telerik:RadComboBoxItem runat="server" 
                                Text="I want to know about payment options and sequrity" Value="2" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="5">
                <b>Your Question or Comment *</b>
                 </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="5">
                    <telerik:RadTextBox ID="RadTextBox1" Runat="server" Rows="4" 
                        TextMode="MultiLine" Width="586px">
                    </telerik:RadTextBox>
                </td>
            </tr>
            <tr>
                <td>

                    &nbsp;</td>
                <td colspan="5">

                <b>Your email address *</b>
                </td>
            </tr>
            <tr>
                <td>

                    &nbsp;</td>
                <td colspan="5">

                    <telerik:RadTextBox ID="RadTextBox2" Runat="server" Width="586px">
                    </telerik:RadTextBox>

                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" 
                        Text="Registerd customer " />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="button" 
                        Text="Send Reqest" Width="192px" Height="30px" />
&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Clear" Width="133px" 
                        CssClass="button" Height="30px" />
&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Close" Width="133px" 
                        CssClass="button" Height="30px" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                    </telerik:RadScriptManager>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
