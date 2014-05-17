<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/sitemaster.Master"
    AutoEventWireup="true" CodeBehind="bsp_customer_profile.aspx.cs" Inherits="LankanBay.bsp_customer_profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            background: rgb(245,246,246);
/* Old browsers */background: -moz-linear-gradient(top, rgba(245,246,246,1) 0%, rgba(219,220,226,1) 21%, rgba(184,186,198,1) 49%, rgba(221,223,227,1) 80%, rgba(245,246,246,1) 100%); /* FF3.6+ */;
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(245,246,246,1)), color-stop(21%,rgba(219,220,226,1)), color-stop(49%,rgba(184,186,198,1)), color-stop(80%,rgba(221,223,227,1)), color-stop(100%,rgba(245,246,246,1))); /* Chrome,Safari4+ */;
            background: -webkit-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Chrome10+,Safari5.1+ */;
            background: -o-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Opera 11.10+ */;
            background: -ms-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* IE10+ */;
            background: rgb(245,246,246); /* W3C */
            filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f5f6f6', endColorstr='#f5f6f6',GradientType=0 );
            height: 100px;
            width: 798px;
        }
                
        table.myTable td, table.myTable th
        {
            border: 1px solid #CCC;
            font-size: 11px;
        }
        
        .pageHights
        {
            height:250px;
            width:100%;
        }
        
        td
        {
            vertical-align:top;
        }
        
        .style11
        {
            width: 100%;
        }
        
        .style13
        {
            background: rgb(245,246,246);
/* Old browsers */background: -moz-linear-gradient(top, rgba(245,246,246,1) 0%, rgba(219,220,226,1) 21%, rgba(184,186,198,1) 49%, rgba(221,223,227,1) 80%, rgba(245,246,246,1) 100%); /* FF3.6+ */;
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(245,246,246,1)), color-stop(21%,rgba(219,220,226,1)), color-stop(49%,rgba(184,186,198,1)), color-stop(80%,rgba(221,223,227,1)), color-stop(100%,rgba(245,246,246,1))); /* Chrome,Safari4+ */;
            background: -webkit-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Chrome10+,Safari5.1+ */;
            background: -o-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Opera 11.10+ */;
            background: -ms-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* IE10+ */;
            background: rgb(245,246,246);
/* W3C */filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f5f6f6', endColorstr='#f5f6f6',GradientType=0 );
            height: 28px;
            width: 143px;
        }
        .style14
        {
            width: 20px;
            text-align: left;
            height: 28px;
        }
        .style15
        {
            width: 294px;
            text-align: left;
            height: 28px;
        }
        .style18
        {
            width: 20px;
            text-align: left;
            height: 27px;
        }
        .style19
        {
            width: 294px;
            text-align: left;
            height: 27px;
        }
        .style20
        {
            height: 27px;
        }
        
        .style25
        {
            width: 294px;
            text-align: left;
        }
        .style26
        {
            width: 294px;
        }
        .style27
        {
            width: 143px;
        }
        .style28
        {
            height: 28px;
            text-align: left;
            width: 44px;
        }
        .style29
        {
            height: 27px;
            text-align: left;
            width: 44px;
        }
        .style30
        {
            text-align: left;
            width: 44px;
        }
        .style31
        {
            width: 44px;
        }
        
        .style32
        {
            height: 12px;
            text-align: left;
        }
        .style33
        {
            background: rgb(245,246,246);
/* Old browsers */background: -moz-linear-gradient(top, rgba(245,246,246,1) 0%, rgba(219,220,226,1) 21%, rgba(184,186,198,1) 49%, rgba(221,223,227,1) 80%, rgba(245,246,246,1) 100%); /* FF3.6+ */;
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(245,246,246,1)), color-stop(21%,rgba(219,220,226,1)), color-stop(49%,rgba(184,186,198,1)), color-stop(80%,rgba(221,223,227,1)), color-stop(100%,rgba(245,246,246,1))); /* Chrome,Safari4+ */;
            background: -webkit-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Chrome10+,Safari5.1+ */;
            background: -o-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Opera 11.10+ */;
            background: -ms-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* IE10+ */;
            background: rgb(245,246,246);
