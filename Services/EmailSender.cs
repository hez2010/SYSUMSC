﻿using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace FreshBoard.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
        Task SendNotificationAsync(string email, string title);
        Task SendStatusChangeAsync(string email, string changeDescription);
        Task SendStatusChangeAsync(string email, string periodA, string periodB);
        Task SendStatusChangeAsync(string email, bool status, string period);
    }

    public class EmailSender : IEmailSender
    {
        private readonly EmailOptions _config;

        public EmailSender(IOptionsMonitor<EmailOptions> _accessor)
        {
            _config = _accessor.CurrentValue;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var msg = new MailMessage
            {
                From = new MailAddress(_config.FromAddress, _config.FromName, Encoding.UTF8),
                Subject = subject,
                SubjectEncoding = Encoding.UTF8,
                Body = message.Replace("http://localhost:5000", "https://sysumsc.com")
                    .Replace("https://localhost:5001", "https://sysumsc.com"),
                BodyEncoding = Encoding.UTF8,
                IsBodyHtml = true
            };
            msg.To.Add(new MailAddress(email));

            using var smtp = new SmtpClient
            {
                Host = _config.HostName,
                Port = _config.Port,
                Credentials =
                    new NetworkCredential(_config.UserName, _config.Password)
            };

            await smtp.SendMailAsync(msg);
        }

        public async Task SendNotificationAsync(string email, string title)
        {
            throw new NotImplementedException();
        }

        public async Task SendStatusChangeAsync(string email, string changeDescription)
        {
            throw new NotImplementedException();
        }

        public async Task SendStatusChangeAsync(string email, string periodA, string periodB)
        {
            throw new NotImplementedException();
        }

        public async Task SendStatusChangeAsync(string email, bool status, string period)
        {
            throw new NotImplementedException();
        }
    }
}
