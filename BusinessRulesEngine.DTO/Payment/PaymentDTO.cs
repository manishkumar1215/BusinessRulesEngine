using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DTO.Payment
{
    public class PaymentDTO
    {
        public int PaymentId { get; set; }
        public string PaymentType { get; set; }
        public int OrderId { get; set; }

        public Order.OrderDTO Order { get; set; }
        public User.UserDTO User { get; set; }

    }
}
