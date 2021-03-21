using Infrastructure.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Classes
{
    public class Group : Entity
    {
        public string groupname { get; set; }
        public virtual ICollection<Person> persons { get; set; }
    }
}
