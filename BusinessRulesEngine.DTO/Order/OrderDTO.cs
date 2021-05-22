﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.DTO;

namespace BusinessRulesEngine.DTO.Order
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<BusinessRulesEngine.DTO.Product.ProductDTO> Products { get; set; }
    }
}
