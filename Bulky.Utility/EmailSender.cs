

using Microsoft.AspNetCore.Identity;

namespace Bulky.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
        //logic to send email
        return Task.CompletedTask;
        }
    }
}
