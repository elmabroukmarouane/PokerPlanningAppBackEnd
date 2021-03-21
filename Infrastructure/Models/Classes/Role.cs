using Infrastructure.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Classes
{
    public enum Roles
    {
        SUPER_ADMIN = 1,
        ADMIN,
        USER
    }
    public class Role : Entity
    {
        public Roles role { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public virtual ICollection<User> users { get; set; }
    }
}
