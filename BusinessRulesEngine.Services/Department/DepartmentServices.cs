using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Services.Department
{
    public class DepartmentServices : IDepartment
    {
        private readonly IDepartmentRepo _departmentRepo;
        public DepartmentServices(IDepartmentRepo departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }
        public void SaveDepartmentDetails(int PackingSlipId)
        {
            // This will Save the Packing Slip details with Department entity.
            throw new NotImplementedException();
        }
    }
}
