<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true"
    CodeBehind="sup_additem.aspx.cs" Inherits="LankanBay.admin.sup_additem" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style12
        {
            font-size: 13px;
        }
        .style14
        {
            text-align: left;
            width: 16px;
        }
        .style15
        {
            text-align: left;
            width: 228px;
        }
        .style17
        {
            text-align: left;
            width: 150px;
        }
        .style18
        {
            text-align: left;
            width: 18px;
        }
        .style23
        {
            text-align: left;
            font-size: 13px;
            font-weight: bold;
        }
        .style25
        {
            width: 30px;
            text-align: left;
        }
        .style26
        {
            text-align: left;
            font-weight: bold;
        }
        .style27
        {
            text-align: left;
            width: 286px;
        }
        .style28
        {
            text-align: left;
            width: 161px;
            
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
        <div class="pageContainer">
            <table cellpadding="2" width="950px">
                <tr>
                    <td colspan="7" style="text-align: left; padding: 3px;">
                        <b><span class="style12">Add / Edit Item Details</span></b>
                        <hr class="separator" />
                    </td>
                    <td style="text-align: left; padding: 3px;">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Supplier
                    </td>
                    <td class="style14">
                        :
                    </td>
                    <td class="style15">
                        <telerik:RadComboBox ID="cmbSupplier" runat="server" Width="254px">
                        </telerik:RadComboBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="cmbSupplier"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Item Description (*imp)
                    </td>
                    <td class="style18">
                        :
                    </td>
                    <td class="style27">
                        <telerik:RadTextBox ID="txtItemDescrption" runat="server" Width="270px" 
                            MaxLength="88">
                        </telerik:RadTextBox>
                    </td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtItemDescrption"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Category
                    </td>
                    <td class="style14">
                        :
                    </td>
                    <td class="style15">
                        <telerik:RadComboBox ID="cmbCategory" runat="server" Width="254px" OnSelectedIndexChanged="cmbCategory_SelectedIndexChanged"
                            AutoPostBack="True">
                        </telerik:RadComboBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cmbCategory"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Unit Price (LKR)
                    </td>
                    <td class="style18">
                        :
                    </td>
                    <td class="style27">
                        <telerik:RadNumericTextBox ID="txtUnitPrice" runat="server" Width="270px">
                        </telerik:RadNumericTextBox>
                    </td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="cmbDeleveryOption"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Sub Category
                    </td>
                    <td class="style14">
                        :
                    </td>
                    <td class="style15">
                        <telerik:RadComboBox ID="cmbSubCategory" runat="server" Width="254px">
                        </telerik:RadComboBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="cmbSubCategory"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Deliver Chargers
                    </td>
                    <td class="style18">
                        :
                    </td>
                    <td class="style27">
                        <telerik:RadNumericTextBox ID="txtDeleveryChargers" runat="server" 
                            Width="270px">
                        </telerik:RadNumericTextBox>
                    </td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtDeleveryChargers"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Item Name
                    </td>
                    <td class="style14">
                        :
                    </td>
                    <td class="style15">
                        <telerik:RadTextBox ID="txtItemName" runat="server" Width="250px">
                        </telerik:RadTextBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtItemName"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Delivery Descrition</td>
                    <td class="style18">
                        :
                    </td>
                    <td class="style27">
                        <telerik:RadTextBox ID="txtDeliveryDescription" runat="server" Width="270px">
                        </telerik:RadTextBox>
                    </td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtReturnDescription"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Delivery Option
                    </td>
                    <td class="style14">
                        :
                    </td>
                    <td class="style15">
                        <telerik:RadComboBox ID="cmbDeleveryOption" runat="server" Width="254px" AutoPostBack="True"
                            OnSelectedIndexChanged="cmbDeleveryOption_SelectedIndexChanged">
                        </telerik:RadComboBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtUnitPrice"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Return Description
                    </td>
                    <td class="style18">
                        :
                    </td>
                    <td class="style27">
                        <telerik:RadTextBox ID="txtReturnDescription" runat="server" Width="270px">
                        </telerik:RadTextBox>
                    </td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtWarrentyDescription"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Item Condition
                    </td>
                    <td class="style14">
                        :
                    </td>
                    <td class="style15">
                        <telerik:RadComboBox ID="cmbItemCondition" runat="server" Width="254px">
                        </telerik:RadComboBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="cmbItemCondition"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Warrenty Description</td>
                    <td class="style18">
                        :
                    </td>
                    <td class="style27">
                     <telerik:RadTextBox ID="txtWarrentyDescription" runat="server" Width="270px">
                        </telerik:RadTextBox>
                    </td>
                    <td class="style7">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Purchasing Method
                    </td>
                    <td class="style14">
                        :
                    </td>
                    <td class="style15">
                        <telerik:RadComboBox ID="cmbPurchasingMethod" runat="server" Width="254px">
                        </telerik:RadComboBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="cmbPurchasingMethod"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Item Web Page URL</td>
                    <td class="style18">
                        &nbsp;:
                    </td>
                    <td class="style27">
                        <telerik:RadTextBox ID="txtItemWebPageURL" Runat="server" Width="270px">
                        </telerik:RadTextBox>
                        </td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtItemWebPageURL"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style28">
                        Buyer Protection
                    </td>
                    <td class="style14">
                        &nbsp;</td>
                    <td class="style15">
                        <asp:RadioButton ID="radYes" runat="server" GroupName="BuyerProtection" 
                            Text="Yes" Checked="True" />
                        &nbsp;
                        <asp:RadioButton ID="radNo" runat="server" GroupName="BuyerProtection" Text="No" />
                    </td>
                    <td class="style25">
                        &nbsp;</td>
                    <td class="style17">
                        &nbsp;</td>
                    <td class="style18">
                        &nbsp;</td>
                    <td class="style27">
                       
                        <asp:CheckBox ID="chkIsViewInNavigationBar" runat="server" 
                            Text="  View in navigation bar" />
                             &nbsp;&nbsp;
                        <asp:CheckBox ID="chkIsActive" runat="server" Text="  Active" />
                    </td>
                    <td class="style7">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style26" colspan="7">
                    * imp : Item descrition will appear in the item page above the item image. Make sure you have enter fully detail description with suppotive search tags. 
                       
                       <hr style="margin-bottom:5px; margin-top:5px;" class="separator"/>
                        <span class="style12">Inventory Details</span>
                        <hr class="separator"/>

                        </td>
                    <td class="style7">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style28">
                        Quantity In Hand</td>
                    <td class="style14">
                        :</td>
                    <td class="style15">
                        <telerik:RadNumericTextBox ID="txtQtyInHand" Runat="server" Width="250px">
                        </telerik:RadNumericTextBox>
                    </td>
                    <td class="style25">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtQtyInHand"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style17">
                        Alert Quantity</td>
                    <td class="style18">
                        :</td>
                    <td class="style27">
                        <telerik:RadNumericTextBox ID="txtReOrderLevel" Runat="server" Width="270px">
                        </telerik:RadNumericTextBox>
                    </td>
                    <td class="style7">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtReOrderLevel"
                            ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style23" colspan="7">
                        <hr class="separator" style="margin-bottom:5px"/>
                        Currunt Items
                        <hr class="separator" />
                    </td>
                    <td class="style7">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="7" style="text-align: left; padding-bottom:10px;">
                        <telerik:RadGrid ID="dgSellersItems" runat="server" AutoGenerateColumns="False" GridLines="None"
                            AllowFilteringByColumn="True" AllowPaging="True" AllowSorting="True" 
                            BorderStyle="Solid" Skin="Sitefinity">
                            <MasterTableView>
                                <RowIndicatorColumn>
                                    <HeaderStyle Width="20px"></HeaderStyle>
                                </RowIndicatorColumn>
                                <ExpandCollapseColumn>
                                    <HeaderStyle Width="20px"></HeaderStyle>
                                </ExpandCollapseColumn>
                                <Columns>
                                    <telerik:GridBoundColumn DataField="ItemId" HeaderText="Item Id" UniqueName="ItemId"
                                        FilterControlWidth="25px">
                                        <ItemStyle HorizontalAlign="Left" Width="25px" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="Category" HeaderText="Category" UniqueName="Category"
                                        FilterControlWidth="80%">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="SubCategory" HeaderText="Sub Category" UniqueName="SubCategory"
                                        FilterControlWidth="80%">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="ItemName" HeaderText="Item Name" UniqueName="ItemName"
                                        FilterControlWidth="80%">
                                        <ItemStyle HorizontalAlign="Left" Width="200px" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="ItemDescription" Display="False" HeaderText="Item Description"
                                        UniqueName="ItemDescription" FilterControlWidth="80%">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridBoundColumn DataField="UnitPrice" HeaderText="Unit Price" UniqueName="UnitPrice"
                                        FilterControlWidth="80%">
                                        <ItemStyle HorizontalAlign="Right" />
                                    </telerik:GridBoundColumn>
                                    <telerik:GridCheckBoxColumn DataField="IsBuyerProtection" HeaderText="B.Pro" UniqueName="IsBuyerProtection">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridCheckBoxColumn>
                                    <telerik:GridCheckBoxColumn DataField="IsViewInNavBar" HeaderText="Nav.Bar" UniqueName="IsViewInNavBar">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridCheckBoxColumn>
                                    <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" UniqueName="IsActive">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridCheckBoxColumn>
                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" HeaderText="Edit"
                                        Text="Edit" UniqueName="Edit" ImageUrl="~/images/edit.ico">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridButtonColumn>
                                    <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" HeaderText="Delete"
                                        Text="Delete" UniqueName="Delete">
                                        <ItemStyle HorizontalAlign="Left" />
                                    </telerik:GridButtonColumn>
                                </Columns>
                            </MasterTableView>
                        </telerik:RadGrid>
                    </td>
                    <td class="style7">
                        &nbsp;
                    </td>
                </tr>
               
            </table>
        </div>

</asp:Content>
