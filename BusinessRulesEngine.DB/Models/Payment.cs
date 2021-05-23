using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DB.Models
{
    /// <summary>
    /// Db Enity Class
    /// </summary>
    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
    }
}
