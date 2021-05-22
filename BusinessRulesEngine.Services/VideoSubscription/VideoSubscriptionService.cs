using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Services.PackingSlip;
using BusinessRulesEngine.Contracts.Services.VideoSubsciption;

namespace BusinessRulesEngine.Services.VideoSubscription
{
    public class VideoSubscriptionService : IVideoSubscription
    {
        private readonly IPackingSlip _packingSlip;
        public VideoSubscriptionService(IPackingSlip packingSlip)
        {
            _packingSlip = packingSlip;
        }

        public void CheckUserVideoSubscriptionPlans(string videoName)
        {
            _packingSlip.AddVideoToPackingSlip(videoName);
        }
    }
}
