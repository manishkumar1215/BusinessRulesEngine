using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Services.Shipping;
using BusinessRulesEngine.DTO.PackingSlip;

namespace BusinessRulesEngine.Services.Shipping
{
    public class ShippingService : IShipping
    {
        public ShippingService()
        {

        }
        public void SaveShippingDetails(PackingSlipDTO packingSlipDTO)
        {
            // Save Shipping Details here.
            throw new NotImplementedException();
        }
    }
}
