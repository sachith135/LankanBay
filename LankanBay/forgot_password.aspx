<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgot_password.aspx.cs" Inherits="LankanBay.forgot_password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 600px;
            height: 300px;
        }
    *
{
    text-align:left;
	margin-left: 0px;
}
*
{
	font-family:Trebuchet MS;
	font-size:12px;
    margin-right: 1px;
	text-align: left;
    margin-bottom: 0px;
}

        .style2
        {
            font-size: medium;
            font-family: "Trebuchet MS";
        }
        .style3
        {
            color: #0033CC;
        }
        .style4
        {
            font-size: 13px;
        }
        .style5
        {
            color: #FFFFFF;
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
                <td colspan="7">
                <br />
                    <asp:Image ID="Image1" runat="server" Height="41px" 
                        ImageUrl="~/images/newlogo.png" Width="328px" />
                    <br />
                    <strong><span class="style2">&nbsp;&nbsp; Forgot your username / password ?</span></strong></td>
            </tr>
            <tr>
                <td class="style5">
                    11</td>
                <td colspan="6">
                    <hr class="style2" />
                </td>
            </tr>
            <tr>
                <td>
                    </td>
                <td colspan="6">
                    <span class="style3"><strong class="style4">After you answerd the sequrity 
                    question successfully your password reset&nbsp; code will send to your email. 
                    Check email and type that code bellow. After you type the code and click 
                    &#39;Validate&#39; you will redirect to yor profile. Reset your password / update 
                    information there.</strong></span></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="6">
                    <strong>Password Reset Question *</strong></td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="6">
                    <telerik:RadComboBox ID="RadComboBox1" Runat="server" Width="590px">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" Text="Who is your primary school teacher ?" 
                                Value="Who is your primary school teacher ?" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <strong>Answer </strong></td>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="3">

                    <telerik:RadTextBox ID="RadTextBox2" Runat="server" Width="450px">
                    </telerik:RadTextBox>

                </td>
                <td colspan="3">
                    <asp:Button ID="Button1" runat="server" CssClass="button" 
                        Text="Send" Width="100px" Height="30px" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <strong>Code</strong></td>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="3">

                    <telerik:RadTextBox ID="RadTextBox3" Runat="server" Width="450px">
                    </telerik:RadTextBox>

                </td>
                <td colspan="3">
                    <asp:Button ID="Button2" runat="server" CssClass="button" 
                        Text="Validate" Width="100px" Height="30px" Enabled="False" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;<telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                    </telerik:RadScriptManager>
                </td>
                <td>
                    &nbsp;</td>
                <td colspan="2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td colspan="6">
                    <strong><em>* If you have any problem please contact customer support (Using top 
                    menu.)</em></strong></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
