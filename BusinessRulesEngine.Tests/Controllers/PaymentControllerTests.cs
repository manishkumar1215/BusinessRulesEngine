using BusinessRulesEngine.Contracts.Services.Agent;
using BusinessRulesEngine.Contracts.Services.Department;
using BusinessRulesEngine.Contracts.Services.EmailNotification;
using BusinessRulesEngine.Contracts.Services.Membership;
using BusinessRulesEngine.Contracts.Services.Order;
using BusinessRulesEngine.Contracts.Services.PackingSlip;
using BusinessRulesEngine.Contracts.Services.Payment;
using BusinessRulesEngine.Contracts.Services.Product;
using BusinessRulesEngine.Contracts.Services.Shipping;
using BusinessRulesEngine.Contracts.Services.User;
using BusinessRulesEngine.Contracts.Services.VideoSubsciption;
using BusinessRulesEngine.Controllers;
using BusinessRulesEngine.DTO.PackingSlip;
using BusinessRulesEngine.DTO.Payment;
using BusinessRulesEngine.DTO.User;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace BusinessRulesEngine.Tests.Controllers
{
    [TestClass()]
    public class PaymentControllerTests
    {
        public static Mock<IAgent> mockIAgentService;
        public static Mock<IDepartment> mockIDepartmentService;
        public static Mock<IEmailNotification> mockIEmailNotificationService;
        public static Mock<IMembership> mockIMembershipService;

        public static Mock<IMembershipUpgrade> mockIMembershipUpgradeService;
        public static Mock<IOrder> mockIOrderService;
        public static Mock<IPackingSlip> mockIPackingSlipService;
        public static Mock<IPackingSlipRoyaltyDep> mockIPackingSlipRoyaltyDepService;

        public static Mock<IPayment> mockIPaymentService;
        public static Mock<IProduct> mockIProductService;
        public static Mock<IShipping> mockIShippingService;
        public static Mock<IUser> mockIUserService;
        public static Mock<IVideoSubscription> mockIVideoSubscriptionService;

        public static PaymentController paymentController;

        #region Class Init

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            mockIAgentService = new Mock<IAgent>();
            mockIDepartmentService = new Mock<IDepartment>();
            mockIEmailNotificationService = new Mock<IEmailNotification>();
            mockIMembershipService = new Mock<IMembership>();
            mockIMembershipUpgradeService = new Mock<IMembershipUpgrade>();
            mockIOrderService = new Mock<IOrder>();
            mockIPackingSlipService = new Mock<IPackingSlip>();
            mockIPackingSlipRoyaltyDepService = new Mock<IPackingSlipRoyaltyDep>();
            mockIPaymentService = new Mock<IPayment>();
            mockIProductService = new Mock<IProduct>();
            mockIShippingService = new Mock<IShipping>();
            mockIUserService = new Mock<IUser>();
            mockIVideoSubscriptionService = new Mock<IVideoSubscription>();

            paymentController = new PaymentController(
                mockIAgentService.Object,
                mockIDepartmentService.Object,
                mockIEmailNotificationService.Object,
                mockIMembershipService.Object,
                mockIMembershipUpgradeService.Object,
                mockIOrderService.Object,
                mockIPackingSlipService.Object,
                mockIPackingSlipRoyaltyDepService.Object,
                mockIPaymentService.Object,
                mockIProductService.Object,
                mockIShippingService.Object,
                mockIUserService.Object,
                mockIVideoSubscriptionService.Object
                );

        }

        #endregion

        #region Test Init
        [TestInitialize()]
        public void Initialize()
        {

        }
        #endregion

        #region Test Methods
        [TestMethod()]
        public void Payment_ProcessPayment()
        {
            // Arrange
            PaymentDTO payment = TestData.TestData.GetMockPaymentData();
            mockIPaymentService.Setup(x => x.ProcessPayment(It.IsAny<PaymentDTO>())).Returns(true);
            mockIPackingSlipService.Setup(x => x.GeneratePackingSlip()).Returns(11);
            mockIPackingSlipRoyaltyDepService.Setup(x => x.CopyOriginalPackingSlipNumberForRoyDep(It.IsAny<int>()));
            mockIAgentService.Setup(x => x.DoAgentCommissonPayment(It.IsAny<PaymentDTO>()));
            mockIMembershipService.Setup(x => x.ActivateMembership(It.IsAny<UserDTO>()));
                // For Upgrade memebership
            mockIMembershipUpgradeService.Setup(x => x.UpgradeMembership(It.IsAny<UserDTO>()));
            mockIVideoSubscriptionService.Setup(x => x.CheckUserVideoSubscriptionPlans(It.IsAny<string>()));
            mockIShippingService.Setup(x => x.SaveShippingDetails(It.IsAny<PackingSlipDTO>()));
            mockIEmailNotificationService.Setup(x => x.SendEmailNotification());

            // Act
            IHttpActionResult actionResult = paymentController.ProcessPayment(payment);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkResult));
        }

        [TestMethod()]
        public void Payment_ProcessPayment_BadRequest()
        {
            // Arrange
            PaymentDTO payment = TestData.TestData.GetMockPaymentData();
            mockIPaymentService.Setup(x => x.ProcessPayment(It.IsAny<PaymentDTO>())).Returns(true);

            // Act
            IHttpActionResult actionResult = paymentController.ProcessPayment(payment);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(BadRequestResult));

        }

        [TestMethod()]
        public void Payment_ProcessPayment_InternalServerError()
        {
            // Arrange
            PaymentDTO payment = null;
            mockIPaymentService.Setup(x => x.ProcessPayment(It.IsAny<PaymentDTO>())).Returns(false);

            // Act
            IHttpActionResult actionResult = paymentController.ProcessPayment(payment);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(InternalServerErrorResult));

        }
        #endregion

    }
}
