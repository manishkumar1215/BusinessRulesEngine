﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Services.Membership;
using BusinessRulesEngine.DTO.User;

namespace BusinessRulesEngine.Services.Membership
{
    public class MembershipService : IMembership
    {
        public MembershipService()
        {

        }
        public void ActivateMembership(UserDTO user)
        {
            // Activate New Membership
            throw new NotImplementedException();
        }

        public void CheckUserMembershipPlans(UserDTO user)
        {
            // Check Existing user membership plans
            throw new NotImplementedException();
        }
    }
}
