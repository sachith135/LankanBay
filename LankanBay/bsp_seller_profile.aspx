<%@ Page Title="" Language="C#" MasterPageFile="~/masterpages/sitemaster.Master"
    AutoEventWireup="true" CodeBehind="bsp_seller_profile.aspx.cs" Inherits="LankanBay.bsp_seller_profile" %>

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
        
        .style13
        {
            width: 23px;
        }
        
.rating {
      overflow: hidden;
      display: inline-block;
  }
  .rating-input {
      float: right;
      width: 16px;
      height: 16px;
      padding: 0;
      margin: 0 0 0 -16px;
      opacity: 0;
  }
  .rating-star {
      display: block;
      width: 16px;
      height: 16px;
      background: url('images/edit.ico') 0 -16px;
  }
  .rating-star:hover {
      background-position: 0 0;
  }
  
        
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="pageContainer" style="height:600px;"> 
        <table style="width:" cellpadding="0">
            <tr>
                <td colspan="2">
                    <asp:Label ID="Label1" runat="server" CssClass="fromHeaderText" Text="Seller's Profile ...."></asp:Label>
                    <hr class="separator" />
                </td>
            </tr>
            <tr class="bspProfileHeader">
                <td class="style10" style="text-align: left; padding: 5px; vertical-align: middle;">
                    <asp:Label ID="lblSellersName" runat="server" CssClass="bspProfileName"></asp:Label>
                    <br />
                    <asp:Label ID="lblContactNo" runat="server" CssClass="bspProfileAddress"></asp:Label>
                    <br />
                    <asp:Label ID="lblEmail" runat="server" CssClass="bspProfileAddress"></asp:Label>
                    <br />
                    <asp:Label ID="lblSellersAddress" runat="server" CssClass="bspProfileAddress"></asp:Label>
                </td>
                <td style="height: 100px; text-align: right; padding: 5px;">
                    <asp:Image ID="imgBSPImage" runat="server" Height="100px" Width="100px" class="itemShowContainerDiv" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <hr class="separator" />
                </td>
            </tr>
        </table>
        <br />
        <telerik:RadTabStrip ID="RadTabStrip1" runat="server" MultiPageID="RadMultiPage1"
            SelectedIndex="0">
            <Tabs>
                <telerik:RadTab runat="server" Text="Seller's General Details" Selected="True">
                </telerik:RadTab>
                <telerik:RadTab runat="server" Text="Seller's Feedbacks">
                </telerik:RadTab>
            </Tabs>
        </telerik:RadTabStrip>
        <hr class="separator" />
        <telerik:RadMultiPage ID="RadMultiPage1" runat="server" SelectedIndex="0" Width="100%">
            <telerik:RadPageView ID="RadPageView1" runat="server">
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" CssClass="fromHeaderText" Text="Rate this seller"></asp:Label>
                            &nbsp;  &nbsp; 
                            <asp:Label ID="Label4" runat="server" 
                                Text="( First select feedback status (using imotions) then give detail feedback (if any) then click 'Rate this seller' button. )" 
                                Font-Bold="True" ForeColor="Gray"></asp:Label>
                            <hr class="separator" />
                        </td>
                        <td rowspan="2" width="250px">
                            <!-- ----------------- Sellers ratings ------------ -->
                            <asp:Panel ID="pnlSellersRating" runat="server">
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

                                    if (Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0)
                                    {
                                        //Sellers Informations ----------------------------------------------------------------------------                
                                        itemPurchasingFeedbackDetails.ReceiversBspId = Convert.ToInt32(Request.QueryString[0].ToString());
                                        dtItemPurchaseFeedbackDetails = itemPurchasingFeedbackDetailsService.SelectSellersTotalFeedback(itemPurchasingFeedbackDetails);           // -------------------------------------------------------------------------------------------------

                                        if (dtItemPurchaseFeedbackDetails.Rows.Count <= 0)
                                        {
                                            Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                                        }

                                    }
                                    else
                                    {
                                        Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                                    }
                                %>
                                <table cellpadding="2" cellspacing="2" width="100%" class="myTable">
                                    <tr>
                                        <td colspan="4" style="text-align: left; font-weight: bold; color: #007EFF; background-color: #CECECE;
                                            padding: 2px;">
                                            <strong>Sellers Rating Informations</strong>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="4" style="text-align: left; font-weight: bold; color: #007EFF;">
                                            <% Response.Write("<a href='#' >" + dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.BspName].ToString() + "</a>"); %>
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
                                            <asp:HyperLink ID="hyplSellersOtherItems" runat="server">View seller&#39;s other items</asp:HyperLink>
                                        </td>
                                    </tr>
                                </table>
                            </asp:Panel>
                            <!-- ----------------- Sellers ratings ------------ -->
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
                                <AjaxSettings>
                                    <telerik:AjaxSetting AjaxControlID="chkIsCheck">
                                        <UpdatedControls>
                                            <telerik:AjaxUpdatedControl ControlID="chkIsCheck" />
                                        </UpdatedControls>
                                    </telerik:AjaxSetting>
                                </AjaxSettings>

                            </telerik:RadAjaxManager>
                            <telerik:RadGrid ID="dgFeedbackTypes" runat="server" AllowPaging="True" AllowSorting="True"
                                AutoGenerateColumns="False" GridLines="None" Skin="Sitefinity">
                                <MasterTableView>
                                    <RowIndicatorColumn>
                                        <HeaderStyle Width="20px" />
                                    </RowIndicatorColumn>
                                    <ExpandCollapseColumn>
                                        <HeaderStyle Width="20px" />
                                    </ExpandCollapseColumn>
                                    <Columns>
                                        <telerik:GridTemplateColumn UniqueName="TempCheckBox">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkIsCheck" runat="server" AutoPostBack="false" OnCheckedChanged="chkIsCheck_CheckedChanged" />
                                            </ItemTemplate>
                                            <ItemStyle Width="15px" />
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridBoundColumn DataField="ItemPurchasingFeedbackTypeId" Display="False"
                                            HeaderText="ItemPurchasingFeedbackTypeId" UniqueName="ItemPurchasingFeedbackTypeId">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="ItemPurchasingFeedbackType" HeaderText="Feedback Type"
                                            UniqueName="ItemPurchasingFeedbackType">
                                        </telerik:GridBoundColumn>
                                    </Columns>
                                </MasterTableView>
                            </telerik:RadGrid>
                            <br />
                            <hr class="separator" />
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Give your feedback detailty..." CssClass="fromHeaderText"></asp:Label>
                            <br />
                            <br />
                            
                            <telerik:RadTextBox ID="txtFeedback" runat="server" TextMode="MultiLine" Width="100%">
                            </telerik:RadTextBox>
                            <br /><br />
                            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                                Text="Rate this seller / Give Feedback" />
                               
                        </td>
                    </tr>
                </table>
            </telerik:RadPageView>
            <telerik:RadPageView ID="RadPageView2" runat="server">
                RadPageView</telerik:RadPageView>
        </telerik:RadMultiPage>
    </div>

</asp:Content>
