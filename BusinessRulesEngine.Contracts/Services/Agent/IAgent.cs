using BusinessRulesEngine.DTO.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Contracts.Services.Agent
{
    public interface IAgent
    {
        void DoAgentCommissonPayment(PaymentDTO paymentDto);
    }
}
