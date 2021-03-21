using Infrastructure.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Classes
{
    public class Person : Entity
    {
        public int groupid { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime birthdate { get; set;}
        public virtual Group group { get; set; }
        public virtual ICollection<User> users { get; set; }
    }
}
