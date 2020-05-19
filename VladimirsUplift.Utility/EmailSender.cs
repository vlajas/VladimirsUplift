using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VladimirsUplift.Utility
{
    public class EmailSender : IEmailSender
    {
        public EmailOptions Options { get; set; }
       

        public EmailSender(IOptions<EmailOptions> emailOptions)
        {
            Options = emailOptions.Value;
        }

        public Task SendEmailAsync(string email, string subject, string message)
        {
             return Execute(Options.DeniKey, subject, message, email);            

        }

        private Task Execute(string sendGridKey, string subject, string message, string email)
        {
           // var apiKey = Environment.GetEnvironmentVariable("DENIKEY");
            var client = new SendGridClient(sendGridKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("vladimir.stojanovic995@gmail.com", "VladimirsUplift"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };
            msg.AddTo(new EmailAddress(email, "Spice"));
            try
            {
                return client.SendEmailAsync(msg);
            }
            catch (Exception ex)
            {

            }
            return null;
        }



    }
}
