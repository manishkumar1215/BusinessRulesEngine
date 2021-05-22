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
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace BusinessRulesEngine
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IAgent, AgentService>();
            container.RegisterType<IMembership, MembershipService>();
            container.RegisterType<IMembershipUpgrade, MembershipUpgradeService>();
            container.RegisterType<IOrder, OrderService>();
            container.RegisterType<IPayment, PaymentService>();
            container.RegisterType<IProduct, ProductService>();
            container.RegisterType<IUser, UserService>();
            container.RegisterType<IVideoSubscription, VideoSubscriptionService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}