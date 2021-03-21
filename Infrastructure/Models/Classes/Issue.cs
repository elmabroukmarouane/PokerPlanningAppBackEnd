using Infrastructure.Models.Interfaces;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Classes
{
    public class Issue : Entity
    {
        public string number { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string assignedto { get; set; }
        public int weight { get; set; }
    }
}
