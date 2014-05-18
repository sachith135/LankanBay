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

namespace LankanBay.admin
{
    public partial class admin_view_notification_quequ : System.Web.UI.Page
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

        }

        protected void dgNotification_NeedDataSource(object source, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
        {

            notificationsDetails = new NotificationsDetails();
            notificationsDetails.ReceiverBSPId = Convert.ToInt32(Session[CommonParameterNames.LoggedUserDetails.bspId]);
            dgNotification.DataSource = notificationDetailsService.SelectNotificationTypes(notificationsDetails);
        }

        protected void dgNotification_PageIndexChanged(object source, Telerik.Web.UI.GridPageChangedEventArgs e)
        {
            FillNotifications();
        }

        protected void dgNotification_PageSizeChanged(object source, Telerik.Web.UI.GridPageSizeChangedEventArgs e)
        {
            FillNotifications();
        }

        protected void dgNotification_SortCommand(object source, Telerik.Web.UI.GridSortCommandEventArgs e)
        {
            FillNotifications();
        }

        protected void dgNotification_ItemCommand(object source, Telerik.Web.UI.GridCommandEventArgs e)
        {

        }

        protected void dgNotification_DetailTableDataBind(object source, GridDetailTableDataBindEventArgs e)
        {
            dgNotification.MasterTableView.DetailTables[0].DataSource = null;
            dgNotification.MasterTableView.DetailTables[0].DataBind();

            GridDataItem item = (GridDataItem)e.DetailTableView.ParentItem;
            notificationsDetails.NotificationTypeId = Convert.ToInt32(item["NotificationTypeId"].Text);
            notificationsDetails.ReceiverBSPId = 4;

            dgNotification.MasterTableView.DetailTables[0].DataSource = notificationDetailsService.SelectBSPNotifications(notificationsDetails);
            dgNotification.MasterTableView.DetailTables[0].DataBind();
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
    }
}