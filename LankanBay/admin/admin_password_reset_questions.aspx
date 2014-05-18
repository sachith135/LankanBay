<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true" CodeBehind="admin_password_reset_questions.aspx.cs" Inherits="LankanBay.admin.admin_password_reset_questions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="pageContainer">
        <table width="100%">
            <tr>
                <td class="style11" colspan="10">
                    <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" 
                        Text="Add / Edit Password Reset Questions"></asp:Label>
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
                    Password Reset Question
                </td>
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
                <td class="style13" colspan="10">
                    <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style13" colspan="10">                
                    
                    <telerik:RadGrid ID="dgPasswordResetQuestions" runat="server" Skin="Sitefinity" AutoGenerateColumns="False"
                        GridLines="None" AllowFilteringByColumn="True" AllowPaging="True" AllowSorting="True"
                        OnItemCommand="dgPasswordResetQuestions_ItemCommand" OnNeedDataSource="dgPasswordResetQuestions_NeedDataSource"
                        OnPageIndexChanged="dgPasswordResetQuestions_PageIndexChanged" OnPageSizeChanged="dgPasswordResetQuestions_PageSizeChanged"
                        OnSortCommand="dgPasswordResetQuestions_SortCommand" PageSize="5">
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
                                <telerik:GridBoundColumn DataField="PasswordResetQuestionId" HeaderText="PasswordResetQuestionId" 
                                    UniqueName="PasswordResetQuestionId" Display="False">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="PasswordResetQuestion" 
                                    HeaderText="Password Reset Question" UniqueName="PasswordResetQuestion">
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
