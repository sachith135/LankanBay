<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="breadcrumb.ascx.cs" Inherits="LankanBay.breadcrumb" %>
<%@ Import Namespace="System.Data" %>
        <%@ Import Namespace="SERVICE" %>
        <%@ Import Namespace="DOMAIN" %>

        <%
          
            ItemDetails itemDetails = new ItemDetails();
            ItemDetailsService itemDetailsService = new ItemDetailsService();

            ItemImageDetails itemImageDetails = new ItemImageDetails();
            ItemImageDetailsService itemImageDetailsService = new ItemImageDetailsService();

            PaymetOptionDetailsService paymetOptionDetailsService = new PaymetOptionDetailsService();

            DataTable dtItemDetails = new DataTable();
            DataTable dtItemImageDetails = new DataTable();
            DataTable dtPaymentOptionDetails = new DataTable();

            dtPaymentOptionDetails = paymetOptionDetailsService.SelectPaymentOptions();          
            
            int itemId = 0;
            
            if (Request.QueryString[CommonParameterNames.URLParameters.ItemId] != null)
            {
                itemId = Convert.ToInt32(Request.QueryString[CommonParameterNames.URLParameters.ItemId].ToString());
                
                itemDetails.ItemId = itemId;
                dtItemDetails = itemDetailsService.SelectThisItemDetailsForMainPage(itemDetails);

                if (dtItemDetails.Rows.Count <=0)
                {
                    Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                } 
                
            }
            else
            {
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }           
                                     
        %>

    <table width="100%" cellpadding="5">    
    <tr>
        <td style="text-align:left; padding-left:15px; padding-bottom:-10px; font-size:12px;" >

        <%Response.Write("<a href='"+CommonParameterNames.PageURLs.HomePage+"' class='itemCategory' style='text-decoration:underline;padding:0px;'>"); %> 
        LankanBay.Com 
        <%Response.Write("</a>"); %>
             
        &nbsp;<span class="itemCategory"> >></span> &nbsp;

        <%Response.Write("<a href='" + CommonParameterNames.PageURLs.CategoryPageWithParameters + dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.CategoryId].ToString() + "' class='itemCategory' style='text-decoration:underline;padding:0px;'>"); %>
        <%Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.Category].ToString()); %>
        <%Response.Write("</a>"); %>

        &nbsp;<span class="itemCategory"> >> </span>&nbsp;

        <%Response.Write("<a href='" + CommonParameterNames.PageURLs.SubCategoryWithParameter + dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.SubCategoryId].ToString() + "' class='itemCategory' style='text-decoration:underline;padding:0px;'>");%>
        <%Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.SubCategory].ToString()); %>
        <%Response.Write("</a>");%>

        &nbsp;<span class="itemCategory"> >> </span>&nbsp;

        <%Response.Write("<a href='#' class='itemCategory' style='text-decoration:underline;padding:0px;'>");%>
        <%Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemName].ToString()); %>
        <%Response.Write("</a>");%>

        </td>
    </tr>
    </table>
