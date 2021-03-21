using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Services.Commands.Interfaces;
using Business.Services.Queries.Interfaces;
using PokerPlanningApp.DtoModel.Models;
using PokerPlanningApp.GenericController;
using PokerPlanningApp.RealTime.Hubs.Interface;
using Infrastructure.Models.Classes;
using Infrastructure.Models.MapObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;

namespace PokerPlanningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : GenericController<User, UserViewModel>
    {
        public UserController(
            IGenericQueryService<User> genericQueryServic,
            IGenericCommandService<User> genericCommandService,
            IMapper mapper,
            IRealTimeHub realTimeHub,
            ILogger<GenericController<User, UserViewModel>> logger,
            IHostEnvironment currentEnvironment) : base(genericQueryServic, genericCommandService, mapper, realTimeHub, logger, currentEnvironment) { }
    }
}