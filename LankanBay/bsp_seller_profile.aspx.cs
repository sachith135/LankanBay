using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DOMAIN;
using SERVICE;
using System.Data;
using Telerik.Web.UI;
namespace LankanBay
{
    public partial class bsp_seller_profile : System.Web.UI.Page
    {

        BusinessPartnerReferenceDetails businessPartnerReferenceDetails = new BusinessPartnerReferenceDetails();
        BusinessPartnerReferenceDetailsService businessPartnerReferenceDetailsService = new BusinessPartnerReferenceDetailsService();

        ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails = new ItemPurchasingFeedbackDetails();
        ItemPurchasingFeedbackDetailsService itemPurchasingFeedbackDetailsService = new ItemPurchasingFeedbackDetailsService();

        DataTable dtBSPReference = new DataTable();
        DataTable dtItemPurchaseFeedbackDetails = new DataTable();

        ItemPurchasingFeedbackTypeDetails itemPurchasingFeedbackTypeDetails = new ItemPurchasingFeedbackTypeDetails();
        ItemPurchasingFeedbackTypeDetailsService itemPurchasingFeedbackTypeDetailsService = new ItemPurchasingFeedbackTypeDetailsService();

        FeedbackStatusDetailsService feedbackStatusDetailsService = new FeedbackStatusDetailsService();
        static DataTable dtRatings = new DataTable();
        DataTable dtCurruntFeedbacksForThisItemByThisUser = new DataTable();
        bool isAnyFeedBackTypeSelected = false;


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                dtRatings = feedbackStatusDetailsService.Select();
                if (!IsPostBack)
                {
                    SetSellerBasicInfo();
                    //EnableOrDisableFeedbakRatings();                     
                }
                FillFeedBackType();
                CheckPriviousFeedbacksForThisItem();

            }
            catch (Exception)
            {
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }
        }

        //private void EnableOrDisableFeedbakRatings()
        //{           
        //    for (int i = 0; i < dgFeedbackTypes.Items.Count; i++)
        //    {
        //        bool a = ((CheckBox)(dgFeedbackTypes.MasterTableView.Items[i]["TempCheckBox"].FindControl("chkIsCheck"))).Checked;
        //        if (a)
        //        {
        //            for (int j = 0; j < dtRatings.Rows.Count; j++)
        //            {
        //                (((CheckBox)dgFeedbackTypes.MasterTableView.Items[i][dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatus].ToString()].FindControl(dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString()))).Enabled = true;
        //            }
        //        }

        //        else
        //        {
        //            for (int j = 0; j < dtRatings.Rows.Count; j++)
        //            {
        //                (((CheckBox)dgFeedbackTypes.MasterTableView.Items[i][dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatus].ToString()].FindControl(dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString()))).Enabled = false;
        //            }
        //        }
        //    }
        //}

        private void CheckPriviousFeedbacksForThisItem()
        {
            try
            {
                string tempColName = "";
                string controlerName = "";

                itemPurchasingFeedbackDetails = new ItemPurchasingFeedbackDetails();
                if (Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0 && Request.QueryString != null)
                {
                    itemPurchasingFeedbackDetails.ItemId = Convert.ToInt32(Request.QueryString[1].ToString());

                    if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.bspId] != null)
                    {
                        itemPurchasingFeedbackDetails.SenderBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId].ToString());
                    }
                    else
                    {
                        itemPurchasingFeedbackDetails.SenderBSPId = -999;
                    }

                    dtCurruntFeedbacksForThisItemByThisUser = itemPurchasingFeedbackDetailsService.SelectFeedbackStatusDetailsByUserAndItem(itemPurchasingFeedbackDetails);

                    if (dtCurruntFeedbacksForThisItemByThisUser.Rows.Count != 0)
                    {
                        for (int i = 0; i < dgFeedbackTypes.Items.Count; i++)
                        {
                            for (int j = 0; j < dtCurruntFeedbacksForThisItemByThisUser.Rows.Count; j++)
                            {
                                if (dgFeedbackTypes.Items[i][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackTypeDetails.ItemPurchasingFeedbackTypeId].Text == dtCurruntFeedbacksForThisItemByThisUser.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackTypeDetails.ItemPurchasingFeedbackTypeId].ToString())
                                {
                                    for (int k = 0; k < dtRatings.Rows.Count; k++)
                                    {

                                        tempColName = dtRatings.Rows[k][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString();
                                        controlerName = dtRatings.Rows[k][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString();

                                        if ((((RadioButton)dgFeedbackTypes.MasterTableView.Items[i][tempColName].FindControl(controlerName))).ID == dtCurruntFeedbacksForThisItemByThisUser.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString())
                                        {
                                            (((CheckBox)dgFeedbackTypes.MasterTableView.Items[i]["TempCheckBox"].FindControl("chkIsCheck"))).Checked = true;
                                            (((CheckBox)dgFeedbackTypes.MasterTableView.Items[i]["TempCheckBox"].FindControl("chkIsCheck"))).Enabled = false;
                                            (((RadioButton)dgFeedbackTypes.MasterTableView.Items[i][tempColName].FindControl(controlerName))).Checked = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        public class MyTemplate : ITemplate
        {

            protected RadioButton boolValue;
            private string colname;

            public MyTemplate(string cName)
            {
                colname = cName;
            }

            public void InstantiateIn(System.Web.UI.Control container)
            {
                boolValue = new RadioButton();
                boolValue.ID = colname;
                boolValue.GroupName = "x";
                container.Controls.Add(boolValue);
            }
            void boolValue_DataBinding(object sender, EventArgs e)
            {
                CheckBox cBox = (CheckBox)sender;
                GridDataItem container = (GridDataItem)cBox.NamingContainer;
            }

        }

        private void SetSellerBasicInfo()
        {
            if (Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0 && Request.QueryString != null)
            {
                businessPartnerReferenceDetails.BSPId = Convert.ToInt32(Request.QueryString[0].ToString());
                dtBSPReference = businessPartnerReferenceDetailsService.Select(businessPartnerReferenceDetails, new BusinessPartnerTypeDetails());

                if (dtBSPReference.Rows.Count <= 0)
                {
                    Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                }
                else
                {

                    itemPurchasingFeedbackDetails.ReceiversBspId = Convert.ToInt32(dtBSPReference.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.BSPId].ToString());
                    dtItemPurchaseFeedbackDetails = itemPurchasingFeedbackDetailsService.SelectSellersTotalFeedback(itemPurchasingFeedbackDetails);


                    lblSellersName.Text = dtBSPReference.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.FullName].ToString();
                    lblContactNo.Text = dtBSPReference.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.PrimaryContactNo].ToString();
                    lblEmail.Text = dtBSPReference.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.PrimaryEmail].ToString();
                    lblSellersAddress.Text = dtBSPReference.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.CompleteAddress].ToString();
                    imgBSPImage.ImageUrl = "images/bspdefaultimage.png";

                    hyplSellersOtherItems.NavigateUrl = CommonParameterNames.PageURLs.Sellers_other_item + Request.QueryString[0].ToString();
                    hyplSellersOtherItems.ToolTip = "View Sellers Other Items";

                    if (dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.BSPShortCode].ToString() == "S")
                    {
                        pnlSellersRating.Visible = true;
                        lblSellersName.Text = dtBSPReference.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.FullName].ToString() + " (+" + dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.SellerTotalPositiveFeedback].ToString() + " / " + dtItemPurchaseFeedbackDetails.Rows[0][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackDetails.SellerTotalNegetiveFeedback].ToString() + ")";
                    }
                    else
                    {
                        lblSellersName.Text = dtBSPReference.Rows[0][CommonParameterNames.CommonTableColumnName.Business_Partners.BusinessPartnerReference.FullName].ToString();
                    }
                }
            }
            else
            {
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }
        }

        private void FillFeedBackType()
        {
            try
            {
                itemPurchasingFeedbackTypeDetails.ForSellerOrCustomer = "C";
                itemPurchasingFeedbackTypeDetails.IsActive = true;

                for (int i = 0; i < dgFeedbackTypes.Columns.Count; i++)
                {
                    if (i > 3)
                    {
                        dgFeedbackTypes.Columns.RemoveAt(i);
                    }
                }

                dgFeedbackTypes.DataSource = itemPurchasingFeedbackTypeDetailsService.Select(itemPurchasingFeedbackTypeDetails);
                dgFeedbackTypes.DataBind();

                for (int i = 0; i < dgFeedbackTypes.Items.Count; i++)
                {
                    for (int j = 0; j < dtRatings.Rows.Count; j++)
                    {
                        GridTemplateColumn tmpAnswer = new GridTemplateColumn();
                        tmpAnswer.ItemTemplate = new MyTemplate(dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString());
                        tmpAnswer.HeaderText = dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatus].ToString();
                        tmpAnswer.HeaderTooltip = dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.ToolTip].ToString();
                        tmpAnswer.HeaderImageUrl = dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.Image].ToString();
                        tmpAnswer.Visible = true;
                        tmpAnswer.ItemStyle.HorizontalAlign = HorizontalAlign.Right;
                        tmpAnswer.ItemStyle.Width = 15;
                        tmpAnswer.UniqueName = dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString();

                        dgFeedbackTypes.Columns.Add(tmpAnswer);
                    }

                    dgFeedbackTypes.DataBind();
                    break;

                }
            }
            catch (Exception)
            {
                LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.generalError);
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }
        }

        protected void chkIsCheck_CheckedChanged(object sender, EventArgs e)
        {
            // EnableOrDisableFeedbakRatings();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (System.Web.HttpContext.Current.Session[CommonParameterNames.LoggedUserDetails.userId] != null)
            {

                string tempColName = "";
                string controlerName = "";
                bool isFeedbackGiven = false;

                for (int i = 0; i < dgFeedbackTypes.Items.Count; i++)
                {
                    itemPurchasingFeedbackDetails.Feedback = txtFeedback.Text.Trim();

                    for (int j = 0; j < dtRatings.Rows.Count; j++)
                    {
                        tempColName = dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString();
                        controlerName = dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString();

                        if ((((CheckBox)dgFeedbackTypes.MasterTableView.Items[i]["TempCheckBox"].FindControl("chkIsCheck"))).Enabled)
                        {
                            if ((((RadioButton)dgFeedbackTypes.MasterTableView.Items[i][tempColName].FindControl(controlerName))).Checked)
                            {
                                isFeedbackGiven = true;
                                itemPurchasingFeedbackDetails.FeedbackStatusId = Convert.ToInt32(dtRatings.Rows[j][CommonParameterNames.CommonTableColumnName.Feedback.FeedbackStatusDetails.FeedbackStatusId].ToString());


                                if (Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0 && Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0 && Request.QueryString != null)
                                {
                                    itemPurchasingFeedbackDetails.ItemId = Convert.ToInt32(Request.QueryString[1].ToString());
                                    itemPurchasingFeedbackDetails.ReceiversBspId = Convert.ToInt32(Request.QueryString[0].ToString());
                                }
                                else
                                {
                                    Response.Redirect(CommonParameterNames.PageURLs.HomePage);
                                }

                                itemPurchasingFeedbackDetails.ItemPurchasingFeedBackId = 1;
                                itemPurchasingFeedbackDetails.ItemPurchasingFeedbackTypeId = Convert.ToInt32(dgFeedbackTypes.Items[i][CommonParameterNames.CommonTableColumnName.Feedback.ItemPurchasingFeedbackTypeDetails.ItemPurchasingFeedbackTypeId].Text);
                                itemPurchasingFeedbackDetails.SenderBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);
                                itemPurchasingFeedbackDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);

                                itemPurchasingFeedbackDetailsService.InsertPurchasingFeedbackDetails(itemPurchasingFeedbackDetails);
                            }
                        }
                    }
                }


                if (isFeedbackGiven)
                {
                    DataBaseTransactionService.CommitTransactions();
                    LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                    master.MessageBox(CommonParameterNames.MessageBoxType.InformationMessage, CommonUserMessages.InformationMessages.thankYouForFeedback);
                }

                CheckPriviousFeedbacksForThisItem();
                SetSellerBasicInfo();

            }
            else
            {
                LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.InformationMessage, CommonUserMessages.InformationMessages.checkLoggedinOrNotBeforeFeedback);

            }

        }
    }
}


   
