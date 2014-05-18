<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true" CodeBehind="admin_view_notification_quequ.aspx.cs" Inherits="LankanBay.admin.admin_view_notification_quequ" %>
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
                    Customer Name</td>
                <td class="style10">
                    :
                </td>
                <td class="style14">
                    <telerik:RadComboBox ID="RadComboBox1" Runat="server" Width="500px">
                        <Items>
                            <telerik:RadComboBoxItem runat="server" 
                                Text="Sachith Nuwan Kalehe Watta - BSP135201" 
                                Value="Sachith Nuwan Kalehe Watta - BSP135201" />
                        </Items>
                    </telerik:RadComboBox>
                </td>
                <td>
                    &nbsp;</td>
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
                    
                            <telerik:RadGrid ID="dgNotification" runat="server" AllowPaging="True" AllowSorting="True" 
                                AutoGenerateColumns="False" GridLines="None" 
                                ondetailtabledatabind="dgNotification_DetailTableDataBind" 
                                onneeddatasource="dgNotification_NeedDataSource" 
                                onpageindexchanged="dgNotification_PageIndexChanged" 
                                onpagesizechanged="dgNotification_PageSizeChanged" 
                                onsortcommand="dgNotification_SortCommand" Skin="Sitefinity" 
                                onitemcommand="dgNotification_ItemCommand">
                                <mastertableview><rowindicatorcolumn>
                                    <HeaderStyle 
                                Width="20px" /></rowindicatorcolumn>
                                    <DetailTables>
                                        <telerik:GridTableView 
                                    runat="server" GroupsDefaultExpanded="False" 
                                    HierarchyDefaultExpanded="True" PageSize="5">
                                            <RowIndicatorColumn>
                                                <HeaderStyle 
                                        Width="20px" />
                                </RowIndicatorColumn>
                                <ExpandCollapseColumn>
                                    <HeaderStyle Width="20px" />
                                </ExpandCollapseColumn>
                                            <Columns>
                                                <telerik:GridBoundColumn DataField="SendDateTime" HeaderText="Date Time" 
                                                    UniqueName="SendDateTime">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="SenderName" HeaderText="From" 
                                                    UniqueName="SenderName">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Subject" HeaderText="Subject" 
                                                    UniqueName="Subject">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Body" HeaderText="Notification" 
                                                    UniqueName="Body">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Status" HeaderText="Status" 
                                                    UniqueName="Status" Display="False">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridButtonColumn CommandName="Seen" Text="Seen" UniqueName="Seen">
                                                    <ItemStyle Font-Bold="True" ForeColor="#0066FF" />
                                                </telerik:GridButtonColumn>
                                                <telerik:GridBoundColumn DataField="BusinessPartnersWiseNotificationId" 
                                                    Display="False" HeaderText="BusinessPartnersWiseNotificationId" 
                                                    UniqueName="BusinessPartnersWiseNotificationId">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                </telerik:GridTableView>
                            </DetailTables>
                            <ExpandCollapseColumn Visible="True">
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="NotificationTypeId" Display="False" 
                                    HeaderText="NotificationTypeId" UniqueName="NotificationTypeId">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="NotificationType" 
                                    HeaderText="Notification Types" UniqueName="NotificationType">
                                    <ItemStyle Font-Bold="True" Width="250px" />
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Unread" Display="False" HeaderText="Unread" 
                                    UniqueName="Unread">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Total" Display="False" HeaderText="Total" 
                                    UniqueName="Total">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="ReadUnread" HeaderText="Read/Unread" 
                                    UniqueName="ReadUnread">
                                </telerik:GridBoundColumn>
                            </Columns>
                            </mastertableview>
                            </telerik:RadGrid>
            
                </td>
            </tr>
        </table>
    </div>


</asp:Content>
