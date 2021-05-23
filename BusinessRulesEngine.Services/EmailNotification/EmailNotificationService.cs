using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessRulesEngine.Contracts.Repo;
using BusinessRulesEngine.Contracts.Services.EmailNotification;

namespace BusinessRulesEngine.Services.EmailNotification
{
    public class EmailNotificationService : IEmailNotification
    {
        private readonly IEmailNotificationRepo _emailNotificationRepo;
        public EmailNotificationService(IEmailNotificationRepo emailNotificationRepo)
        {
            _emailNotificationRepo = emailNotificationRepo;
        }
        public void SendEmailNotification()
        {
            throw new NotImplementedException();
        }
    }
}
