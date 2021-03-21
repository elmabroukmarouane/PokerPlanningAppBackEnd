using Infrastructure.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Classes
{
    public class Duration : Entity
    {
        public int duration { get; set; }
    }
}
