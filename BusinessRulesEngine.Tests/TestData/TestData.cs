using BusinessRulesEngine.DTO.Payment;
using BusinessRulesEngine.DTO.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Tests.TestData
{
    public static class TestData
    {
        public static PaymentDTO GetMockPaymentData()
        {
            PaymentDTO paymentDTO = new PaymentDTO();
            paymentDTO.PaymentId = 123;
            paymentDTO.PaymentType = "Card";
            paymentDTO.User = new DTO.User.UserDTO()
            {
                UserId = 1,
                UserName = "Manish Kumar",
                UserCity = "Hyderabad"
            };
            paymentDTO.MembershipDTO = new DTO.Membership.MembershipDTO()
            {
                MembershipId = 1,
                MembershipName = "New Membership",
                MembershipDuration = "1 Year"
            };
            paymentDTO.VideoSubscriptionDTO = new DTO.VideoSubscription.VideoSubscriptionDTO()
            {
                VideoSubscriptionId = 1,
                VideoSubscriptionName = "Learning to Ski",
                VideoSubscriptionType = "Annual"
            };
            paymentDTO.PackingSlipDTO = new DTO.PackingSlip.PackingSlipDTO()
            {
                PackingSlipId = 1,
                PackingSlipDetails = "Packing Slip",
            };
            paymentDTO.Order = new DTO.Order.OrderDTO()
            {
                OrderId = 77,
                OrderDate = DateTime.UtcNow,
                Products = new List<ProductDTO>()
                {
                    new ProductDTO()
                    {
                        ProductId = 22,
                        ProductName = "APJ Kalam Biography",
                        ProductType = "Book",
                        ProductQuantity = 1
                    },
                    new ProductDTO()
                    {
                        ProductId = 22,
                        ProductName = "Gandhi Ji Biography",
                        ProductType = "Book",
                        ProductQuantity = 1
                    }
                }
            };
            return paymentDTO;
        }
    }
}
