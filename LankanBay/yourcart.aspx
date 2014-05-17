<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yourcart.aspx.cs" Inherits="LankanBay.yourcart" %>

<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .style1
        {
            width: 500px;
        }
        .style2
        {
            height: 39px;
        }
        td
        {
        	vertical-align:top;
        }
        .style3
        {
            width: 19px;
        }
        .style4
        {
            width: 217px;
        }
        
        
    </style>

        <script type="text/javascript">
            function GetRadWindow() {
                var oWindow = null;
                if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog
                else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz az well) 
                return oWindow;
            }
            function CloseOnReload() {
                //alert("Dialog is about to close itself");                
                GetRadWindow().close();
                RefreshParentPage();
            }
            function RefreshParentPage() {
                //alert("Dialog is about to reload parent page");
                GetRadWindow().BrowserWindow.location.reload();
            }
            function RedirectParentPage(newUrl) {
                //alert("Dialog is about to redirect parent page to " + newUrl);
                GetRadWindow().BrowserWindow.document.location.href = newUrl;
            }
            function CallFunctionOnParentPage(fnName) {
                alert("Calling the function " + fnName + " defined on the parent page");
                var oWindow = GetRadWindow();
                if (oWindow.BrowserWindow[fnName] && typeof (oWindow.BrowserWindow[fnName]) == "function") {
                    oWindow.BrowserWindow[fnName](oWindow);
                }
            }
            function RefreshParentPageWithoutWarning() {
                GetRadWindow().BrowserWindow.document.forms[0].submit();
            } 
    </script>
     
     
    
    <link href="styles/sitemaster.css" rel="stylesheet" type="text/css" />
</head>
<body >
    <form id="form1" runat="server">
    <div>  

        <table class="style1">
            <tr>
                <td>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/images/shoppingcart.png" />
                    <hr  class="itemSeparator"/>
                </td>
            </tr>
            <tr >
                <td class="style2" style="height:200px;">
                    
                    <telerik:RadGrid ID="dgCart" runat="server" AutoGenerateColumns="False" 
                        GridLines="None" onitemcommand="dgCart_ItemCommand" Skin="Sitefinity" 
                        AllowPaging="True" PageSize="5" onneeddatasource="dgCart_NeedDataSource" 
                        onpageindexchanged="dgCart_PageIndexChanged" 
                        onpagesizechanged="dgCart_PageSizeChanged" onpdfexporting="dgCart_PdfExporting">
<MasterTableView>
<RowIndicatorColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridTemplateColumn HeaderText="Image" UniqueName="TempImage">
            <ItemTemplate>
                <asp:Image ID="image" runat="server" Height="30px" Width="40px" />
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="ItemId" Display="False" HeaderText="ItemId" 
            UniqueName="ItemId">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ItemName" HeaderText="Item Name" 
            UniqueName="ItemName">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Description" Display="False" 
            HeaderText="Description" UniqueName="Description">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="UnitPrice" HeaderText="Price" 
            UniqueName="UnitPrice">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DeliveryChargers" 
            HeaderText="Delivery" UniqueName="DeliveryChargers">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Total" HeaderText="Total" 
            UniqueName="Total">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Qty" HeaderText="Qty" 
            UniqueName="Qty">
        </telerik:GridBoundColumn>
        <telerik:GridTemplateColumn UniqueName="TempQty">
            <ItemTemplate>
                <telerik:RadNumericTextBox ID="txtReqQty" Runat="server" Width="30px" 
                    Font-Bold="True" AutoPostBack="True" 
                    ontextchanged="txtReqQty_TextChanged" Font-Size="10pt" Height="15px">
                    <NumberFormat DecimalDigits="0" GroupSeparator="" />
                </telerik:RadNumericTextBox>
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridButtonColumn CommandName="Delete" Text="Delete" 
            UniqueName="Delete" ButtonType="ImageButton" 
            ConfirmText="Are you sure you want to remove this item from cart ?" 
            ConfirmTitle="Conformation ..." ImageUrl="images/delete.ico">
        </telerik:GridButtonColumn>
    </Columns>
</MasterTableView>
                    </telerik:RadGrid>
                    
                </td>
            </tr>
            <tr>
                <td>
                <table>
                <tr>
                <td>
                <asp:ImageButton ID="btnCheckout" runat="server" 
                        ImageUrl="~/images/checkout.png" Width="120px" 
                        onclick="btnCheckout_Click" />
                </td>

                <td class="style3">
                
                    &nbsp;</td>
                <td class="style3">
                
                

                <asp:ImageButton ID="btnContinue" runat="server" 
                        ImageUrl="~/images/continueshopping.png" Width="120px" onclick="btnContinue_Click" 
                         />
                
                </td>

                <td class="style4" style="vertical-align:middle; text-align:right">
                
                    <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Size="Large" 
                        ForeColor="#CC3300"></asp:Label>
                
                </td>

                </tr>
                </table>
                    
                </td>
            </tr>
        </table>
    
    </div>
    <telerik:RadScriptManager ID="RadScriptManager1" Runat="server">
    </telerik:RadScriptManager>
    </form>
</body>
</html>
