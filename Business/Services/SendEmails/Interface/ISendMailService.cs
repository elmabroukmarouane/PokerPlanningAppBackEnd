using Business.Services.SendEmails.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.SendEmails.Interface
{
    public interface ISendMailService
    {
        Task Send(EmailMessage emailMessage, EmailConfiguration emailConfiguration);
    }
}
