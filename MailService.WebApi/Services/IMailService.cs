using MailService.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailService.WebApi.Services
{
public interface IMailService
{
    Task SendEmailAsync(MailRequest mailRequest);
    Task SendWelcomeEmailAsync(WelcomeRequest request);
}
}
