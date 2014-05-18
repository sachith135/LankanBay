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
      
      AdministrationMenuService administrationMenuService = new SERVICE.AdministrationMenuService();
      AdministrationMenuDetails administrationMenuDetails = new DOMAIN.AdministrationMenuDetails();

      
       
      DataTable dtMainCategories = new DataTable();
      DataTable dtSubCategoryDetails = new DataTable();
      DataTable dtItemDetails = new DataTable();

      dtMainCategories = administrationMenuService.SelectCategories();
      Response.Write("<li><a href='../home.aspx' title='Click here to go to home page'> LankanBay.Com </a></li>");
      for (int i = 0; i < dtMainCategories.Rows.Count; i++)
      {
          administrationMenuDetails.CategoryId = Convert.ToInt32(dtMainCategories.Rows[i]["CategoryId"].ToString());
          dtSubCategoryDetails = administrationMenuService.SelectSubCategories(administrationMenuDetails);

          Response.Write("<li><a href='" + dtMainCategories.Rows[i]["URL"].ToString() + "'>" + dtMainCategories.Rows[i]["Category"].ToString() + "</a>");  
            if (dtSubCategoryDetails.Rows.Count > 0)
            {     
		        Response.Write("<ul>");          
                for (int j = 0; j < dtSubCategoryDetails.Rows.Count; j++)
                {
                    administrationMenuDetails.SubCategoryId = Convert.ToInt32(dtSubCategoryDetails.Rows[j]["SubCategoryId"].ToString());
                    administrationMenuDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);

                    dtItemDetails = administrationMenuService.SelectMenuItem(administrationMenuDetails);
                    if (dtItemDetails.Rows.Count > 0)
                    {

                        Response.Write("<li><a href=''>" + dtSubCategoryDetails.Rows[j]["SubCategoryName"].ToString() + "</a>");
                        if (dtItemDetails.Rows.Count > 0)
                        {
                            Response.Write("<ul>");
                            for (int k = 0; k < dtItemDetails.Rows.Count; k++)
                            {
                                Response.Write("<li><a href='" + dtItemDetails.Rows[k]["PageURL"].ToString() + "'>" + dtItemDetails.Rows[k]["Name"].ToString() + "</a>");
                            }
                            Response.Write("</ul>");
                        }
                        else
                        {
                            Response.Write("<ul>");
                            for (int k = 0; k < dtItemDetails.Rows.Count; k++)
                            {
                                Response.Write("<li><a href=''>No items to display.</a>");
                            }
                            Response.Write("</ul>");
                        }
                    }
                    else
                    {
                        Response.Write("<li><a href=''>No items to display.</a>");
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
