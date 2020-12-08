using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;

namespace EmailService
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailConfiguration _emailConfig;
        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
        }

        public void SendEmail(Message message)
        {
            var emailMessage = CreateEmailMessage(message);
            Send(emailMessage);
        }

        private MimeMessage CreateEmailMessage(Message message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress(_emailConfig.From));
            emailMessage.To.AddRange(message.To);
            emailMessage.Subject = message.Subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Text) { Text = message.Content };
            return emailMessage;
        }
        private void Send(MimeMessage mailMessage)
        {
            using (var client = new SmtpClient())
            {
                try
                {
                    // client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                    // client.CheckCertificateRevocation = false;
                    // client.SslProtocols = SslProtocols.Tls11; // | SslProtocols.Tls12;
                    // client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, MailKit.Security.SecureSocketOptions.StartTls);
                    client.Connect(_emailConfig.SmtpServer, _emailConfig.Port, false);
                    // client.AuthenticationMechanisms.Remove("XOAUTH2");
                    // client.Authenticate(_emailConfig.Username, _emailConfig.Password);
                    client.Send(mailMessage);
                }
                catch
                {
                    //log an error message or throw an exception or both.
                    throw;
                }
                finally
                {
                    client.Disconnect(true);
                    client.Dispose();
                }
            }
        }
    }
}
