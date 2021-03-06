using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DB.Models
{
    /// <summary>
    /// DB Entity Class
    /// </summary>
    public class VideoSubscription
    {
        public int VideoSubscriptionId { get; set; }
        public string VideoSubscriptionType { get; set; }

        public string VideoSubscriptionName { get; set; }

        public bool IsFirstVideoSubscription { get; set; }
    }
}
