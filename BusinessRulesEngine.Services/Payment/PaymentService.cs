using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Services.Payment;
using BusinessRulesEngine.DTO.Payment;

namespace BusinessRulesEngine.Services.Payment
{
    public class PaymentService : IPayment
    {
        public PaymentService()
        { 
        
        }

        public bool ProcessPayment(PaymentDTO paymentDto)
        {
            return true;
        }
    }
}
