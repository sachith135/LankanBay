using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using DATA.COMMON;
using DOMAIN;

namespace DATA
{
    public class NotificationDetailsEntry
    {
        public DataTable SelectNotificationTypes(NotificationsDetails notificationsDetails)
        {
            try
            {
                Dictionary<string, object> spParameters = new Dictionary<string, object>();
                spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerNotificationsDetails.ReceiverBSPId, notificationsDetails.ReceiverBSPId);
               return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_NotificationTypes,spParameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataTable SelectBSPNotifications(NotificationsDetails notificationsDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerNotificationsDetails.NotificationTypeId, notificationsDetails.NotificationTypeId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerNotificationsDetails.ReceiverBSPId, notificationsDetails.ReceiverBSPId);
            return DataBaseUtilities.DataBaseUtilities.Select(WellKnownStoredProcedures.Select.Select_BusinessPartnerWiseNotifications, spParameters);
        }

        public void UpdateBusinessPartnerNotificationsToRead(NotificationsDetails notificationsDetails)
        {
            Dictionary<string, object> spParameters = new Dictionary<string, object>();
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerNotificationsDetails.BusinessPartnersWiseNotificationId, notificationsDetails.BusinessPartnersWiseNotificationId);
            spParameters.Add(WellKnownParameters.BusinessPartner.BusinessPartnerNotificationsDetails.UserId, notificationsDetails.UserId);
            DataBaseUtilities.DataBaseUtilities.Insert(WellKnownStoredProcedures.Insert.Update_BusinessPartnerWiseNotificationsToRead, spParameters);
        }
    }
}