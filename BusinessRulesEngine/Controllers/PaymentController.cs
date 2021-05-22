using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessRulesEngine.Contracts;
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
using BusinessRulesEngine.Services;

namespace BusinessRulesEngine.Controllers
{
    // Controller class for Payment
    [RoutePrefix("api/payment")]
    public class PaymentController : ApiController
    {
        private readonly IAgent _agent;
        private readonly IDepartment _department;
        private readonly IEmailNotification _emailNotification;
        private readonly IMembership _membership;

        private readonly IMembershipUpgrade _membershipUpgrade;
        private readonly IOrder _order;
        private readonly IPackingSlip _packingSlip;
        private readonly IPackingSlipRoyaltyDep _packingSlipRoyaltyDep;

        private readonly IPayment _payment;
        private readonly IProduct _product;
        private readonly IShipping _shipping;
        private readonly IUser _user;
        private readonly IVideoSubscription _videoSubscription;

        /// <summary>
        /// Controller to Inject Dependecies
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="department"></param>
        /// <param name="emailNotification"></param>
        /// <param name="membership"></param>
        /// <param name="membershipUpgrade"></param>
        /// <param name="order"></param>
        /// <param name="packingSlip"></param>
        /// <param name="packingSlipRoyaltyDep"></param>
        /// <param name="payment"></param>
        /// <param name="product"></param>
        /// <param name="shipping"></param>
        /// <param name="user"></param>
        /// <param name="videoSubscription"></param>
        public PaymentController(IAgent agent, IDepartment department, IEmailNotification emailNotification,
            IMembership membership, IMembershipUpgrade membershipUpgrade, IOrder order, IPackingSlip packingSlip,
            IPackingSlipRoyaltyDep packingSlipRoyaltyDep, IPayment payment, IProduct product, IShipping shipping,
            IUser user, IVideoSubscription videoSubscription)
        {
            _agent = agent;
            _department = department;
            _emailNotification = emailNotification;
            _membership = membership;
            _membershipUpgrade = membershipUpgrade;
            _order = order;
            _packingSlip = packingSlip;
            _packingSlipRoyaltyDep = packingSlipRoyaltyDep;
            _payment = payment;
            _product = product;
            _shipping = shipping;
            _user = user;
            _videoSubscription = videoSubscription;
        }

        #region Action Methods

        #endregion
    }
}
