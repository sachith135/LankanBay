<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/sitemaster.Master" AutoEventWireup="true" CodeBehind="subcategory.aspx.cs" Inherits="LankanBay.subcategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style9
        {
            width: 100%;
            height: 100%;
        }
        .style11
        {
            height: 4px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellpadding="0" cellspacing="0" class="style1"  style="margin-top:10px">
<tr>                            
<td style="padding-right:20px" height="250px">
<div class="itemShowContainerDiv">

<table width="100%">
<tr>
<td height="250px" style="text-align:center; vertical-align:middle;">
<img src="images/lankanbay_home_page_slider.jpg" />
</td>
</tr>
</table>

</div>
</td>
                            


<td width="250px">
<div class="itemShowContainerDiv"> 

 <table width="100%">
<tr>
<td height="250px" style="text-align:center; vertical-align:middle;">
<img src="images/lankanbay_home_page_slider_side.jpg" />
 </td>
</tr>
</table>
                         
</div>
</td>

</tr>
</table>

<hr class="separator" style="margin-top:20px; margin-bottom:-7px;"/>
<br />
<span style="font-weight:bold; font-size:14px; color:#1475BA; padding-top:-5px;">
ITEMS IN SUB CATEGORY YOU SELECTED ...

</span>       
<hr class="separator" style="margin-top:10px;"/>
                    

                    <table cellpadding="0" cellspacing="0" width="100%" style="text-align:left; margin-top:20px;">
                    <tr>
                    
                   <%@ Import Namespace="System.Data" %>
                   <%@ Import Namespace="SERVICE" %>
                   <%@ Import Namespace="DOMAIN" %>

                   <%
                       ItemDetails itemDetails = new DOMAIN.ItemDetails();
                       ItemDetailsService itemDetailsService = new ItemDetailsService();

                       ItemImageDetails itemImageDetails = new ItemImageDetails();
                       ItemImageDetailsService itemImageDetailsService = new ItemImageDetailsService();


                       ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails = new ItemPurchasingFeedbackDetails();
                       ItemPurchasingFeedbackDetailsService itemPurchasingFeedbackDetailsService = new ItemPurchasingFeedbackDetailsService();

                       DataTable dtItemPurchaseFeedbackDetails = new DataTable();
                       DataTable dtItemDetails = new DataTable();
                       DataTable dtItemImageDetails = new DataTable();
                       DataTable dtSingleItemDetails = new DataTable();

                       string itemRatings = "";

                                            int space = 0;

                       int itemRowIndex = 0;

                       if (!IsPostBack)
                       {
                           if (Request.QueryString.Count > 0 && Request.QueryString != null)
                           {
                               itemDetails.SubCategoryId = Convert.ToInt32(Request.QueryString[0].ToString());
                               dtItemDetails = itemDetailsService.SelectThisItemDetailsForMainPage(itemDetails);

                           }

                           else
                           {
                               Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                           }               
                       
                       
                                        
                   %>

                    <!-- Single Item -->
                     <% 
int itemCount = dtItemDetails.Rows.Count;
if (itemCount > 0)
{

    int itemCountForDecrement = dtItemDetails.Rows.Count;
    int itemRows = 0;

    if (itemCount % 4 == 0)
    {
        itemRows = (itemCount / 4);

    }
    else
    {
        itemRows = (itemCount / 4) + 1;
    }

    int itemCountInRow = itemCount;
    itemCountForDecrement = itemCount;

    for (int j = 0; j < itemRows; j++)
    {
        Response.Write("<tr>");
        space = 0;
        if (itemCountForDecrement >= 4)
        {
            itemCountInRow = 4;
        }
        else
        {
            itemCountInRow = itemCountForDecrement;
        }

        for (int i = itemRowIndex; i < itemRowIndex + itemCountInRow; i++)
        {
            Response.Write("<td  width='25%'>");

            if (itemCountForDecrement > 0)
            {
                itemImageDetails.ItemId = Convert.ToInt32(dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString());
                itemImageDetails.IsMainImage = true;
                dtItemImageDetails = itemImageDetailsService.SelectThisImageDetail(itemImageDetails);  
                        %>                    
                     <div class="itemShowContainerDiv" >                     
                        <table cellpadding="2" width="100%">
                            <tr>
                                <td>

                                    <table cellpadding="0" cellspacing="0" class="style9">
                                        <tr>
                                            <td  style="padding-left:5px; padding-top:5px; padding-right:5px; text-align:left; max-height:60px; min-height:60px;">
                                            
                                           <p style="max-height:70px; min-height:70px; vertical-align:top;">
                                                <%
Response.Write("<a href='" + CommonParameterNames.PageURLs.ViewItemPageWithParameters + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString() + "' class='itemName' title='Click Here To View More Details.'>");
Response.Write(dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemDescription].ToString());
Response.Write("</a>");
                                               %>                                             
                                             
                                           </p>

                                            </td>
                                            <td align="right">


                                                
                                                <table cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td>
                                                        <%
itemPurchasingFeedbackDetails.ReceiversBspId = Convert.ToInt32(dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.BSPId].ToString());
dtItemPurchaseFeedbackDetails = itemPurchasingFeedbackDetailsService.SelectSellersTotalFeedback(itemPurchasingFeedbackDetails);
if (Convert.ToDecimal(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.SellerTotalPositiveFeedback].ToString()) > Convert.ToDecimal(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.SellerTotalNegetiveFeedback].ToString()))
{
    itemRatings = "Top Rated Seller : Positive Feedback (" + dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.SellerTotalPositiveFeedback].ToString() + "%)";
    Response.Write("<img src='images/topratedseller.png' width='30px' title='" + itemRatings + "'/>");
}
else
{
    itemRatings = "Sellers Positive Ratings (" + dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.SellerTotalPositiveFeedback].ToString() + "%)";
    Response.Write("<img src='images/rateditem.png' width='30px' title='" + itemRatings + "'/>");
}
                                                        %>
                                                       
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                        <%
itemDetails.ItemId = Convert.ToInt32(dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString());
dtSingleItemDetails = itemDetailsService.SelectThisItemDetailsForMainPage(itemDetails);
if (Convert.ToDecimal(dtSingleItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemRatings]) > 40)
{
    itemRatings = "Top Rated Item (" + dtSingleItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemRatings].ToString() + "%)";
    Response.Write("<img src='images/toprateditem.png' width='30px' title='" + itemRatings + "'/>");
}
else
{
    itemRatings = "Item Ratings (" + dtSingleItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemRatings].ToString() + "%)";
    Response.Write("<img src='images/rateditem.png' width='30px' title='" + itemRatings + "'/>");
}
                                                        %>
                                                        </td>
                                                    </tr>
                                                </table>
                                                                                            
                                           </td>
                                        </tr>
                                    </table>

                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                <hr  class="separator"/>
                                 </td>
                            </tr>

                             <tr>
                                <td  >
                                <p style="max-height:200px; min-height:200px; vertical-align:top;">
                                
                                <%  
