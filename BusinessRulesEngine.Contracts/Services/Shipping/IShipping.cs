using BusinessRulesEngine.DTO.PackingSlip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Contracts.Services.Shipping
{
    public interface IShipping
    {
        void SaveShippingDetails(PackingSlipDTO packingSlipDTO);
    }
}
