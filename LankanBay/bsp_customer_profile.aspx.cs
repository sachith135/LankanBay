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
    public partial class bsp_customer_profile : System.Web.UI.Page
    {

        BusinessPartnerReferenceDetails businessPartnerReferenceDetails = new BusinessPartnerReferenceDetails();
        BusinessPartnerReferenceDetailsService businessPartnerReferenceDetailsService = new BusinessPartnerReferenceDetailsService();

        ItemPurchasingFeedbackDetails itemPurchasingFeedbackDetails = new ItemPurchasingFeedbackDetails();
        ItemPurchasingFeedbackDetailsService itemPurchasingFeedbackDetailsService = new ItemPurchasingFeedbackDetailsService();

        UserWiseItemViewDetailsService userWiseItemViewDetailsService = new UserWiseItemViewDetailsService();

        DataTable dtBSPReference = new DataTable();
        DataTable dtItemPurchaseFeedbackDetails = new DataTable();

        OrderDetails orderDetails = new OrderDetails();
        OrderDetailsService orderDetailsService = new OrderDetailsService();

        OrderDetailsInDetail orderDetailsInDetail = new OrderDetailsInDetail();
        OrderDetailsInDetailService orderDetailsInDetailService = new OrderDetailsInDetailService();

        NotificationDetailsService notificationDetailsService = new NotificationDetailsService();
        NotificationsDetails notificationsDetails = new NotificationsDetails();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    FillBasicDetails();
                    FillViewedItemGrid();
                    FillOrderHistoryGrid();
                    FillNotifications();

                }
            }
            catch (Exception)
            {
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }

        }

        private void FillNotifications()
        {
            try
            {
                dgNotification.DataSource = null;
                dgNotification.DataBind();

                notificationsDetails = new NotificationsDetails();
                notificationsDetails.ReceiverBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);
                dgNotification.DataSource = notificationDetailsService.SelectNotificationTypes(notificationsDetails);
                dgNotification.DataBind();                

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FillBasicDetails()
        {

            if (Request.QueryString[0] != null && Request.QueryString[0].ToString().Length != 0)
            {
                if (Request.QueryString[1] != null && Request.QueryString[1].ToString().Length != 0)
                {
                    for (int i = 0; i < ((DataTable)Session["dtCart"]).Rows.Count; i++)
                    {
                        ((DataTable)Session["dtCart"]).Rows.RemoveAt(i);
                    }

                    Session["OredeId"] = null;
                    Session["ItemId"] = null;
                }

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

                }

            }

            else
            {
                Response.Redirect(CommonParameterNames.PageURLs.HomePage);
            }
        }

        private void FillViewedItemGrid()
        {
            dgViewedItems.DataSource = null;
            dgViewedItems.DataBind();

            dgViewedItems.DataSource = userWiseItemViewDetailsService.SelectUserWiseItemViewedDetails(Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]));
            dgViewedItems.DataBind();

        }

        private void FillOrderHistoryGrid()
        {
            orderDetails = new OrderDetails();
            orderDetails.BuyerBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);

            dgOrderHistory.DataSource = null;
            dgOrderHistory.DataSource = orderDetailsService.Select(orderDetails);
            dgOrderHistory.DataBind();


            for (int i = 0; i < dgOrderHistory.Items.Count; i++)
            {
                if (dgOrderHistory.Items[i]["OrderStatus"].Text.Trim() != "P")
                {
                    dgOrderHistory.Items[i]["PayNow"].Controls.RemoveAt(0);
                    dgOrderHistory.Items[i]["Delete"].Controls.RemoveAt(0);
                }
                else
                {
                    dgOrderHistory.Items[i]["PayNow"].Font.Bold = true;
                }
            }
        }

        protected void dgViewedItems_PageIndexChanged(object source, GridPageChangedEventArgs e)
        {
            FillViewedItemGrid();
        }

        protected void dgViewedItems_PageSizeChanged(object source, GridPageSizeChangedEventArgs e)
        {
            FillViewedItemGrid();
        }

        protected void dgViewedItems_SortCommand(object source, GridSortCommandEventArgs e)
        {
            FillViewedItemGrid();
        }

        protected void dgViewedItems_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            dgViewedItems.DataSource = null;
            dgViewedItems.DataBind();

            dgViewedItems.DataSource = userWiseItemViewDetailsService.SelectUserWiseItemViewedDetails(Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]));

        }

        protected void dgOrderHistory_DetailTableDataBind(object source, GridDetailTableDataBindEventArgs e)
        {
            dgOrderHistory.MasterTableView.DetailTables[0].DataSource = null;
            dgOrderHistory.MasterTableView.DetailTables[0].DataBind();

            GridDataItem item = (GridDataItem)e.DetailTableView.ParentItem;
            orderDetailsInDetail.OrderId = Convert.ToInt32(item["OrderId"].Text);

            dgOrderHistory.MasterTableView.DetailTables[0].DataSource = orderDetailsInDetailService.Select(orderDetailsInDetail);
            dgOrderHistory.MasterTableView.DetailTables[0].DataBind();

        }

        protected void dgOrderHistory_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            orderDetails = new OrderDetails();
            orderDetails.BuyerBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);

            dgOrderHistory.DataSource = null;
            dgOrderHistory.DataSource = orderDetailsService.Select(orderDetails);

        }

        protected void dgOrderHistory_PageIndexChanged(object source, GridPageChangedEventArgs e)
        {
            FillOrderHistoryGrid();
        }

        protected void dgOrderHistory_PageSizeChanged(object source, GridPageSizeChangedEventArgs e)
        {
            FillOrderHistoryGrid();
        }

        protected void dgOrderHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillOrderHistoryGrid();
        }

        protected void dgOrderHistory_SortCommand(object source, GridSortCommandEventArgs e)
        {
            FillOrderHistoryGrid();
        }

        protected void dgViewedItems_ItemCommand(object source, GridCommandEventArgs e)
        {

        }

        protected void dgOrderHistory_ItemCommand(object source, GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == CommonParameterNames.ItemCommnads.Delete)
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    orderDetails.OrderId = Convert.ToInt32(item["OrderId"].Text);
                    orderDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                    orderDetailsService.DeleteOrderDetailsWithItsAllDetails(orderDetails);

                    DataBaseTransactionService.CommitTransactions();
                    LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                    master.MessageBox(CommonParameterNames.MessageBoxType.SuccessMessage, CommonUserMessages.SuccessfulMessages.deletionSuccessful);

                    FillOrderHistoryGrid();
                }
            }
            catch (Exception)
            {
                DataBaseTransactionService.CommitTransactions();
                LankanBay.masterpages.sitemaster master = (LankanBay.masterpages.sitemaster)this.Master;
                master.MessageBox(CommonParameterNames.MessageBoxType.ErrorMessage, CommonUserMessages.ErrorMessages.sorryWeCantProcessAtThisMoment);
            }
        }

        protected void dgNotification_DetailTableDataBind(object source, GridDetailTableDataBindEventArgs e)
        {
            dgNotification.MasterTableView.DetailTables[0].DataSource = null;
            dgNotification.MasterTableView.DetailTables[0].DataBind();

            GridDataItem item = (GridDataItem)e.DetailTableView.ParentItem;
            notificationsDetails.NotificationTypeId = Convert.ToInt32(item["NotificationTypeId"].Text);
            notificationsDetails.ReceiverBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);

            dgNotification.MasterTableView.DetailTables[0].DataSource = notificationDetailsService.SelectBSPNotifications(notificationsDetails);
            dgNotification.MasterTableView.DetailTables[0].DataBind();

           
           
        }

        protected void dgNotification_NeedDataSource(object source, GridNeedDataSourceEventArgs e)
        {
            notificationsDetails = new NotificationsDetails();
            notificationsDetails.ReceiverBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);
            dgNotification.DataSource = notificationDetailsService.SelectNotificationTypes(notificationsDetails);
        }

        protected void dgNotification_PageIndexChanged(object source, GridPageChangedEventArgs e)
        {
            FillNotifications();
        }

        protected void dgNotification_PageSizeChanged(object source, GridPageSizeChangedEventArgs e)
        {
            FillNotifications();
        }

        protected void dgNotification_SortCommand(object source, GridSortCommandEventArgs e)
        {
            FillNotifications();
        }

        protected void dgNotification_ItemCommand(object source, GridCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "Seen")
                {
                    GridDataItem item = (GridDataItem)e.Item;
                    notificationsDetails.BusinessPartnersWiseNotificationId = Convert.ToInt32(item["BusinessPartnersWiseNotificationId"].Text);
                    notificationsDetails.UserId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.userId]);
                    notificationDetailsService.UpdateBusinessPartnerNotificationsToRead(notificationsDetails);
                    DataBaseTransactionService.CommitTransactions();

                    dgNotification.MasterTableView.DetailTables[0].DataSource = null;
                    dgNotification.MasterTableView.DetailTables[0].DataBind();                   
                    
                    dgNotification.MasterTableView.DetailTables[0].Rebind();
                    FillNotifications();

                }
            }
            catch (Exception)
            {
                DataBaseTransactionService.RollbackTransactions();
            }
        }

        protected void cmbUserType_SelectedIndexChanged(object o, RadComboBoxSelectedIndexChangedEventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {

        }

        protected void btnClose_Click(object sender, EventArgs e)
        {

        }

    }
}