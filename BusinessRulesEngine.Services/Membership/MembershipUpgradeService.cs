using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Membership;
using BusinessRulesEngine.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Services.Membership
{
    public class MembershipUpgradeService : IMembershipUpgrade
    {
        private readonly IMembershipUpgradeRepo _membershipUpgradeRepo;
        public MembershipUpgradeService(IMembershipUpgradeRepo membershipUpgradeRepo)
        {
            _membershipUpgradeRepo = membershipUpgradeRepo;
        }
        public void UpgradeMembership(UserDTO user)
        {
            // Upgrade Memebership
            throw new NotImplementedException();
        }
    }
}
