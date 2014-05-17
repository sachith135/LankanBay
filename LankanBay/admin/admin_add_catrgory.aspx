<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true"
    CodeBehind="admin_add_catrgory.aspx.cs" Inherits="LankanBay.admin.admin_add_catrgory" %>

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
            width: 22px;
        }
        .style13
        {
        }
        .style14
        {
            width: 287px;
        }
        .style15
        {
            width: 91px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    

    <div class="pageContainer">
        <table class="style10">
            <tr>
                <td class="style11" colspan="10">
                    <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" Text="Add / Edit Categories"></asp:Label>
                    <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;
                </td>
                <td class="style12">
                    &nbsp;
                </td>
                <td class="style14">
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style15">
                    Category
                </td>
                <td class="style12">
                    :
                </td>
                <td class="style14">
                    <telerik:RadTextBox ID="txtCatrgory" runat="server" Width="350px" 
                        MaxLength="50">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCatrgory"
                        ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style15">
                    Description
                </td>
                <td class="style12">
                    :
                </td>
                <td class="style14">
                    <telerik:RadTextBox ID="txtDescription" runat="server" TextMode="MultiLine"
                        Width="350px" MaxLength="80">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDescription"
                        ErrorMessage="*" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style15">
                    Menu Order
                </td>
                <td class="style12">
                    &nbsp;</td>
                <td class="style14">
                    <telerik:RadNumericTextBox ID="txtOrderId" Runat="server" MaxLength="2" 
                        Width="350px">
                        <NumberFormat DecimalDigits="0" GroupSeparator="" />
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtOrderId"
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
                <td class="style15">
                    &nbsp;
                </td>
                <td class="style12">
                    &nbsp;
                </td>
                <td class="style14">
                    <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" />
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;
                </td>
                <td class="style12">
                    &nbsp;
                </td>
                <td class="style14">
                    <asp:CheckBox ID="chkIsViewInNavBar" runat="server" Text="Show in navigation bar" />
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style13" colspan="10">
                    <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style13" colspan="10">                
                    
                    <telerik:RadGrid ID="dgCategories" runat="server" Skin="Sitefinity" AutoGenerateColumns="False"
                        GridLines="None" AllowFilteringByColumn="True" AllowPaging="True" AllowSorting="True"
                        OnItemCommand="dgCategories_ItemCommand" OnNeedDataSource="dgCategories_NeedDataSource"
                        OnPageIndexChanged="dgCategories_PageIndexChanged" OnPageSizeChanged="dgCategories_PageSizeChanged"
                        OnSortCommand="dgCategories_SortCommand" PageSize="5">
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
                                <telerik:GridBoundColumn DataField="CategoryId" Display="False" HeaderText="CategoryId"
                                    UniqueName="CategoryId">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Name" HeaderText="Category" UniqueName="Name"
                                    FilterControlWidth="80%">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Description" HeaderText="Description" UniqueName="Description"
                                    FilterControlWidth="80%">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="IsViewInNavBar" Display="False" HeaderText="IsViewInNavBar"
                                    UniqueName="IsViewInNavBar" FilterControlWidth="80%">
                                </telerik:GridBoundColumn>
                                <telerik:GridCheckBoxColumn DataField="IsViewInNavBar" HeaderText="Nav.Bar" UniqueName="IsViewInNavBar1"
                                    FilterControlWidth="80%">
                                    <ItemStyle Width="15px" />
                                </telerik:GridCheckBoxColumn>
                                <telerik:GridBoundColumn DataField="IsActive" Display="False" HeaderText="IsActive"
                                    UniqueName="IsActive">
                                </telerik:GridBoundColumn>
                                <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" UniqueName="IsActive1"
                                    FilterControlWidth="80%">
                                    <ItemStyle Width="15px" />
                                </telerik:GridCheckBoxColumn>
                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" Text="Edit"
                                    UniqueName="Edit" ImageUrl="~/images/edit.ico">
                                    <ItemStyle Width="15px" />
                                </telerik:GridButtonColumn>
                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" Text="Delete"
                                    UniqueName="Delete" ConfirmDialogHeight="100px" ConfirmDialogWidth="300px" ConfirmText="Are you sure you want to delete this category ?"
                                    ConfirmTitle="Confirmation ...">
                                    <ItemStyle Width="15px" />
                                </telerik:GridButtonColumn>
                            </Columns>
                            <CommandItemStyle HorizontalAlign="Right" />
                        </MasterTableView>
                    </telerik:RadGrid>
            
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
