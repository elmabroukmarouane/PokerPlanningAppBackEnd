﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.SendEmails.Models.Classes
{
    public class EmailMessage
    {
        public List<EmailAddress> ToAddresses { get; set; }
        public List<EmailAddress> FromAddresses { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}
