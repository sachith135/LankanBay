using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOMAIN
{
    public class NotificationsDetails
    {
        public int NotificationTypeId { get; set; }
        public int ReceiverBSPId { get; set; }

        public int BusinessPartnersWiseNotificationId { get; set; }
        public int UserId { get; set; }
    }
}