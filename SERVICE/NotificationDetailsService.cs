using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DOMAIN;
using DATA;
using System.Data;

namespace SERVICE
{
    public class NotificationDetailsService
    {
        NotificationDetailsEntry notificationDetailsEntry = new NotificationDetailsEntry();

        public DataTable SelectNotificationTypes(NotificationsDetails notificationsDetails)
        {
            return notificationDetailsEntry.SelectNotificationTypes(notificationsDetails);
        }

        public DataTable SelectBSPNotifications(NotificationsDetails notificationsDetails)
        {
           return notificationDetailsEntry.SelectBSPNotifications(notificationsDetails);
        }

        public void UpdateBusinessPartnerNotificationsToRead(NotificationsDetails notificationDetails)
        {
            notificationDetailsEntry.UpdateBusinessPartnerNotificationsToRead(notificationDetails);
        }

    }
}