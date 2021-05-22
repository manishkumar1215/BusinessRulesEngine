using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Contracts.Services.Payment
{
    public interface IPayment
    {
        bool ProcessPayment { get; set; }
    }
}
