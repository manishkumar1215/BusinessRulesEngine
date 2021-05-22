using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DTO.User
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserCity { get; set; }

        public Membership.MembershipDTO Membership { get; set; }
        public VideoSubscription.VideoSubscriptionDTO VideoSubscription { get; set; }
    }
}
