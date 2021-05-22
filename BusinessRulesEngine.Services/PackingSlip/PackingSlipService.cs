using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Services.PackingSlip;
using BusinessRulesEngine.Contracts.Services.Shipping;
using BusinessRulesEngine.DTO.PackingSlip;

namespace BusinessRulesEngine.Services.PackingSlip
{
    public class PackingSlipService : IPackingSlip
    {
        private IShipping _shipping;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="shipping"></param>
        public PackingSlipService(IShipping shipping)
        {
            _shipping = shipping;
        }

        public void AddVideoToPackingSlip(string videoName)
        {
            PackingSlipDTO packingSlip = new PackingSlipDTO();
            packingSlip.PackingSlipDetails = videoName;

            _shipping.SaveShippingDetails(packingSlip);
        }

        public int GeneratePackingSlip()
        {
            throw new NotImplementedException();
        }
    }
}