if (dtItemImageDetails.Rows.Count > 0)
{
    Response.Write("<a href='viewitem.aspx?iid=" + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString() + "' class='itemName' title='" + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemName].ToString() + "'>");
    Response.Write(" <img src='" + dtItemImageDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemImageDetails.ImagePath].ToString() + "' width='100%' style='max-height:200px; min-height:200px;'  />");
    Response.Write("<a href='viewitem.aspx?iid=" + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString() + "' class='itemName' title='Click Here To View More Details.'>");

}
else
{
    Response.Write("<a href='viewitem.aspx?iid=" + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString() + "' class='itemName' title='" + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemName].ToString() + "'>");
    Response.Write(" <img src='images/noimage.png' width='100%' style='max-height:200px; min-height:200px;'  />");
    Response.Write("<a href='viewitem.aspx?iid=" + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemId].ToString() + "' class='itemName' title='Click Here To View More Details.'>");

}
                                %>
                                </p>
                               </td>
                            </tr>

                            <tr>
                              <td class="style11">
                                <hr class="itemSeparator"/>
                               </td>
                            </tr>
                            <tr>
                                <td >
                                
                                    <table cellpadding="3" cellspacing="2" class="style1">
                                        <tr>
                                            <td style="text-align:left; width:5%;">
                                               <img src="images/price.png" width="20px" title="Item Price"/></td>

                                            <td class="itemPrice" style="text-align:left; width:60%;">
                                               <% Response.Write(CommonParameterNames.Curruncy.LKR + ' ' + dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.UnitPrice].ToString()); %>
                                             </td>

                                            <td style="text-align:left; width:5%;">
                                            <img src="images/delevery.png" width="20px" title="Delevery Price" />
                                             </td>

                                            <td class="itemShipping" style="text-align:left; width:30%;">
                                             <% Response.Write(dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.DeliveryOption].ToString()); %>
                                            </td>
                                        </tr>
                                    </table>
                                
                               </td>
                            </tr>

                            <tr>
                              <td class="style11">
                                <hr class="itemSeparator"/>
                               </td>
                            </tr>

                            <tr>
                                <td class="itemCategory">
                                <p style="max-height:20px; min-height:20px; vertical-align:top; margin-top:-3px; margin-bottom:20px;">
                                <a href="#" title="Category" style="font-style:italic">
                                 <% Response.Write(dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.Category].ToString()); %>
                                </a>
                                 &nbsp; >>   &nbsp;
                                <a href="#" title="Sub Category" style="font-style:italic">
                                 <% Response.Write(dtItemDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.SubCategory].ToString()); %>
                                 </a>
                                 </p>
                                 
                               </td>
                            </tr>
                        </table>                     
                     </div>
                     
                    </td>
                     <% 
if (space != 3)
{
    Response.Write("<td style='min-width:20px;'> &nbsp;</td>");
}
space = space + 1;
            }

            else
            {
                Response.Write("</td>");
            }



        }
        itemRowIndex = itemRowIndex + 4;
        itemCountForDecrement = itemCountForDecrement - 4;

        Response.Write("</tr>");
        Response.Write("<tr ><td style='padding:11px'></td></tr>");
        space = 0;

    }
}
else
{
    Response.Write("<h3>Sorry ! ,There is no items in your selection at this moment.<h3>");
    Response.Write("<a href='home.aspx'>Go to home page ...</a>");
}

                       } %>
                    <!-- Single Item -->
                    
                    </table>               

</asp:Content>