/* W3C */filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f5f6f6', endColorstr='#f5f6f6',GradientType=0 );
            height: 12px;
            width: 173px;
        }
        .style34
        {
            width: 20px;
            text-align: left;
            height: 12px;
        }
        .style35
        {
            width: 294px;
            text-align: left;
            height: 12px;
        }
        .style36
        {
            height: 12px;
            text-align: left;
            width: 44px;
        }
        .style37
        {
            height: 12px;
        }
        .style38
        {
            background: rgb(245,246,246);
/* Old browsers */background: -moz-linear-gradient(top, rgba(245,246,246,1) 0%, rgba(219,220,226,1) 21%, rgba(184,186,198,1) 49%, rgba(221,223,227,1) 80%, rgba(245,246,246,1) 100%); /* FF3.6+ */;
            background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(245,246,246,1)), color-stop(21%,rgba(219,220,226,1)), color-stop(49%,rgba(184,186,198,1)), color-stop(80%,rgba(221,223,227,1)), color-stop(100%,rgba(245,246,246,1))); /* Chrome,Safari4+ */;
            background: -webkit-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Chrome10+,Safari5.1+ */;
            background: -o-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* Opera 11.10+ */;
            background: -ms-linear-gradient(top, rgba(245,246,246,1) 0%,rgba(219,220,226,1) 21%,rgba(184,186,198,1) 49%,rgba(221,223,227,1) 80%,rgba(245,246,246,1) 100%); /* IE10+ */;
            background: rgb(245,246,246);
