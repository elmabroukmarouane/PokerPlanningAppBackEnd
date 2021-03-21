using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.MapObjects
{
    public class LoggedUser
    {
        public string Message { get; set; }
        public User User { get; set; }
        public string Token { get; set; }
    }
}
