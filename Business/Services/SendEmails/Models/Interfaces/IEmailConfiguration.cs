﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services.SendEmails.Models.Interfaces
{
	public interface IEmailConfiguration
	{
		string SmtpServer { get; }
		int SmtpPort { get; }
		string SmtpUsername { get; set; }
		string SmtpPassword { get; set; }
	}
}
