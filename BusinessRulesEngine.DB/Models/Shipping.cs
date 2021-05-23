using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DB.Models
{
    /// <summary>
    /// Db Entity Class
    /// </summary>
    public class Shipping
    {
        public int ShippingId { get; set; }
        public string ShippingDetails { get; set; }
    }
}
