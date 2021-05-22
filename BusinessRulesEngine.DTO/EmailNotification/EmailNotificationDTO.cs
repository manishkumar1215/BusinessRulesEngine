using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DTO.EmailNotification
{
    public class EmailNotificationDTO
    {
        public int EmailNotificationId { get; set; }
        public string EmailMessageBody { get; set; }

        public Membership.MembershipDTO Membership { get; set; }
    }
}
