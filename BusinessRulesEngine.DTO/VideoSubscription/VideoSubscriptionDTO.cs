using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DTO.VideoSubscription
{
    public class VideoSubscriptionDTO
    {
        public int VideoSubscriptionId { get; set; }
        public string VideoSubscriptionType { get; set; }

        public string VideoSubscriptionName { get; set; }

        public bool IsFirstVideoSubscription { get; set; }

        public User.UserDTO User { get; set; }

        public PackingSlip.PackingSlipDTO packingSlip { get; set; }

    }
}
