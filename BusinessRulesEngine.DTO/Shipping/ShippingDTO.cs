using BusinessRulesEngine.DTO.PackingSlip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DTO.Shipping
{
    public class ShippingDTO
    {
        public int ShippingId { get; set; }
        public string ShippingDetails { get; set; }

        public PackingSlipDTO PackingSlip { get; set; }
    }
}
