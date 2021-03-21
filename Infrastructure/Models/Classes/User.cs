using Infrastructure.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Classes
{
    public class User : Entity
    {
        public int roleid { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public virtual Role role { get; set; }
    }
}
