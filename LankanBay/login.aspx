<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="LankanBay.login" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="styles/sitemaster.css" rel="stylesheet" type="text/css" />
    <link href="styles/adminmaster.css" rel="stylesheet" type="text/css" />
    <style>
        
    body
    {
    	margin:0;
    	padding:0;
    	background-image:url('images/loginbg.png');  	
    }
    
        .style1
        {
            width: 100%;
            height: 650px;
        }
        .style2
        {
            height: 72px;
        }
        .style3
        {
            height: 482px;
        }
        .style4
        {
            height: 72px;
            width: 922px;
        }
            
        .style7
        {
            width: 100%;
            height: 441px;
        }
    
        .divround
        {
        	-webkit-border-radius: 15px;
        	-moz-border-radius: 15px;
        	border-radius: 15px;
        	background-color:#C7C7C7; 
        	padding:20px;
        	
        	background: rgb(245,246,246); /* Old browsers */
/* IE9 SVG, needs conditional override of 'filter' to 'none' */
background: url(data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiA/Pgo8c3ZnIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgd2lkdGg9IjEwMCUiIGhlaWdodD0iMTAwJSIgdmlld0JveD0iMCAwIDEgMSIgcHJlc2VydmVBc3BlY3RSYXRpbz0ibm9uZSI+CiAgPGxpbmVhckdyYWRpZW50IGlkPSJncmFkLXVjZ2ctZ2VuZXJhdGVkIiBncmFkaWVudFVuaXRzPSJ1c2VyU3BhY2VPblVzZSIgeDE9IjAlIiB5MT0iMCUiIHgyPSIxMDAlIiB5Mj0iMCUiPgogICAgPHN0b3Agb2Zmc2V0PSIwJSIgc3RvcC1jb2xvcj0iI2Y1ZjZmNiIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjIxJSIgc3RvcC1jb2xvcj0iI2RiZGNlMiIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjQ5JSIgc3RvcC1jb2xvcj0iI2I4YmFjNiIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjgwJSIgc3RvcC1jb2xvcj0iI2RkZGZlMyIgc3RvcC1vcGFjaXR5PSIxIi8+CiAgICA8c3RvcCBvZmZzZXQ9IjEwMCUiIHN0b3AtY29sb3I9IiNmNWY2ZjYiIHN0b3Atb3BhY2l0eT0iMSIvPgogIDwvbGluZWFyR3JhZGllbnQ+CiAgPHJlY3QgeD0iMCIgeT0iMCIgd2lkdGg9IjEiIGhlaWdodD0iMSIgZmlsbD0idXJsKCNncmFkLXVjZ2ctZ2VuZXJhdGVkKSIgLz4KPC9zdmc+);
background: -moz-linear-gradient(left,  rgba(245,246,246,1) 0%, rgba(219,220,226,1) 21%, rgba(184,186,198,1) 49%, rgba(221,223,227,1) 80%, rgba(245,246,246,1) 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, right top, color-stop(0%,rgba(245,246,246,1)), color-stop(21%,rgba(219,220,226,1)), color-stop(49%,rgba(184,186,198,1)), color-stop(80%,rgba(221,223,227,1)), color-stop(100%,rgba(245,246,246,1))); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(left,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(left,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(left,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* IE10+ */
background: linear-gradient(to right,  rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f5f6f6', endColorstr='#f5f6f6',GradientType=1 ); /* IE6-8 */


-webkit-border-radius: 20px;
-moz-border-radius: 20px;
border-radius: 20px;
border:3px solid #FFFFFF;

        }
    
        .style9
        {
            width: 922px;
        }
    
        .style10
        {
            height: 47px;
        }
    
        .style11
        {
            height: 27px;
        }
    
        .style12
        {
            font-size: 13px;
        }
    
        .style13
        {
            width: 100%;
        }
    
        .style14
        {
        }
        .style15
        {
            width: 14px;
        }
    
        .style16
        {
            font-weight: bold;
            font-size:13px;
        }
        
        .btnCenter
        {
        	text-align:center;
        }
    
        .style17
        {
            color: #3333FF;
            font-weight: bold;
        }
            
        .style19
        {
            text-align: center;
            font-weight: bold;
        }
        .style20
        {
            color: #666666;
        }
        
        .button
{
	text-align:center;
	color:White;
	font-weight:bold;
	
background: rgb(109,179,242); /* Old browsers */
background: -moz-linear-gradient(top,  rgba(109,179,242,1) 0%, rgba(84,163,238,1) 50%, rgba(54,144,240,1) 51%, rgba(30,105,222,1) 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(109,179,242,1)), color-stop(50%,rgba(84,163,238,1)), color-stop(51%,rgba(54,144,240,1)), color-stop(100%,rgba(30,105,222,1))); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(top,  rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(top,  rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(top,  rgba(109,179,242,1) 0%,rgba(84,163,238,1) 50%,rgba(54,144,240,1) 51%,rgba(30,105,222,1) 100%); /* IE10+ */
background: rgb(109,179,242); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#6db3f2', endColorstr='#1e69de',GradientType=0 ); /* IE6-9 */

}

.button : hover
{
background: rgb(235,241,246); /* Old browsers */
background: -moz-linear-gradient(top,  rgba(235,241,246,1) 0%, rgba(171,211,238,1) 50%, rgba(137,195,235,1) 51%, rgba(213,235,251,1) 100%); /* FF3.6+ */
background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(235,241,246,1)), color-stop(50%,rgba(171,211,238,1)), color-stop(51%,rgba(137,195,235,1)), color-stop(100%,rgba(213,235,251,1))); /* Chrome,Safari4+ */
background: -webkit-linear-gradient(top,  rgba(235,241,246,1) 0%,rgba(171,211,238,1) 50%,rgba(137,195,235,1) 51%,rgba(213,235,251,1) 100%); /* Chrome10+,Safari5.1+ */
background: -o-linear-gradient(top,  rgba(235,241,246,1) 0%,rgba(171,211,238,1) 50%,rgba(137,195,235,1) 51%,rgba(213,235,251,1) 100%); /* Opera 11.10+ */
background: -ms-linear-gradient(top,  rgba(235,241,246,1) 0%,rgba(171,211,238,1) 50%,rgba(137,195,235,1) 51%,rgba(213,235,251,1) 100%); /* IE10+ */
background: linear-gradient(to bottom,  rgba(235,241,246,1) 0%,rgba(171,211,238,1) 50%,rgba(137,195,235,1) 51%,rgba(213,235,251,1) 100%); /* W3C */
filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#ebf1f6', endColorstr='#d5ebfb',GradientType=0 ); /* IE6-9 */

}

    
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                </td>
                <td class="style4">
                </td>
                <td style="max-width:290px; min-width:290px" class="style2">
                </td>
            </tr>
            <tr>
                <td class="style3">
                </td>
                <td class="style9">
                    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
                    </telerik:RadScriptManager>
                </td>
                <td width="265px" style="vertical-align:top; padding-right:30px; text-align:right;">

                <div class="divround">
                    <table class="style7" >
                        <tr>
                             <td  colspan="3" style="text-align:left; vertical-align:top;" class="style10">
                             <span style="font-family:Trebuchet MS; font-size:13px; font-weight:bold">&nbsp; Welcome to ...</span>
                             <br /> 
                                <asp:Image ID="Image1" runat="server" Height="40px" 
                                    ImageUrl="~/images/newlogo.png" Width="229px" />
                                <br />
                                
                            </td>
                        </tr>
                        <tr>
                            <td class="style11" colspan="3">
                            <hr style="color:Gray; height:1px; margin-bottom:5px;"/>                              
                            &nbsp; <b class="style12">User login<hr style="color:Gray; height:1px; "/></td>
                        </tr>
                        <tr>
                            <td colspan="3">
                                <table cellpadding="5" cellspacing="0" class="style13">
                                    <tr>
                                        <td class="style14">
                                            &nbsp;</td>
                                        <td class="style15">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style16">
                                            Username</td>
                                        <td class="style15">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style14" colspan="4">
                                            <table cellpadding="0" cellspacing="0" class="style13">
                                                <tr>
                                                    <td>
                                            <telerik:RadTextBox ID="txtUsername" runat="server" Width="220px">
                                            </telerik:RadTextBox>
                                                    </td>
                                                    <td>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                                            ControlToValidate="txtUsername" ErrorMessage="*" Font-Bold="True" 
                                                            ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style16">
                                            Password</td>
                                        <td class="style15">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style14" colspan="4">
                                            <table cellpadding="0" cellspacing="0" class="style13">
                                                <tr>
                                                    <td>
                                            <telerik:RadTextBox ID="txtPassword" runat="server" Width="220px" TextMode="Password">
                                            </telerik:RadTextBox>
                                                    </td>
                                                    <td>
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                                            ControlToValidate="txtPassword" ErrorMessage="*" Font-Bold="True" 
                                                            ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                  
                                    <tr style="text-align:center;">
                                        <td class="style14" colspan="4">
                                          <asp:Button ID="btnLogin" runat="server" Text="LOGIN" Width="129px" 
                                               Height="28px" CssClass="btnCenter" onclick="btnLogin_Click" 
                                                ValidationGroup="i"/> 
                                                &nbsp; &nbsp;
                                            <asp:Button ID="btnClear" runat="server" Text="CLEAR" Width="74px" 
                                               Height="28px" onclick="btnClear_Click"  CssClass="btnCenter"/>
                                         </td>
                                    </tr>
                                  
                                    <tr style="text-align:center;">
                                        <td class="style14" colspan="4">
                                           
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="style14">
                                            &nbsp;</td>
                                        <td class="style15">
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                        <td>
                                            &nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td class="style17" colspan="4" >
                                        <a href="" target="_blank" style="color:Navy">Forgot your password or your username?</a>    
                                            
                                        <a href="" target="_blank" style="color:Navy"><b>Don&#39;t&nbsp; you have an account?</b> </a>
                                            <asp:LinkButton ID="lnkBtnUserRegistration" runat="server" ForeColor="Red" 
                                                onclick="lnkBtnUserRegistration_Click">It&#39;s Free</asp:LinkButton>
&nbsp;<br />
                                        <a href="" target="_blank" style="color:Navy">Read user's agreement policy first...</a>    
                                            </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                              </td>
                        </tr>
                        <tr>
                            <td colspan="3">
                             <hr style="color:Gray; height:1px; "/>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="3" class="style19">
                                <span class="style20">~ Software Solution By ~
                                </span>
                                <br class="style20" />
                                <span class="style20">National Institute of Business Management </span> 
                                <br class="style20" />
                                <span class="style20">HDCBIS 12.1 - Galle Branch
                                </span>
                                </td>
                          
                        </tr>
                        <tr>
                            <td colspan="3">
                            <hr style="color:Gray; height:1px; "/>
                            </td>
                        </tr>
                    </table>
                </div>

                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style9">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
    </telerik:RadWindowManager>
    <telerik:RadWindow ID="RadWindow1" runat="server">
    </telerik:RadWindow>


    </form>
</body>
</html>
