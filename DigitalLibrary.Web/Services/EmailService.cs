﻿namespace DigitalLibrary.Web.Services
{
    public class EmailService
    {
        public bool MailSent { get; set; }

        public void SendEmail() {
            // Logic.
            MailSent = true;
        }
    }
}
