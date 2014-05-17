<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/sitemaster.Master"
    AutoEventWireup="true" CodeBehind="viewitem.aspx.cs" Inherits="LankanBay.viewitem" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<%@ Register Src="breadcrumb.ascx" TagName="breadcrumb" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style type="text/css">
        .style8
        {
            text-align: left;
            width: 305px;
        }
        .style1
        {
            text-align: left;
            width: 99%;
        }
        .style11
        {
            width: 105px;
            text-align: left;
        }
        .style12
        {
            width: 18px;
            text-align: center;
        }
        .style13
        {
            width: 278px;
            text-align: left;
            font-weight: bold;
        }
        .style14
        {
            width: 200px;
        }
        .style18
        {
            width: 96%;
        }
        .style21
        {
            text-align: left;
            width: 368px;
        }
        .style24
        {
            width: 143px;
        }
        .style28
        {
            text-align: center;
        }
        
        
        table.myTable td, table.myTable th
        {
            border: 1px solid #CCC;
            font-size: 11px;
        }
    </style>
    <link href="styles/jQuery.fancybox.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="js/jquery.elevatezoom.min.js" type="text/javascript"></script>
    <script src="js/jquery.fancybox.pack.js" type="text/javascript"></script>
    <style type="text/css">
        #gallery_01 img
        {
            border: 2px solid white;
            width: 96px;
        }
        .active img
        {
            border: 2px solid #333 !important;
        }
    </style>
    <%@ import namespace="System.Data" %>
    <%@ import namespace="SERVICE" %>
    <%@ import namespace="DOMAIN" %>
    <%
          
        ItemDetails itemDetails = new ItemDetails();
        ItemDetailsService itemDetailsService = new ItemDetailsService();

        ItemImageDetails itemImageDetails = new ItemImageDetails();
        ItemImageDetailsService itemImageDetailsService = new ItemImageDetailsService();

        ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails = new ItemPurchasingFeedbackDetails();
        ItemPurchasingFeedbackDetailsService itemPurchasingFeedbackDetailsService = new ItemPurchasingFeedbackDetailsService();

        PaymetOptionDetailsService paymetOptionDetailsService = new PaymetOptionDetailsService();

        DataTable dtItemDetails = new DataTable();
        DataTable dtItemImageDetails = new DataTable();
        DataTable dtPaymentOptionDetails = new DataTable();
        DataTable dtItemPurchaseFeedbackDetails = new DataTable();

        dtPaymentOptionDetails = paymetOptionDetailsService.SelectPaymentOptions();

        int itemId = 0;

        if (Request.QueryString[CommonParameterNames.URLParameters.ItemId] != null && Request.QueryString[CommonParameterNames.URLParameters.ItemId].ToString().Length != 0)
        {
            itemId = Convert.ToInt32(Request.QueryString[CommonParameterNames.URLParameters.ItemId].ToString());

            itemDetails.ItemId = itemId;
            dtItemDetails = itemDetailsService.SelectThisItemDetailsForMainPage(itemDetails);

            if (dtItemDetails.Rows.Count <= 0)
            {
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }

            //Sellers Informations ----------------------------------------------------------------------------                
            itemPurchasingFeedbackDetails.ReceiversBspId = Convert.ToInt32(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.BSPId].ToString());
            dtItemPurchaseFeedbackDetails = itemPurchasingFeedbackDetailsService.SelectSellersTotalFeedback(itemPurchasingFeedbackDetails);
            // -------------------------------------------------------------------------------------------------


        }
        else
        {
            Response.Redirect(CommonParameterNames.PageURLs.HomePage);
        }

            
                                     
    %>
    <div class="itemShowContainerDiv">
        <uc1:breadcrumb ID="breadcrumb1" runat="server" />
        <hr class="separator" style="margin-top: 0px;" />
        <table cellpadding="2" cellspacing="10" class="style1">
            <tr>
                <td class="style8" rowspan="3" style="text-align: center;" align="center">
                    <!-- ------------------------------  -->
                    <div>
                        <% 
                            DataTable dtMainImageDetailsLarge = new DataTable();
                            itemImageDetails = new ItemImageDetails();
                            itemImageDetails.ItemId = itemId;
                            itemImageDetails.IsLargeImage = true;
                            dtMainImageDetailsLarge = itemImageDetailsService.SelectThisImageDetail(itemImageDetails);

                            DataTable dtMainImageDetailsSmall = new DataTable();
                            itemImageDetails = new ItemImageDetails();
                            itemImageDetails.ItemId = itemId;
                            itemImageDetails.IsLargeImage = false;
                            dtMainImageDetailsSmall = itemImageDetailsService.SelectThisImageDetail(itemImageDetails);

                            if (dtMainImageDetailsSmall.Rows.Count > 0)
                            {
                                Response.Write("<img id='img1' src='" + dtMainImageDetailsSmall.Rows[0]["ImagePath"].ToString() + "' data-zoom-image='" + dtMainImageDetailsLarge.Rows[0]["ImagePath"].ToString() + "' width='300px'  class='itemImageContainer'/> ");

                            }
                            else
                            {
                                Response.Write("<img id='img1' src='images/noimage.png' data-zoom-image='images/noimage.png' width='300px'  class='itemImageContainer'/> ");

                            }
                        %>                        <%--<img id="img1" src="images/small/0.png" data-zoom-image="images/large/0.png" width="300px"  class="itemImageContainer"/>--%>
                        <div id="gallery_01" style="margin-top: 15px; padding-left: 2px;">
                            <%
                                //if (!IsPostBack)
                                //{    
                                if (dtMainImageDetailsLarge.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dtMainImageDetailsLarge.Rows.Count; i++)
                                    {
                                        string smallimg = dtMainImageDetailsLarge.Rows[i]["ImagePath"].ToString();
                                        string largeimg = dtMainImageDetailsLarge.Rows[i]["ImagePath"].ToString();

                                        Response.Write("<a href='#' class='active' data-image='" + smallimg + "' data-zoom-image='" + largeimg + "'>");
                                        Response.Write("<img src='" + smallimg + "' style='max-width:68px;' class='itemImageContainer' />");
                                        Response.Write("</a>");
                                    }
                                }
                                else
                                {
                                    string smallimg = "images/noimage.png";
                                    string largeimg = "images/noimage.png";

                                    Response.Write("<a href='#' class='active' data-image='" + smallimg + "' data-zoom-image='" + largeimg + "'>");
                                    Response.Write("<img src='" + smallimg + "' style='max-width:68px;' class='itemImageContainer' />");
                                    Response.Write("</a>");
                                }
                                //}
                  
                            %>                            <%-- <a  href="#" data-image="images/small/0.png" data-zoom-image="images/large/0.png"> 
            <img src="images/small/0.png" style="max-width:67px"  class="itemImageContainer" />
            </a>

            
            <a href="#" data-image="images/small/1.png" data-zoom-image="images/large/1.png">
            <img src="images/small/1.png" style="max-width:67px"  class="itemImageContainer"/>
            </a>

            <a href="#" data-image="images/small/2.png" data-zoom-image="images/large/2.png">
            <img src="images/small/2.png" style="max-width:67px"  class="itemImageContainer" />
            </a>

            <a href="#" data-image="images/small/3.png" data-zoom-image="images/large/3.png">
            <img src="images/small/3.png" style="max-width:67px"  class="itemImageContainer" />
            </a>--%>
                        </div>
                    </div>
                    <!-- ------------------------------  -->
                    <%
                        //itemImageDetails.ItemId = itemId;
                        //itemImageDetails.ImageTypeId = 1;

                        //dtItemImageDetails= itemImageDetailsService.SelectThisImageDetail(itemImageDetails);
                        //if (dtItemImageDetails.Rows.Count > 0)
                        //{
                        //    Response.Write(" <img src='" + dtItemImageDetails.Rows[0][CommonParameterNames.TableColomnNames.ItemImageDetails.ImagePath].ToString() + "' width='100%' style='max-height:300px; min-height:300px;' title='" + dtItemDetails.Rows[0][CommonParameterNames.TableColomnNames.ItemDetails.ItemName].ToString() + "' />"); 

                        //}                   
                    %>
                </td>
                <td colspan="2" class="itemName">
                    <table cellpadding="0" cellspacing="0" class="style18">
                        <tr>
                            <td style="text-align: left;">
                                <p style="max-height: 40px; min-height: 40px; vertical-align: top; margin-top: -3px;
                                    font-size: 15px;">
                                    <a href="#" class="itemName" title="Click Here To View More Details.">
                                    <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ItemDescription].ToString()); %>
                                    </a>
                                </p>
                            </td>
                            <td>
                                <img src="images/toprateditem.png" width="30px" title="Top Rated Item" />
                            </td>
                            <td>
                                <img src="images/topratedseller.png" width="30px" title="Top Rated Seller" />
                            </td>
                        </tr>
                    </table>
                    <hr class="itemSeparator" />
                </td>
            </tr>
            <tr>
                <td class="style21">
                    <table cellpadding="2" class="style1" cellspacing="5">
                        <tr>
                            <td class="style11">
                                Condition
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.Condition].ToString()); %>
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Quantity
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.QtyInHand].ToString()); %>&nbsp; Available
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Price
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="itemPrice">
                                <% Response.Write(CommonParameterNames.Curruncy.LKR + ' ' + dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.UnitPrice].ToString()); %>
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Shipping
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.DeliveryOption].ToString()); %>
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Delivery
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.DelivaryDescription].ToString()); %>
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Payments
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <%
                            
                                    if (dtPaymentOptionDetails.Rows.Count > 0)
                                    {
                                        for (int i = 0; i < dtPaymentOptionDetails.Rows.Count; i++)
                                        {
                                            Response.Write(" <img src='" + dtPaymentOptionDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.PaymentOptions.LogoPath].ToString() + "' style='max-height:20px; min-height:20px;' title='" + dtPaymentOptionDetails.Rows[i][CommonParameterNames.CommonTableColumnName.Inventory.PaymentOptions.Description].ToString() + "' />");
                                        }
                                    }
                                %>
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Returns
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.ReturnsDescription].ToString()); %>
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Warranty
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.WarrantyDescription].ToString()); %>
                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                Buyer Protection
                            </td>
                            <td class="style12">
                                :
                            </td>
                            <td class="style13">
                                <% Response.Write(dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.IsBuyerProtection].ToString()); %>
                            </td>
                        </tr>
                    </table>
                </td>
                <td width="200px">
                    <div class="itemShowContainerDiv" style="padding: 3px; background-color: #F2F2F2;
                        padding: 3px; padding-right: -3px;">
                        <table cellpadding="2" class="style14">
                            <tr>
                                <td align="center" style="padding-right: 2px;">
                                    <table cellpadding="2" cellspacing="2" width="100%" class="myTable">
                                        <tr>
                                            <td colspan="4" style="text-align: left; font-weight: bold; color: #007EFF; background-color: #CECECE;
                                                padding: 2px;">
                                                <strong>Sellers Rating Informations</strong>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td colspan="4" style="text-align: left; font-weight: bold; color: #007EFF;">
                                                <% Response.Write("<a href='#' >" + dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.BSPName].ToString() + "</a>"); %>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td width="55%">
                                                &nbsp;
                                            </td>
                                            <td width="5%">
                                            </td>
                                            <td width="20%" style="text-align: center;">
                                                <img src="images/postive.png" width="20px" title="Positive feedbacks" />
                                            </td>
                                            <td width="20%" style="text-align: center;">
                                                <img src="images/negetive.png" width="20px" title="Negetive feedbacks" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left">
                                                Posting Speed
                                            </td>
                                            <td class="style28">
                                                :
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.PostingPositiveFeedback].ToString()); %>
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.PostingNegetiveFeedback].ToString()); %>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left">
                                                Delivery Speed
                                            </td>
                                            <td class="style28">
                                                :
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.DeliveryPositiveFeedback].ToString()); %>
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.ItemDeliveryNegetiveFeedback].ToString()); %>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left">
                                                Item Quality
                                            </td>
                                            <td class="style28">
                                                :
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.QualityPositiveFeedback].ToString()); %>
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.ItemQualityNegetiveFeedback].ToString()); %>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left">
                                                Total Feedback
                                            </td>
                                            <td class="style28">
                                                :
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.TotalPositiveFeedback].ToString()); %>
                                            </td>
                                            <td>
                                                <%Response.Write(dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.TotalNegetiveFeedback].ToString()); %>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left" colspan="4">
                                                &nbsp;<asp:LinkButton ID="lnkBtnViewOtherItems" runat="server" onclick="lnkBtnViewOtherItems_Click">View seller&#39;s other items</asp:LinkButton>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="text-align: left" colspan="4">
                                                &nbsp;<asp:LinkButton ID="lnkBtnRateSeller" runat="server" 
                                                    onclick="lnkBtnRateSeller_Click">Rate this seller / View profile</asp:LinkButton>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="style21">
                    <table cellpadding="0" cellspacing="0" class="style18">
                        <tr>
                            <td style="text-align: left; vertical-align: middle;" class="style24">
                                Qty&nbsp;&nbsp;&nbsp;
                            </td>
                            <td style="text-align: left; vertical-align: middle;" class="style24">
                                <telerik:radnumerictextbox id="txtRequestedQty" runat="server" width="80px" value="1"
                                    xmlns:telerik="telerik.web.ui">
                                        <numberformat decimaldigits="0" groupseparator="" /> </telerik:radnumerictextbox>
                            </td>
                            <td style="vertical-align: middle">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="**"
                                    ControlToValidate="txtRequestedQty" Font-Bold="True" ForeColor="Red" ValidationGroup="i"></asp:RequiredFieldValidator>
                            </td>
                            <td style="text-align: left" class="style24">
                                <asp:ImageButton ID="btnAddToCart" runat="server" ImageUrl="images/addtocart.png"
                                    Width="120px" OnClick="btnAddToCart_Click" ValidationGroup="i" />
                            </td>
                            <td style="text-align: left">
                                <asp:ImageButton ID="btnBuyItNow" runat="server" ImageUrl="images/buyitnow.png" Width="120px"
                                    OnClick="btnBuyItNow_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
    <br>
    <div class="itemShowContainerDiv">
        <table cellpadding="0" cellspacing="10" width="100%">
            <tr>
                <td width="100%" style="text-align: left; max-width: 100%; min-width: 100%; z-index: 1000;">
                    <div id="IframeWrapper" style="position: relative;">
                        <div id="iframeBlocker" style="position: absolute; top: 0; left: 0; width: 100%;
                            height: 720px">
                        </div>
                        <% Response.Write("<iframe id='myiframe' scrolling='auto' runat='server' src='" + dtItemDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Inventory.ItemDetails.WebPageURL].ToString() + "' width='100%' height='720px'  style='z-index:-100;'>");
                        %>
                        </iframe>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#img1").elevateZoom({ gallery: 'gallery_01', cursor: 'pointer', galleryActiveClass: "active" });
            $("#img1").bind("click", function (e) {
                var ez = $('#img1').data('elevateZoom');
                ez.closeAll();
                $.fancybox(ez.getGalleryList());
                return false;
            });
        }); 
    </script>
    </telerik:RadWindowManager>
</asp:Content>
