using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Contracts.Services.User
{
    public interface IUser
    {
        void AddNewUserDetails();
        void UpdateExistingUserDetails();
    }
}
