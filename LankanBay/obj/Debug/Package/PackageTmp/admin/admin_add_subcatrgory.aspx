<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true" CodeBehind="admin_add_subcatrgory.aspx.cs" Inherits="LankanBay.admin.admin_add_subcatrgory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 100%;
        }
        .style11
        {
        }
        .style12
        {
            width: 26px;
        }
        .style13
        {
            width: 156px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="pageContainer">
    <table class="style10">
        <tr>
            <td colspan="10">
                <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" 
                    Text="Add / Edit Sub Categories"></asp:Label>
                <hr class="separator" />
            </td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style13">
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                Category</td>
            <td class="style12">
                :</td>
            <td class="style13">
                <telerik:RadComboBox ID="cmbCategory" Runat="server" Width="354px">
                </telerik:RadComboBox>
            </td>
            <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="cmbCategory"
                        ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
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
            <td class="style11">
                Sub Category</td>
            <td class="style12">
                :</td>
            <td class="style13">
                <telerik:RadTextBox ID="txtSubCategory" Runat="server" Width="350px" 
                    MaxLength="50">
                </telerik:RadTextBox>
            </td>
            <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSubCategory"
                        ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
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
            <td class="style11">
                Description</td>
            <td class="style12">
                :</td>
            <td class="style13">
                <telerik:RadTextBox ID="txtDescription" Runat="server" 
                    TextMode="MultiLine" Width="350px" MaxLength="80">
                </telerik:RadTextBox>
            </td>
            <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDescription"
                        ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
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
            <td class="style11">
                Menu Order</td>
            <td class="style12">
                :</td>
            <td class="style13">
                <telerik:RadNumericTextBox ID="txtOrderId" Runat="server" Width="350px">
                    <NumberFormat DecimalDigits="0" />
                </telerik:RadNumericTextBox>
            </td>
            <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtOrderId"
                        ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
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
            <td class="style11">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style13">
                <asp:CheckBox ID="chkIsViewInNavBar" runat="server" 
                    Text="Show in navigation bar" />
            </td>
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style13">
                <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" />
            </td>
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11" colspan="10">
                <hr class="separator" />
            </td>
        </tr>
        <tr>
            <td class="style11" colspan="10">
                <telerik:RadGrid ID="dgSubcategories" runat="server" AllowFilteringByColumn="True" 
                    AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                    GridLines="None" Skin="Sitefinity" 
                    onitemcommand="dgSubcategories_ItemCommand" 
                    onneeddatasource="dgSubcategories_NeedDataSource" 
                    onpageindexchanged="dgSubcategories_PageIndexChanged" 
                    onpagesizechanged="dgSubcategories_PageSizeChanged" 
                    onpdfexporting="dgSubcategories_PdfExporting" 
                    onselectedindexchanged="dgSubcategories_SelectedIndexChanged">
<MasterTableView CommandItemDisplay="Top">
<RowIndicatorColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <CommandItemSettings ShowAddNewRecordButton="False" 
        ShowExportToCsvButton="True" />
    <Columns>
        <telerik:GridBoundColumn DataField="OrderId" HeaderText="Order" 
            UniqueName="OrderId">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="SubCategoryId" Display="False" 
            HeaderText="SubCategoryId" UniqueName="SubCategoryId">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="CategoryId" HeaderText="CategoryId" 
            UniqueName="CategoryId" Display="False">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Category" HeaderText="Category" 
            UniqueName="Category" FilterControlWidth="80%">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Name" HeaderText="Sub Category" 
            UniqueName="Name" FilterControlWidth="80%">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Description" HeaderText="Description" 
            UniqueName="Description" FilterControlWidth="80%">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IsViewInNavBar" Display="False" 
            HeaderText="IsViewInNavBar" UniqueName="IsViewInNavBar" 
            FilterControlWidth="80%">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="IsViewInNavBar" HeaderText="Nav.Bar" 
            UniqueName="IsViewInNavBar1" FilterControlWidth="80%">
            <ItemStyle Width="15px" />
        </telerik:GridCheckBoxColumn>
        <telerik:GridBoundColumn DataField="IsActive" Display="False" 
            HeaderText="IsActive" UniqueName="IsActive">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" 
            UniqueName="IsActive1" FilterControlWidth="80%">
        </telerik:GridCheckBoxColumn>
        <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" 
            ImageUrl="../images/edit.ico" Text="Edit" UniqueName="Edit">
            <ItemStyle Width="15px" />
        </telerik:GridButtonColumn>
        <telerik:GridButtonColumn CommandName="Delete" Text="Delete" 
            UniqueName="Delete" ButtonType="ImageButton" ConfirmDialogHeight="100px" 
            ConfirmDialogType="RadWindow" ConfirmDialogWidth="300px" 
            ConfirmText="Are you sure you want to delete this sub category with all items ?" 
            ConfirmTitle="Confirmation ...">
            <ItemStyle Width="15px" />
        </telerik:GridButtonColumn>
    </Columns>
</MasterTableView>
                </telerik:RadGrid>
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
