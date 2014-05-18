<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/sitemaster.Master" AutoEventWireup="true" CodeBehind="checkout.aspx.cs" Inherits="LankanBay.checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 2px;
        }
        .style11
        {
            width: 283px;
        }
        .style12
        {
            width: 336px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="pageContainer">

<%@ Import Namespace="System.Data" %>
                   <%@ Import Namespace="SERVICE" %>
                   <%@ Import Namespace="DOMAIN" %>

                   <%
                       BusinessPartnerAddress businessPartnerAddress = new BusinessPartnerAddress();
                       BusinessPartnerAddressService businessPartnerAddressService = new BusinessPartnerAddressService();

                       DataTable dtBSPAddressDetails = new DataTable();        
                                                
                   %>

    <table  width="100%" >
        <tr>
            <td colspan="2" class="style13">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Trebuchet MS" 
                    Font-Size="Large" Text="Order review and Checkout"></asp:Label>
            &nbsp;
            <hr class="separator" />
            </td>
        </tr>
        <tr>
        <td class="style10" style="vertical-align:bottom">
        <img src="images/warnning.png" width="15px" />
         <hr class="separator" />
        </td>
            <td style="vertical-align:bottom" class="style14">
                
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="Small" 
                    
                    Text="You&amp;#39;re almost done! Until you complete checkout, another Lankan Bay user may buy .!" 
                    ForeColor="#0033CC"></asp:Label>

               
                                 <hr class="separator" />
                
                 </td>
        </tr>
        <tr>
            <td colspan="2">
            
            <div class="itemImageContainer" style="padding:5px;">
                <table width="100%">
                
                    <tr>
                        <td style="vertical-align:middle" class="style12">

                        <table width="100%">
                        <tr>                        
                        <td style="vertical-align:middle">
                            <img src="images/delevery.png" width="25" title="Shipping address"/>
                        </td>
                        <td style="vertical-align:middle">
                        &nbsp;
                            <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Medium" 
                                Text="Deliver to "></asp:Label>
                        </td>
                        </tr>
                        </table>
                            
                           <hr class="itemSeparator" />
                            
                        </td>
                        <td class="style11">
                             <table>
                        <tr>                        
                        <td style="vertical-align:middle">
                            <img src="images/paymentoption.png" width="25" title="Payment option(s)"/>
                        </td>
                        <td style="vertical-align:middle">
                         &nbsp;
                            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Medium" 
                                Text="Pay with"></asp:Label>
                        </td>
                        </tr>
                        </table>
                         <hr class="itemSeparator" />
                        </td>
                        <td colspan="2">

                        <table width="100%">
                        <tr>                        
                        <td style="vertical-align:middle">
                            <img src="images/price.png" width="25" title="Payment option(s)"/>
                        </td>
                        <td style="vertical-align:middle">
                         &nbsp;
                            <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Medium" 
                                Text="Total Amount"></asp:Label>
                        </td>
                        </tr>
                        </table>
                         <hr class="itemSeparator" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style12">
                        <p style=" max-width:300px; width:300px; height:80px; text-align:left; font-size:14px;">
                            <%
                             try
                             {
                                 businessPartnerAddress.BSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);
                                 businessPartnerAddress.IsShippingMail = true;
                                 dtBSPAddressDetails = businessPartnerAddressService.Select(businessPartnerAddress);
                                 if (dtBSPAddressDetails.Rows.Count != 0)
                                 {
                                     Response.Write(dtBSPAddressDetails.Rows[0]["AddressLine01"].ToString() + " ,");
                                     Response.Write(dtBSPAddressDetails.Rows[0]["AddressLine02"].ToString() + " ,");
                                     //Response.Write(dtBSPAddressDetails.Rows[0]["AddressLine03"].ToString() + " ,");
                                     Response.Write(dtBSPAddressDetails.Rows[0]["City"].ToString() + " ,");
                                     Response.Write(dtBSPAddressDetails.Rows[0]["State"].ToString() + " ,<br>");
                                     Response.Write(dtBSPAddressDetails.Rows[0]["ZipCode"].ToString() + ".");
                                 }
                             }
                             catch (Exception)
                             {
                                 LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                                 master.MessageBox(CommonParameterNames.MessageBoxType.InformationMessage, CommonUserMessages.InformationMessages.notloggedin);
                                 Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                             }
                            
                             
                             
                             
                          %>

                         </p>

                        </td>
                        <td class="style11">
                         <img src="images/paymentoption_paypal.png" />
                         </td>
                        <td colspan="2">
                            <table class="style8">
                                <tr>
                                    <td>
                
                    <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Size="Large" 
                        ForeColor="#CC3300"></asp:Label>
                
                                    </td>
                                </tr>
                                <tr>
                                    <td>                               

                                        <asp:ImageButton ID="ImageButton1" runat="server" 
                                            ImageUrl="~/images/paynow.png" Width="120px" 
                                            onclick="ImageButton1_Click" />
                
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                   </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                 
                    <tr>
                        <td class="style12">
                            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" 
                                Font-Size="Small">Change Delivery Address</asp:LinkButton>
                        </td>
                        <td class="style11">
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                        <td>
                            &nbsp;</td>
                    </tr>              
                </table>
            </div>
              <br />

            <div class="pageContainer">
            
                        
            
                <telerik:RadGrid ID="dgCart" runat="server" AllowPaging="True" 
                    AllowSorting="True" AutoGenerateColumns="False" GridLines="None" 
                    Skin="Sitefinity">
<MasterTableView>
<RowIndicatorColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridImageColumn DataImageUrlFields="ImagePath" HeaderText="Image" 
            ImageHeight="40px" ImageWidth="60px" UniqueName="ImagePath">
        </telerik:GridImageColumn>
        <telerik:GridBoundColumn DataField="ItemName" HeaderText="Item" 
            UniqueName="ItemName">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Description" HeaderText="Description" 
            UniqueName="Description">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Qty" HeaderText="Qty" UniqueName="Qty">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="UnitPrice" HeaderText="Price" 
            UniqueName="UnitPrice">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="DeliveryChargers" HeaderText="Delivery" 
            UniqueName="DeliveryChargers">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Total" HeaderText="Total" 
            UniqueName="Total">
        </telerik:GridBoundColumn>
    </Columns>
</MasterTableView>
                </telerik:RadGrid>
            
                        
            
            </div>
        </tr>
    </table>
    </div>

</asp:Content>
