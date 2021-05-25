using System;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.Agent;
using BusinessRulesEngine.Contracts.Services.Payment;
using BusinessRulesEngine.DTO.Payment;
using BusinessRulesEngine.Services.Agent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusinessRulesEngine.Tests.Services
{
    [TestClass]
    public class AgentServicesTests
    {
        public static Mock<IPayment> mockIPaymentService;
        public static Mock<IPaymentRepo> mockIPaymentRepo;

        public static IAgent agentService;

        #region Class Init

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            mockIPaymentService = new Mock<IPayment>();
            mockIPaymentRepo = new Mock<IPaymentRepo>();

            agentService = new AgentService(
                mockIPaymentService.Object,
                mockIPaymentRepo.Object
                );
        }
        #endregion

        #region Test Init
        [TestInitialize()]
        public void Initialize()
        {

        }
        #endregion

        [TestMethod()]
        public void DoAgentCommissonPayment()
        {
            // Arrange
            PaymentDTO payment = TestData.TestData.GetMockPaymentData();
            mockIPaymentService.Setup(x => x.ProcessPayment(It.IsAny<PaymentDTO>())).Returns(true);

            // Act
            agentService.DoAgentCommissonPayment(payment);

            // Assert ( we can write many assert statements based on scenerios)
            mockIPaymentService.Verify();
        }
    }
}
