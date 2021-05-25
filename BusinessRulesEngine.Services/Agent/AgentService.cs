using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Agent;
using BusinessRulesEngine.Contracts.Services.Payment;
using BusinessRulesEngine.DTO.Payment;

namespace BusinessRulesEngine.Services.Agent
{
    // I have written Test Cases for Payment Controller , Agent Service & PackingSlip Service for reference of Unit Tests cases.
    public class AgentService : IAgent
    {
        private readonly IPayment _payment;
        private readonly IPaymentRepo _paymentRepo;
        
        public AgentService(IPayment payment, IPaymentRepo paymentRepo)
        {
            _payment = payment;
            _paymentRepo = paymentRepo;
        }

        public void DoAgentCommissonPayment(PaymentDTO paymentDto)
        {
            _payment.ProcessPayment(paymentDto);
        }
    }
}
