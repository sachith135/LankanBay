<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/admin.Master" AutoEventWireup="true" CodeBehind="reprot_viwer.aspx.cs" Inherits="LankanBay.admin.reprot_viwer" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style10
        {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="pageContainer">
    <table class="style10">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" 
                    Text="Report Viewer" ToolTip="Report Viewer"></asp:Label>
                <hr class="separator" />
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="text-align:center">
          
                <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
                    AutoDataBind="true" HasCrystalLogo="False" HasDrillUpButton="False" 
                    Width="100%" BestFitPage="False" DisplayStatusbar="False" 
                    EnableDrillDown="False" EnableTheming="True" />
              
            </td>
        </tr>
    </table>
    </div>
</asp:Content>
