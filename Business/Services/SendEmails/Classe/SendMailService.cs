using Business.Services.SendEmails.Interface;
using Business.Services.SendEmails.Models.Classes;
using Business.Services.SendEmails.Models.Interfaces;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.SendEmails.Classe
{
    public class SendMailService : ISendMailService
    {
		private readonly ISmtpClient _smtpClient;
        public SendMailService(ISmtpClient smtpClient)
		{
			_smtpClient = smtpClient;
        }
        public async Task Send(EmailMessage emailMessage, EmailConfiguration emailConfiguration)
        {
			var message = new MimeMessage();
			message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
			message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
			message.Subject = emailMessage.Subject;
			message.Body = new TextPart(TextFormat.Html)
			{
				Text = emailMessage.Content
			};
			_smtpClient.ServerCertificateValidationCallback = (s, c, h, e) => true;
			await _smtpClient.ConnectAsync(emailConfiguration.SmtpServer, emailConfiguration.SmtpPort, SecureSocketOptions.Auto);
			await _smtpClient.AuthenticateAsync(emailConfiguration.SmtpUsername, emailConfiguration.SmtpPassword);
			await _smtpClient.SendAsync(message);
			await _smtpClient.DisconnectAsync(true);
		}
    }
}
