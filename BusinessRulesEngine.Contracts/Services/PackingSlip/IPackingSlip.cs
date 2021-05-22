using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Contracts.Services.PackingSlip
{
    public interface IPackingSlip
    {
        int GeneratePackingSlip();
        void AddVideoToPackingSlip(string videoName);
    }
}
