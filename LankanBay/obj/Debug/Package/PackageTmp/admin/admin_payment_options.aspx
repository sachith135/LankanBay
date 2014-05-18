<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true" CodeBehind="admin_payment_options.aspx.cs" Inherits="LankanBay.admin.admin_payment_options" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


<div class="pageContainer">
        <table width="100%">
            <tr>
                <td class="style11" colspan="10">
                    <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" 
                        Text="Add / Edit  Item Contition Details"></asp:Label>
                    <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style15">
                    &nbsp;
                </td>
                <td class="style10">
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
                    Item Condition</td>
                <td class="style10">
                    :
                </td>
                <td class="style14">
                    <telerik:RadTextBox ID="txtCatrgory" runat="server" Width="500px" 
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
                    &nbsp;
                </td>
                <td class="style10">
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
                    &nbsp;</td>
                <td class="style10">
                    &nbsp;</td>
                <td class="style14">
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
                <td class="style13" colspan="10">
                    <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style13" colspan="10">                
                    
                    <telerik:RadGrid ID="dgItemCoditions" runat="server" Skin="Sitefinity" AutoGenerateColumns="False"
                        GridLines="None" AllowFilteringByColumn="True" AllowPaging="True" AllowSorting="True"
                        PageSize="5">
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
                                <telerik:GridBoundColumn DataField="ItemConditionId" HeaderText="ItemConditionId" 
                                    UniqueName="ItemConditionId" Display="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="ItemCondition" 
                                    HeaderText="ItemCondition" 
                                    UniqueName="ItemCondition" FilterControlWidth="90%">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="IsActive" Display="False" HeaderText="IsActive"
                                    UniqueName="IsActive1">
                                </telerik:GridBoundColumn>
                                <telerik:GridCheckBoxColumn DataField="IsActive" HeaderText="Active" 
                                    UniqueName="IsActive">
                                    <ItemStyle Width="15px" />
                                </telerik:GridCheckBoxColumn>
                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" Text="Delete"
                                    UniqueName="Delete" ConfirmDialogHeight="100px" ConfirmDialogWidth="300px" ConfirmText="Are you sure you want to delete this category ?"
                                    ConfirmTitle="Confirmation ...">
                                    <ItemStyle Width="15px" />
                                </telerik:GridButtonColumn>
                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Select" Text="Edit"
                                    UniqueName="Edit" ImageUrl="~/images/edit.ico">
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
