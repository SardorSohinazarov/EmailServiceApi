using EmailService.Models;

namespace EmailService.Service.EmailServices
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
