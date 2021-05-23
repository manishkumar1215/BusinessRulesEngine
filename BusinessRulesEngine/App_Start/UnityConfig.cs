using BusinessRulesEngine.Contracts.Services.Agent;
using BusinessRulesEngine.Services.Agent;
using BusinessRulesEngine.Contracts.Services.Membership;
using BusinessRulesEngine.Services.Membership;
using BusinessRulesEngine.Contracts.Services.Order;
using BusinessRulesEngine.Services.Order;
using BusinessRulesEngine.Contracts.Services.Payment;
using BusinessRulesEngine.Services.Payment;
using BusinessRulesEngine.Contracts.Services.Product;
using BusinessRulesEngine.Services.Product;
using BusinessRulesEngine.Contracts.Services.User;
using BusinessRulesEngine.Services.User;
using BusinessRulesEngine.Contracts.Services.VideoSubsciption;
using BusinessRulesEngine.Services.VideoSubscription;
using BusinessRulesEngine.Contracts.Services.PackingSlip;
using BusinessRulesEngine.Services.PackingSlip;
using BusinessRulesEngine.Contracts.Services.EmailNotification;
using BusinessRulesEngine.Services.EmailNotification;
using BusinessRulesEngine.Contracts.Services.Shipping;
using BusinessRulesEngine.Services.Shipping;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Repo;
using System.Web.Http;
using Unity;
using Unity.WebApi;
using BusinessRulesEngine.Contracts.Services.Department;
using BusinessRulesEngine.Services.Department;

namespace BusinessRulesEngine
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // Services Injection
            container.RegisterType<IAgent, AgentService>();
            container.RegisterType<IMembership, MembershipService>();
            container.RegisterType<IMembershipUpgrade, MembershipUpgradeService>();
            container.RegisterType<IOrder, OrderService>();
            container.RegisterType<IPayment, PaymentService>();
            container.RegisterType<IProduct, ProductService>();
            container.RegisterType<IUser, UserService>();
            container.RegisterType<IVideoSubscription, VideoSubscriptionService>();
            container.RegisterType<IPackingSlip, PackingSlipService>();
            container.RegisterType<IPackingSlipRoyaltyDep, PackingSlipRoyaltyDepService>();
            container.RegisterType<IEmailNotification, EmailNotificationService>();
            container.RegisterType<IShipping, ShippingService>();
            container.RegisterType<IDepartment, DepartmentServices>();

            // Repo Injection
            container.RegisterType<IAgentRepo, AgentRepo>();
            container.RegisterType<IMembershipRepo, MembershipRepo>();
            container.RegisterType<IMembershipUpgradeRepo, MembershipUpgradeRepo>();
            container.RegisterType<IOrderRepo, OrderRepo>();
            container.RegisterType<IPaymentRepo, PaymentRepo>();
            container.RegisterType<IProductRepo, ProductRepo>();
            container.RegisterType<IUserRepo, UserRepo>();
            container.RegisterType<IVideoSubscriptionRepo, VideoSubscriptionRepo>();
            container.RegisterType<IPackingSlipRepo, PackingSlipRepo>();
            container.RegisterType<IPackingSlipRoyaltyDepRepo, PackingSlipRoyaltyDepRepo>();
            container.RegisterType<IEmailNotificationRepo, EmailNotificationRepo>();
            container.RegisterType<IShippingRepo, ShippingRepo>();
            container.RegisterType<IDepartmentRepo, DepartmentRepo>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}