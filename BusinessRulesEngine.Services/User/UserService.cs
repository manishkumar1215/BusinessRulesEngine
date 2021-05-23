using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.User;

namespace BusinessRulesEngine.Services.User
{
    public class UserService : IUser
    {
        public readonly IUserRepo _userRepo;
        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public void AddNewUserDetails()
        {
            // Use Repo Methods
            throw new NotImplementedException();
        }

        public void UpdateExistingUserDetails()
        {
            // Update Repo Methods
            throw new NotImplementedException();
        }
    }
}
