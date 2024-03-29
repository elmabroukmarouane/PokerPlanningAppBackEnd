﻿using Infrastructure.Models.DatabaseContext;
using Business.Services.Queries.Interfaces;
using Business.Services.Queries.Classes;
using Business.Services.Commands.Interfaces;
using Business.Services.Commands.Classes;
using Business.Services.Authentication.Interface;
using Business.Services.Authentication.Classe;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using UnitOfWork.UnitOfWork.Classe;
using UnitOfWork.UnitOfWork.Interface;
using Infrastructure.Models.Classes;
using Business.Services.SendEmails.Models.Interfaces;
using Microsoft.Extensions.Configuration;
using Business.Services.SendEmails.Interface;
using Business.Services.SendEmails.Classe;
using Business.Services.SendEmails.Models.Classes;
using MailKit.Net.Smtp;
using PokerPlanningApp.RealTime.Interfaces;
using PokerPlanningApp.RealTime.Classes;
using PokerPlanningApp.RealTime.Hubs.Classe;
using PokerPlanningApp.RealTime.Hubs.Interface;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;

namespace PokerPlanningApp.Extensions.Add
{
    public static class AddServices
    {
        public static void AddSERVICES(this IServiceCollection self, IConfiguration configuration, IHostEnvironment hostEnvironment)
        {
            self.AddTransient<IUnitOfWork<DatabaseContext>, UnitOfWork<DatabaseContext>>();

            self.AddTransient<IGenericQueryService<Role>, GenericQueryService<Role>>();
            self.AddTransient<IGenericCommandService<Role>, GenericCommandService<Role>>();
            self.AddTransient<IGenericQueryService<Group>, GenericQueryService<Group>>();
            self.AddTransient<IGenericCommandService<Group>, GenericCommandService<Group>>();
            self.AddTransient<IGenericQueryService<Person>, GenericQueryService<Person>>();
            self.AddTransient<IGenericCommandService<Person>, GenericCommandService<Person>>();
            self.AddTransient<IGenericQueryService<User>, GenericQueryService<User>>();
            self.AddTransient<IGenericCommandService<User>, GenericCommandService<User>>();
            self.AddTransient<IGenericQueryService<Duration>, GenericQueryService<Duration>>();
            self.AddTransient<IGenericCommandService<Duration>, GenericCommandService<Duration>>();
            self.AddTransient<IGenericQueryService<Issue>, GenericQueryService<Issue>>();
            self.AddTransient<IGenericCommandService<Issue>, GenericCommandService<Issue>>();

            self.AddTransient<IAuthenticationService, AuthenticationService>();

            self.AddTransient<ISendMailService, SendMailService>();
            self.AddTransient<ISmtpClient, SmtpClient>();

            self.AddTransient<IRealTimeHub, RealTimeHub>();

            self.AddSingleton(configuration);
            self.AddSingleton(hostEnvironment);
        }
    }
}
