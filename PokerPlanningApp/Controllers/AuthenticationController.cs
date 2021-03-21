using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Services.Authentication.Interface;
using PokerPlanningApp.DtoModel.Models;
using Infrastructure.Models.MapObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace PokerPlanningApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AuthenticationController(
            IAuthenticationService authenticationService, 
            IConfiguration configuration,
            IMapper mapper)
        {
            _authenticationService = authenticationService;
            _configuration = configuration;
            _mapper = mapper;
        }

        [Route("Login")]
        [HttpPost]
        public async Task<IActionResult> Authenticate(UserLogin _user)
        {
            try
            {
                var user = await _authenticationService.Authenticate(_user);
                if (user == null)
                {
                    return StatusCode(401, new
                    {
                        Message = "Incorrect email or password"
                    });
                }
                var token = _authenticationService.CreateToken(
                    user,
                    _configuration.GetSection("Jwt").GetSection("Key").Value,
                    _configuration.GetSection("Jwt").GetSection("Issuer").Value,
                    _configuration.GetSection("Jwt").GetSection("Audience").Value);
                return Ok(new
                {
                    //Message = "Hi " + user.customer.firstname + " " + user.customer.lastname + " !",
                    Message = "Hi " + user.email + " !",
                    User = _mapper.Map<UserViewModel>(user),
                    Token = token,
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    Message = "Authentication failed !",
                    Exception = ex.Message,
                    ex.InnerException
                });
            }
        }
    }
}