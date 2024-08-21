using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Email
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Models.Email.SendEmailRequest sendEmailRequest);
    }
}
