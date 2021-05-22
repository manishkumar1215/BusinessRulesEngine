using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Services.Department;
using BusinessRulesEngine.Contracts.Services.PackingSlip;

namespace BusinessRulesEngine.Services.PackingSlip
{
    public class PackingSlipRoyaltyDepService : IPackingSlipRoyaltyDep
    {
        private readonly IDepartment _department;
        public PackingSlipRoyaltyDepService(IDepartment department)
        {
            _department = department;
        }
        public void CopyOriginalPackingSlipNumberForRoyDep(int PackingSlipId)
        {
            _department.SaveDepartmentDetails(PackingSlipId);
        }
    }
}
