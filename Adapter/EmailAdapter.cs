using System;

namespace Adapter
{
    public class EmailAdapter
    {
        private readonly EmailService _emailService;

        public EmailAdapter(EmailService emailService)
        {
            _emailService = emailService;
        }
        public void SendEmail(string message, string email)
        {
            _emailService.SendEmail(message, email);
        }
    }
}