/* W3C */filter: progid:DXImageTransform.Microsoft.gradient( startColorstr='#f5f6f6', endColorstr='#f5f6f6',GradientType=0 );
            height: 28px;
            width: 173px;
        }
        .style39
        {
            width: 173px;
        }
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageContainer">
        <table style="width: 100%; margin-bottom:8px" cellpadding="0" >
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" Text="Customer Profile ...."></asp:Label>
                    <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style10" style="text-align: left; padding: 5px; vertical-align: middle;">
                    <asp:Label ID="lblSellersName" runat="server" CssClass="bspProfileName"></asp:Label>
                    <br />
                    <asp:Label ID="lblContactNo" runat="server" CssClass="bspProfileAddress"></asp:Label>
                    <br />
                    <asp:Label ID="lblEmail" runat="server" CssClass="bspProfileAddress"></asp:Label>
                    <br />
                    <asp:Label ID="lblSellersAddress" runat="server" CssClass="bspProfileAddress"></asp:Label>
                </td>
                <td class="bspProfileHeader" style="height: 100px; text-align: right; padding: 5px;">
                    <asp:Image ID="imgBSPImage" runat="server" Height="100px" Width="100px" class="itemShowContainerDiv" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <hr class="separator" />
                </td>
            </tr>
        </table>       
        <telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1"
            SelectedIndex="0">
            <Tabs>
                <telerik:RadTab runat="server" Text="Recently Viewed Items" Selected="True">
                </telerik:RadTab>
                <telerik:RadTab runat="server" Text="Your Purchase History">
                </telerik:RadTab>
                <telerik:RadTab runat="server" Text="Notifications">
                </telerik:RadTab>

                <telerik:RadTab runat="server" Text="Your Profile">
                </telerik:RadTab>

            </Tabs>
        </telerik:RadTabStrip>
        <hr class="separator" />
        <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0" 
            Width="100%">
            <telerik:RadPageView ID="RecentlyViewed" runat="server">

            
                <table class="style11">
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" CssClass="fromHeaderText" 
                                Text="Recently Viewed Items ..."></asp:Label>
                            <hr class="separator" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadGrid ID="dgViewedItems" runat="server" AllowPaging="True" 
                                AutoGenerateColumns="False" GridLines="None" 
                                OnNeedDataSource="dgViewedItems_NeedDataSource" 
                                OnPageIndexChanged="dgViewedItems_PageIndexChanged" 
                                OnPageSizeChanged="dgViewedItems_PageSizeChanged" 
                                OnSortCommand="dgViewedItems_SortCommand" Skin="Sitefinity" 
                                onitemcommand="dgViewedItems_ItemCommand"><mastertableview><Columns><telerik:GridHyperLinkColumn 
                                    DataNavigateUrlFields="NavigationURL" NavigateUrl="NavigationURL" 
                                    Target="NavigationURL" Text="View" UniqueName="NavigationURL"><ItemStyle 
                                    Font-Bold="True" ForeColor="Red" /></telerik:GridHyperLinkColumn><telerik:GridImageColumn 
                                    DataImageUrlFields="ImagePath" HeaderText="Image" ImageHeight="30px" 
                                    ImageWidth="50px" UniqueName="ImagePath"><ItemStyle CssClass="GridImage" /></telerik:GridImageColumn><telerik:GridBoundColumn 
                                    DataField="ItemWiseViewId" Display="False" HeaderText="ItemWiseViewId" 
                                    UniqueName="ItemWiseViewId"></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                    DataField="ItemId" Display="False" HeaderText="ItemId" UniqueName="ItemId"></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                    DataField="Name" HeaderText="Item" UniqueName="Name"></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                    DataField="Description" HeaderText="Description" UniqueName="Description"></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                    DataField="UnitPrice" HeaderText="Price" UniqueName="UnitPrice"></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                    DataField="DeleveryOption" HeaderText="Delevery" UniqueName="DeleveryOption"></telerik:GridBoundColumn><telerik:GridBoundColumn 
                                    DataField="TotalViews" HeaderText="Views" UniqueName="TotalViews"></telerik:GridBoundColumn><telerik:GridDateTimeColumn 
                                    DataField="ViewedDateTime" HeaderText="Last Viewed" UniqueName="ViewedDateTime"><ItemStyle 
                                    Width="130px" /></telerik:GridDateTimeColumn>
                            </Columns>
                            </mastertableview>
                            </telerik:RadGrid>
                        </td>
                    </tr>
                </table>

            
            </telerik:RadPageView>

            <telerik:RadPageView ID="YourOrderHistory" runat="server">              
             
                <table class="style11">
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" CssClass="fromHeaderText" 
                                Text="Your Order History ..."></asp:Label>
                            <hr class="separator" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadGrid ID="dgOrderHistory" runat="server" AllowPaging="True" AllowSorting="True" 
                                AutoGenerateColumns="False" GridLines="None" 
                                ondetailtabledatabind="dgOrderHistory_DetailTableDataBind" 
                                onneeddatasource="dgOrderHistory_NeedDataSource" 
                                onpageindexchanged="dgOrderHistory_PageIndexChanged" 
                                onpagesizechanged="dgOrderHistory_PageSizeChanged" 
                                onselectedindexchanged="dgOrderHistory_SelectedIndexChanged" 
                                onsortcommand="dgOrderHistory_SortCommand" Skin="Sitefinity" 
                                onitemcommand="dgOrderHistory_ItemCommand"><mastertableview><rowindicatorcolumn><HeaderStyle 
                                Width="20px" /></rowindicatorcolumn><DetailTables>
                                        <telerik:GridTableView 
                                    runat="server" GroupsDefaultExpanded="False" 
                                    HierarchyDefaultExpanded="True" PageSize="5"><RowIndicatorColumn><HeaderStyle 
                                        Width="20px" />
                                </RowIndicatorColumn>
                                <ExpandCollapseColumn>
                                    <HeaderStyle Width="20px" />
                                </ExpandCollapseColumn>
                                            <Columns>
                                                <telerik:GridHyperLinkColumn DataNavigateUrlFields="NavigationURL" 
                                                    NavigateUrl="NavigationURL" Target="NavigationURL" Text="View Item" 
                                                    UniqueName="NavigationURL">
                                                </telerik:GridHyperLinkColumn>
                                                <telerik:GridImageColumn DataImageUrlFields="ImagePath" HeaderText="Image" 
                                                    ImageHeight="30px" ImageUrl="ImagePath" ImageWidth="50px" 
                                                    UniqueName="ImagePath">
                                                </telerik:GridImageColumn>
                                                <telerik:GridBoundColumn DataField="Name" HeaderText="Item Name" 
                                                    UniqueName="Name">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Description" HeaderText="Description" 
                                                    UniqueName="Description">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="UnitPrice" HeaderText="UnitPrice" 
                                                    UniqueName="UnitPrice">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Qty" HeaderText="Qty" UniqueName="Qty">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="DeliveryChargers" HeaderText="Delivery" 
                                                    UniqueName="DeliveryChargers">
                                                </telerik:GridBoundColumn>
                                                <telerik:GridBoundColumn DataField="Amount" HeaderText="Amount" 
                                                    UniqueName="Amount">
                                                </telerik:GridBoundColumn>
                                            </Columns>
                                </telerik:GridTableView>
                            </DetailTables>
                            <ExpandCollapseColumn Visible="True">
                            </ExpandCollapseColumn>
                            <Columns>
                                <telerik:GridBoundColumn DataField="OrderStatus" Display="False" 
                                    HeaderText="OrderStatus" UniqueName="OrderStatus">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="OrderId" FilterControlWidth="80%" 
                                    HeaderText="OrderId" UniqueName="OrderId" Display="False" EmptyDataText="">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="OrderNo" FilterControlWidth="80%" 
                                    HeaderText="Order #" UniqueName="OrderNo">
                                    <ItemStyle Font-Bold="True" ForeColor="#CC0000" />
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="Status" FilterControlWidth="80%" 
                                    HeaderText="Status" UniqueName="Status">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="PaymentOption" FilterControlWidth="80%" 
                                    HeaderText="Pay On" UniqueName="PaymentOption">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="OrderedDateTime" Display="False" 
                                    FilterControlWidth="80%" HeaderText="Ordered On" UniqueName="OrderedDateTime1">
                                </telerik:GridBoundColumn>
                                <telerik:GridDateTimeColumn DataField="OrderedDateTime" 
                                    FilterControlWidth="60%" HeaderText="Ordered On" UniqueName="OrderedDateTime">
                                </telerik:GridDateTimeColumn>
                                <telerik:GridBoundColumn DataField="OrderCancelationDate" Display="False" 
                                    FilterControlWidth="80%" HeaderText="Valid Until" 
                                    UniqueName="OrderCancelationDate1">
                                </telerik:GridBoundColumn>
                                <telerik:GridDateTimeColumn DataField="OrderCancelationDate" 
                                    FilterControlWidth="60%" HeaderText="Valid Until" 
                                    UniqueName="OrderCancelationDate">
                                </telerik:GridDateTimeColumn>
                                <telerik:GridBoundColumn DataField="StatusUpdatedDateTime" Display="False" 
                                    FilterControlWidth="80%" HeaderText="Status Updated On" 
                                    UniqueName="StatusUpdatedDateTime1">
                                </telerik:GridBoundColumn>
                                <telerik:GridDateTimeColumn DataField="StatusUpdatedDateTime" 
                                    FilterControlWidth="60%" HeaderText="Status Update On" 
                                    UniqueName="StatusUpdatedDateTime">
                                </telerik:GridDateTimeColumn>
                                <telerik:GridBoundColumn DataField="TotalAmount" HeaderText="Amt" 
                                    UniqueName="TotalAmount">
                                </telerik:GridBoundColumn>
                                <telerik:GridHyperLinkColumn DataNavigateUrlFields="PayNow" 
                                    FilterControlWidth="0px" NavigateUrl="PayNow" ShowFilterIcon="False" 
                                    Target="PayNow" Text="PayNow" UniqueName="PayNow">
                                    <ItemStyle Font-Bold="True" ForeColor="Red" />
                                </telerik:GridHyperLinkColumn>
                                <telerik:GridButtonColumn ButtonType="ImageButton" CommandName="Delete" 
                                    ConfirmDialogHeight="120px" ConfirmDialogType="RadWindow" 
                                    ConfirmDialogWidth="300px" 
                                    ConfirmText="Are you sure you want to delete this order ? This action cannot be undo." 
                                    ConfirmTitle="Confirmation .." ImageUrl="images/delete.ico" Text="Delete" 
                                    UniqueName="Delete" AutoPostBackOnFilter="True">
                                </telerik:GridButtonColumn>
                            </Columns>
                            </mastertableview>
                            </telerik:RadGrid>
                        </td>
                    </tr>
                </table>              
             
            </telerik:RadPageView>

            <telerik:RadPageView ID="Nortifications" runat="server">              
             
                <table class="style11">
                    <tr>
                        <td>
                            <asp:Label runat="server" CssClass="fromHeaderText" 
                                Text="Notification ..."></asp:Label>
                            <hr class="separator" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadGrid ID="dgNotification" runat="server" AllowPaging="True" AllowSorting="True" 
                                AutoGenerateColumns="False" GridLines="None" 
                                ondetailtabledatabind="dgNotification_DetailTableDataBind" 
                                onneeddatasource="dgNotification_NeedDataSource" 
                                onpageindexchanged="dgNotification_PageIndexChanged" 
                                onpagesizechanged="dgNotification_PageSizeChanged" 
                                onsortcommand="dgNotification_SortCommand" Skin="Sitefinity" 
                                onitemcommand="dgNotification_ItemCommand"><mastertableview><rowindicatorcolumn><HeaderStyle 
                                Width="20px" /></rowindicatorcolumn><DetailTables>
                                        <telerik:GridTableView 
                                    runat="server" GroupsDefaultExpanded="False" 
                                    HierarchyDefaultExpanded="True" PageSize="5"><RowIndicatorColumn><HeaderStyle 
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
             
            </telerik:RadPageView>

            <telerik:RadPageView ID="YourProfile" runat="server" Width="100%">
            <table>
            <tr>
                <td colspan="10">
                    <asp:Label ID="Label5" runat="server" CssClass="fromHeaderText" 
                        Text="Your Profile ..."></asp:Label>
                <br />
                        <hr class="separator" />
                </td>
            </tr>
            <tr>
                <td class="style32">
                 </td>
                <td class="style33">
                    </td>
                <td class="style34">
                    </td>
                <td class="style35">
                </td>
                <td class="style36">
                    </td>
                <td class="style32">
                </td>
                <td colspan="3" class="style37">
                    </td>
                <td class="style37">
                    </td>
            </tr>
                <tr>
                    <td class="style6">
                    </td>
                    <td class="style38">
                        User Type</td>
                    <td class="style14">
                        :</td>
                    <td class="style15">
                        <telerik:RadComboBox ID="cmbUserType" Runat="server" AutoPostBack="True" 
                            onselectedindexchanged="cmbUserType_SelectedIndexChanged" Width="304px">
                            <Items>
                                <telerik:RadComboBoxItem runat="server" Text="Customer" Value="C" />
                                <telerik:RadComboBoxItem runat="server" Text="Seller" Value="S" />
                                <telerik:RadComboBoxItem runat="server" Text="Administratoin" Value="A" />
                            </Items>
                        </telerik:RadComboBox>
                    </td>
                    <td class="style28">
                        &nbsp;</td>
                    <td class="style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="cmbUserType" ErrorMessage="*" Font-Bold="True" 
                            ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                    </td>
                    <td class="style8" colspan="3">
                        Address Details (Can change later)</td>
                    <td class="style8">
                    </td>
                </tr>
            <tr>
                <td >
                    </td>
                <td class="style39" >
                    <asp:Label ID="lblFirstName" runat="server" Text="First Name"></asp:Label>
                </td>
                <td class="style18">
                    :</td>
                <td class="style19">
                    <telerik:RadTextBox ID="txtFname" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style29">
                    &nbsp;</td>
                <td class="style2">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="txtFname" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style2">
                    Category</td>
                <td class="style20">
                    :</td>
                <td class="style20">
                    <telerik:RadComboBox ID="cmbAddressCategory" Runat="server" AutoPostBack="True" 
                        onselectedindexchanged="cmbUserType_SelectedIndexChanged" Width="304px">
                    </telerik:RadComboBox>
                </td>
                <td class="style20">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                        ControlToValidate="cmbAddressCategory" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style39" >
                    <asp:Label ID="lblLastName" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td class="style4">
                    <asp:Label ID="lblLastNameColon" runat="server" Text=":"></asp:Label>
                </td>
                <td class="style25">
                    <telerik:RadTextBox ID="txtLname" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style30">
                    &nbsp;</td>
                <td class="style6">
                    &nbsp;</td>
                <td class="style7">
                    Add L 01</td>
                <td class="style8">
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressLine01" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
                        ControlToValidate="txtAddressLine01" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style39" >
                    Gender</td>
                <td >
                    :</td>
                <td class="style26" >
                    <asp:RadioButton ID="radMale" runat="server" GroupName="Gender" Text="Male" 
                        Checked="True" />
