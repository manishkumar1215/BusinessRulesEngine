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
    public class Membership
    {
        public int MembershipId { get; set; }
        public string MembershipName { get; set; }
        public string MembershipDuration { get; set; }
    }
}
