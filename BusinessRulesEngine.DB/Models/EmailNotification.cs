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
    public class EmailNotification
    {
        public int EmailNotificationId { get; set; }
        public string EmailMessageBody { get; set; }

    }
}
