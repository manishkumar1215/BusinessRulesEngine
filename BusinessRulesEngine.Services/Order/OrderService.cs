using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Order;

namespace BusinessRulesEngine.Services.Order
{
    public class OrderService : IOrder
    {
        private readonly IOrderRepo _orderRepo;
        public OrderService(IOrderRepo orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public void PlaceOrder()
        {
            throw new NotImplementedException();
        }
    }
}
