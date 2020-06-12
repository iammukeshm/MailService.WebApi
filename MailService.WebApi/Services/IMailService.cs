using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailService.WebApi.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(string toEmail, string subject, string body);


    }
}
