using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine;
using BusinessRulesEngine.Contracts.Services.Agent;
using BusinessRulesEngine.Contracts.Services.Payment;
using BusinessRulesEngine.DTO.Payment;

namespace BusinessRulesEngine.Services.Agent
{
    public class AgentService : IAgent
    {
        private readonly IPayment _payment;
        
        public AgentService(IPayment payment)
        {
            _payment = payment;
        }

        public void DoAgentCommissonPayment(PaymentDTO paymentDto)
        {
            _payment.ProcessPayment(paymentDto);
        }
    }
}
