using System;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.PackingSlip;
using BusinessRulesEngine.Contracts.Services.Shipping;
using BusinessRulesEngine.DTO.PackingSlip;
using BusinessRulesEngine.Services.PackingSlip;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BusinessRulesEngine.Tests.Services
{
    [TestClass()]
    public class PackingSlipServicesTests
    {
        public static Mock<IShipping> mockIShippingService;
        public static Mock<IPackingSlipRepo> mockIPackingSlipRepo;

        public static IPackingSlip packingSlipService;

        #region Class Init

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            mockIShippingService = new Mock<IShipping>();
            mockIPackingSlipRepo = new Mock<IPackingSlipRepo>();

            packingSlipService = new PackingSlipService(
                mockIShippingService.Object,
                mockIPackingSlipRepo.Object
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
        public void AddVideoToPackingSlip()
        {
            // Arrange
            PackingSlipDTO packingSlip = new PackingSlipDTO();
            packingSlip.PackingSlipDetails = "Learning to Ski";
            mockIShippingService.Setup(x => x.SaveShippingDetails(It.IsAny<PackingSlipDTO>()));

            // Act
            packingSlipService.AddVideoToPackingSlip("Learning to Ski");

            // Assert
            mockIShippingService.Verify();
        }
    }
}
