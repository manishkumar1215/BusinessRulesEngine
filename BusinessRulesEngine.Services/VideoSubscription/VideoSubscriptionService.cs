using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.PackingSlip;
using BusinessRulesEngine.Contracts.Services.VideoSubsciption;

namespace BusinessRulesEngine.Services.VideoSubscription
{
    public class VideoSubscriptionService : IVideoSubscription
    {
        private readonly IPackingSlip _packingSlip;
        private readonly IVideoSubscriptionRepo _videoSubscriptionRepo;
        public VideoSubscriptionService(IPackingSlip packingSlip, IVideoSubscriptionRepo videoSubscriptionRepo)
        {
            _packingSlip = packingSlip;
            _videoSubscriptionRepo = videoSubscriptionRepo;
        }

        public void CheckUserVideoSubscriptionPlans(string videoName)
        {
            _packingSlip.AddVideoToPackingSlip(videoName);
        }
    }
}
