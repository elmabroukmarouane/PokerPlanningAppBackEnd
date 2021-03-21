using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.Extensions.Use
{
    public static class UseOpenIdConnectAuthentication
    {
        public static void UseOpenIdConnectAuth(this IApplicationBuilder self)
        {
            self.UseAuthentication();
        }
    }
}
