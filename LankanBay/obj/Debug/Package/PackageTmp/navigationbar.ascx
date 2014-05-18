<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="navigationbar.ascx.cs" Inherits="LankanBay.navigationbar" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href="../css/dcmegamenu.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../js/jquery.min.js"></script>
<script type='text/javascript' src='../js/jquery.hoverIntent.minified.js'></script>
<script type='text/javascript' src='../js/jquery.dcmegamenu.1.3.3.js'></script>
<script type="text/javascript">
    $(document).ready(function ($) {
    
        $('#mega-menu-9').dcMegaMenu({
            rowItems: '3',
            speed: 'fast',
            effect: 'fade'
        });
    });
</script>

<link href="../css/skins/white.css" rel="stylesheet" type="text/css" />
</head>
<body>

  <%@ Import Namespace="System.Data" %>
    <%@ Import Namespace="SERVICE" %>
    <%@ Import Namespace="DOMAIN" %>

<div class="wrap" style="text-align:left;">
<div class="demo-container">
  <div class="white">  
  <ul id="mega-menu-9" class="mega-menu" style="text-align:left;">

  <%
      
      CategoryDetailsService categoryDetailsService = new CategoryDetailsService();

      SubCategoryDetailsService subCategoryDetailsService = new SubCategoryDetailsService();
      SubCategoryDetails subCategoryDetails = new SubCategoryDetails();

      ItemDetails itemDetails = new ItemDetails();
      ItemDetailsService itemDetailsService = new ItemDetailsService();
       
      DataTable dtMainCategories = new DataTable();
      DataTable dtSubCategoryDetails = new DataTable();
      DataTable dtItemDetails = new DataTable();

      dtMainCategories = categoryDetailsService.SelectCategoriesFornavigationBar();
      
      Response.Write("<li><a href='home.aspx' title='Click here to go to home page'> LankanBay.Com </a></li>");

      for (int i = 0; i < dtMainCategories.Rows.Count; i++)
      {
          subCategoryDetails.CategoryId = Convert.ToInt32(dtMainCategories.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId].ToString());
          dtSubCategoryDetails = subCategoryDetailsService.SelectSubCategoriesRelatedToMainCategory(subCategoryDetails);         
          Response.Write("<li><a href='" + CommonParameterNames.PageURLs.CategoryPageWithParameters + dtMainCategories.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.CategoryId].ToString() + "' title='" + dtMainCategories.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.Description].ToString() + "'>" + dtMainCategories.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.CatrgoryDetails.Name].ToString() + "</a>");  
            if (dtSubCategoryDetails.Rows.Count > 0)
            {     
		        Response.Write("<ul>");          
                for (int j = 0; j < dtSubCategoryDetails.Rows.Count; j++)
                {
                    itemDetails.SubCategoryId = Convert.ToInt32(dtSubCategoryDetails.Rows[j][CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId].ToString());
                    dtItemDetails = itemDetailsService.SelectItemDetailsForNavigationBar(itemDetails);

                    Response.Write("<li><a href='" + CommonParameterNames.PageURLs.SubCategoryWithParameter + dtSubCategoryDetails.Rows[j][CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.SubCategoryId].ToString() + "' title='" + dtSubCategoryDetails.Rows[j][CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.Description].ToString() + "'>" + dtSubCategoryDetails.Rows[j][CommonParameterNames.CommonTableColumnName.Inventory.SubCategoryDetails.Name].ToString() + "</a>");
                    if (dtItemDetails.Rows.Count > 0)
                    {
                        Response.Write("<ul>");
                        for (int k = 0; k < dtItemDetails.Rows.Count; k++)
                        {
                            Response.Write("<li><a href='" + CommonParameterNames.PageURLs.ViewItemPageWithParameters + dtItemDetails.Rows[k][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString() + "' title='" + dtItemDetails.Rows[k][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemDescription].ToString() + "'>" + dtItemDetails.Rows[k][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemName].ToString() + "</a>");
                        }                                           
                        Response.Write("</ul>");
                    }
                    
			        Response.Write("</li>");             
                }            
                Response.Write("</ul>");       
            }     
            Response.Write("</li>");
      } 
   %>
</ul>
</div>
</div>
</body>
</html>
