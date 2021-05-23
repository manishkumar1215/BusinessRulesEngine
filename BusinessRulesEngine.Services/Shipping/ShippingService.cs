using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Shipping;
using BusinessRulesEngine.DTO.PackingSlip;

namespace BusinessRulesEngine.Services.Shipping
{
    public class ShippingService : IShipping
    {
        private readonly IShippingRepo _shippingRepo;
        public ShippingService(IShippingRepo shippingRepo)
        {
            _shippingRepo = shippingRepo;
        }
        public void SaveShippingDetails(PackingSlipDTO packingSlipDTO)
        {
            // Save Shipping Details here.
            throw new NotImplementedException();
        }
    }
}
