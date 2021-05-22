using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Services.Payment;

namespace BusinessRulesEngine.Services.Payment
{
    public class PaymentService : IPayment
    {
        public PaymentService()
        { 
        
        }
        public bool ProcessPayment 
            { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
