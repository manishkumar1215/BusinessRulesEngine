using BusinessRulesEngine.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Contracts.Services.Membership
{
    public interface IMembershipUpgrade
    {
        void UpgradeMembership(UserDTO user);
    }
}
