using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Contracts.Services.PackingSlip
{
    public interface IPackingSlipRoyaltyDep
    {
        void CopyOriginalPackingSlipNumberForRoyDep(int PackingSlipId);
    }
}
