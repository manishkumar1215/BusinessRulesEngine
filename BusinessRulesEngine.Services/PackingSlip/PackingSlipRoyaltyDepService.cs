using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Department;
using BusinessRulesEngine.Contracts.Services.PackingSlip;

namespace BusinessRulesEngine.Services.PackingSlip
{
    public class PackingSlipRoyaltyDepService : IPackingSlipRoyaltyDep
    {
        private readonly IDepartment _department;
        private readonly IPackingSlipRoyaltyDepRepo _packingSlipRoyaltyDepRepo;
        public PackingSlipRoyaltyDepService(IDepartment department, IPackingSlipRoyaltyDepRepo packingSlipRoyaltyDepRepo)
        {
            _department = department;
            _packingSlipRoyaltyDepRepo = packingSlipRoyaltyDepRepo;
        }
        public void CopyOriginalPackingSlipNumberForRoyDep(int PackingSlipId)
        {
            _department.SaveDepartmentDetails(PackingSlipId);
        }
    }
}
