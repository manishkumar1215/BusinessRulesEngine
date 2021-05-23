using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Payment;
using BusinessRulesEngine.DTO.Payment;

namespace BusinessRulesEngine.Services.Payment
{
    public class PaymentService : IPayment
    {
        private readonly IPaymentRepo _paymentRepo;
        public PaymentService(IPaymentRepo paymentRepo)
        {
            _paymentRepo = paymentRepo;
        }

        public bool ProcessPayment(PaymentDTO paymentDto)
        {
            return true;
        }
    }
}
