using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.DTO.Product
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductType { get; set; }

        public int ProductQuantity { get; set; }
    }
}
