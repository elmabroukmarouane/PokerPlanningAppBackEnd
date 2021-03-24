using Business.Services.Authentication.Interface;
using Business.Services.Queries.Interfaces;
using Infrastructure.Models.Classes;
using Infrastructure.Models.DatabaseContext;
using Infrastructure.Models.MapObjects;
using Infrastructure.Models.SeedData.Classes;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.UnitOfWork.Interface;

namespace Business.Services.Authentication.Classe
{
    public class AuthenticationService : IAuthenticationService
    {
        #region ATTRIBUTE
        private readonly IGenericQueryService<User> _genericQueryService;
        #endregion

        #region CONTRUCTOR
        public AuthenticationService(IGenericQueryService<User> genericQueryService)
        {
            _genericQueryService = genericQueryService;
        }
        #endregion

        #region METHODS
        public async Task<User> Authenticate(UserLogin UserLogin)
        {
            if (string.IsNullOrEmpty(UserLogin.Email) || string.IsNullOrEmpty(UserLogin.Password))
                return null;
            var AttempingUser = await _genericQueryService.GetFirstOrDefaultTEntity(
                predicate: u => u.email.Trim().ToLower().Equals(UserLogin.Email.Trim().ToLower()),
                includes: "role,person");
            if (AttempingUser == null)
            {
                return null;
            }
            var passwordHash = UserSeed.CreateHashPassword(UserLogin.Password.Trim());
            var passwordAuth = AttempingUser.password;
            if (!passwordAuth.Equals(passwordHash))
            {
                return null;
            }
            return AttempingUser;
        }

        public string CreateToken(User user, string keyString, string issuerString, string audienceString)
        {
            var claims = new[] {
                //new Claim(JwtRegisteredClaimNames.GivenName, user.customer.firstname + " " + user.customer.lastname),
                new Claim(JwtRegisteredClaimNames.GivenName, user.email),
                new Claim(JwtRegisteredClaimNames.Email, user.email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };
            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(keyString));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512);

            var token = new JwtSecurityToken(
                issuer: issuerString,
                audience: audienceString,
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion
    }
}
