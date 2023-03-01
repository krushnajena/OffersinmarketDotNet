using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminApi.Models.App
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string ContentId { get; set; }
        public string NotifcationTittle { get; set; }
        public string NotoficationDescription { get; set; }
        public string NotificationIcon { get; set; }
        public int FromUser { get; set; }
        public int ToUser { get; set; }
        public bool IsSeen { get; set; }
        public bool IsArchived { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsDeleted { get; set; }

    }
}
