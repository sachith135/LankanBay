<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true" CodeBehind="sup_additemimages.aspx.cs" Inherits="LankanBay.admin.sup_additemimages" %>
<%@ Register assembly="Telerik.Web.UI" namespace="Telerik.Web.UI" tagprefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 100%;
        }
        .style11
        {
            width: 119px;
        }
        .style12
        {
            width: 31px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="SERVICE" %>
<%@ Import Namespace="DOMAIN" %>

 <div class="pageContainer">
        <table class="style10">
            <tr>
                <td class="style11" colspan="10">
                    <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" Text="Add / Edit Item Images"></asp:Label>
                    <hr class="separator" />
                    <br />
                </td>
            </tr>
        <tr>
            <td class="style11">
                Image Name</td>
            <td class="style12">
                :</td>
            <td>
                <telerik:RadComboBox ID="cmbItemName" Runat="server" Width="354px" 
                    AppendDataBoundItems="True" AutoPostBack="True" 
                    onselectedindexchanged="cmbItemName_SelectedIndexChanged" 
                    xmlns:telerik="telerik.web.ui">
                        </telerik:RadComboBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                Upload item image by image and after that set the main image.</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                Description</td>
            <td class="style12">
                :</td>
            <td colspan="3" rowspan="3">
                <telerik:RadTextBox ID="txtDescription" Runat="server" Rows="3" 
                    TextMode="MultiLine" Width="350px" ReadOnly="True" 
                    xmlns:telerik="telerik.web.ui">
                        </telerik:RadTextBox>
            </td>
            <td rowspan="3">
            <div class ="itemImageContainer" style="padding:10px;">
 <asp:FileUpload ID="File1" runat="server" />
 <br /> <br />
        <asp:Button ID="btnUpload" runat="server" onclick="btnUpload_Click" 
            Text="Upload" Width="218px" CssClass="button" />

            </div>

            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style11">
                &nbsp;
                </td>
            <td class="style12">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>

        <td colspan="8">      
        
            <telerik:RadGrid ID="dgItemImage" runat="server" AutoGenerateColumns="False" 
                GridLines="None">
<MasterTableView>
<RowIndicatorColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</RowIndicatorColumn>

<ExpandCollapseColumn>
<HeaderStyle Width="20px"></HeaderStyle>
</ExpandCollapseColumn>
    <Columns>
        <telerik:GridTemplateColumn HeaderText="Is Main" UniqueName="tempIsMain">
            <ItemTemplate>
                <asp:CheckBox ID="chkIsMain" runat="server" />
            </ItemTemplate>
            <ItemStyle Width="50px" />
        </telerik:GridTemplateColumn>
        <telerik:GridTemplateColumn HeaderText="Image" UniqueName="tempItemImage">
            <ItemTemplate>
                <asp:Image ID="image" runat="server" Height="35px" Width="50px" />
            </ItemTemplate>
        </telerik:GridTemplateColumn>
        <telerik:GridBoundColumn DataField="ItemWiseImageId" Display="False" 
            HeaderText="ItemWiseImageId" UniqueName="ItemWiseImageId">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ItemId" Display="False" HeaderText="ItemId" 
            UniqueName="ItemId">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Name" HeaderText="Name" UniqueName="Name">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="Description" HeaderText="Description" 
            UniqueName="Description">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="IsMainImage" Display="False" 
            HeaderText="IsMainImage" UniqueName="IsMainImage">
        </telerik:GridBoundColumn>
        <telerik:GridBoundColumn DataField="ImagePath" Display="False" 
            HeaderText="ImagePath" UniqueName="ImagePath">
        </telerik:GridBoundColumn>
        <telerik:GridCheckBoxColumn DataField="IsMainImage" HeaderText="Cur. Main" 
            UniqueName="IsMainImage1">
            <ItemStyle HorizontalAlign="Right" Width="80px" />
        </telerik:GridCheckBoxColumn>
    </Columns>
</MasterTableView>
            </telerik:RadGrid>
        
        </td>

        </tr>
    </table>
     </div>   
</asp:Content>