&nbsp;
                    <asp:RadioButton ID="radFemale" runat="server" GroupName="Gender" 
                        Text="Female" />
&nbsp;
                    <asp:RadioButton ID="radOther" runat="server" GroupName="Gender" Text="Other" />
                </td>
                <td class="style31">
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td >
                    Add L 02</td>
                <td >
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressLine02" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style39" >
                    Primary Email</td>
                <td >
                    :</td>
                <td class="style26" >
                    <telerik:RadTextBox ID="txtPrimaryEmail" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style31">
                    &nbsp;</td>
                <td >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="txtPrimaryEmail" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td >
                    City</td>
                <td >
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressCity" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                        ControlToValidate="txtAddressCity" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style39" >
                    Primary Contact No</td>
                <td >
                    :</td>
                <td class="style26" >
                    <telerik:RadTextBox ID="txtPrimaryContactNo" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style31">
                    &nbsp;</td>
                <td >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                        ControlToValidate="txtPrimaryContactNo" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td >
                    State</td>
                <td >
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtAddressState" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                        ControlToValidate="txtAddressState" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style39" >
                    Fax</td>
                <td >
                    :</td>
                <td class="style26" >
                    <telerik:RadTextBox ID="txtFax" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style31">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td >
                    Zip</td>
                <td >
                    :</td>
                <td>
                    <telerik:RadNumericTextBox ID="txtAddressZipCode" Runat="server" Width="300px">
                    </telerik:RadNumericTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                        ControlToValidate="txtAddressZipCode" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style39" >
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td class="style26" >
                    <asp:CheckBox ID="chkIsActive" runat="server" Text="Active" Checked="True" />
                </td>
                <td class="style31">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td >
                    &nbsp;</td>
                <td ">
                    &nbsp;</td>
                <td>
                    <asp:CheckBox ID="IsDefaltShippingAddess" runat="server" 
                        Text="Default Shipping / Mailing Addess" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td  colspan="8">
                <hr class="separator" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style39"  >
                    Username</td>
                <td >
                    :</td>
                <td >
                    <telerik:RadTextBox ID="txtUsername" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style31">
                    &nbsp;</td>
                <td >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" 
                        ControlToValidate="txtUsername" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td colspan="4" >
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="txtConfirmPassword" ControlToValidate="txtPassword" 
                        ErrorMessage="Password and Confirm Password Not Match." Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td >
                    &nbsp;</td>
                <td class="style39" >
                    Password</td>
                <td >
                    :</td>
                <td  >
                    <telerik:RadTextBox ID="txtPassword" Runat="server" TextMode="Password" 
                        Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style31">
                    &nbsp;</td>
                <td >
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" 
                        ControlToValidate="txtPassword" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td >
                    Confirm Password</td>
                <td >
                    :</td>
                <td>
                    <telerik:RadTextBox ID="txtConfirmPassword" Runat="server" TextMode="Password" 
                        Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" 
                        ControlToValidate="txtConfirmPassword" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style6">
                    </td>
                <td class="style38">
                    Sequrity Question</td>
                <td class="style14">
                    :</td>
                <td class="style15">
                    <telerik:RadComboBox ID="cmbSequrityQuestion" Runat="server" Width="304px">
                    </telerik:RadComboBox>
                </td>
                <td class="style28">
                    &nbsp;</td>
                <td class="style6">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" 
                        ControlToValidate="cmbSequrityQuestion" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
                <td class="style6">
                    Answer</td>
                <td class="style8">
                    :</td>
                <td class="style8">
                    <telerik:RadTextBox ID="txtAnswer" Runat="server" Width="300px">
                    </telerik:RadTextBox>
                </td>
                <td class="style8">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" 
                        ControlToValidate="txtAnswer" ErrorMessage="*" Font-Bold="True" 
                        ForeColor="#FF3300" ValidationGroup="i"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style9" colspan="8">
                    An email 
                    will send to you. Please Check your mail and verify the account after 
                    registration. </td>
                <td class="style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3" colspan="8" >
                    <asp:Button ID="btnRegister" runat="server" Height="30px" Text="Register" 
                        Width="264px" CssClass="button" Font-Bold="True" 
                        onclick="btnRegister_Click" ValidationGroup="i" />
                        &nbsp;  &nbsp;  &nbsp; 
                    <asp:Button ID="btnClear" runat="server" Height="30px" Text="Clear" 
                        Width="150px" CssClass="button" onclick="btnClear_Click" />
                        &nbsp;  &nbsp;  &nbsp; 
                         </td>
                <td class="style3" >
                    &nbsp;</td>
            </tr>
        </table>

            </telerik:RadPageView>

        </telerik:RadMultiPage>
    </div>
</asp:Content>
