using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DB.Models
{
    /// <summary>
    /// DB Entity Class
    /// </summary>
    public class PackingSlip
    {
        public int PackingSlipId { get; set; }
        public string PackingSlipDetails { get; set; }
    }
}
