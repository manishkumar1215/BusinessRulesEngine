using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Product;

namespace BusinessRulesEngine.Services.Product
{
    public class ProductService : IProduct
    {
        private readonly IProductRepo _productRepo;
        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }
        public void AddProductToCart()
        {
            throw new NotImplementedException();
        }
    }
}
