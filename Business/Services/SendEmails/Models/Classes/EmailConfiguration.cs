﻿using Business.Services.SendEmails.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.SendEmails.Models.Classes
{
	public class EmailConfiguration : IEmailConfiguration
	{
		public string SmtpServer { get; set; }
		public int SmtpPort { get; set; }
		public string SmtpUsername { get; set; }
		public string SmtpPassword { get; set; }
	}
}
