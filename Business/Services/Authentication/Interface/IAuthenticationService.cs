using Infrastructure.Models.Classes;
using Infrastructure.Models.MapObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Authentication.Interface
{
    public interface IAuthenticationService
    {
        Task<User> Authenticate(UserLogin UserLogin);
        string CreateToken(User user, string keyString, string issuerString, string audienceString);
    }
}
