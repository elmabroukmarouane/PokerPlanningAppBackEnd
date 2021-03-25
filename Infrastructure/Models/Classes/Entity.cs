using Infrastructure.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Models.Classes
{
    public class Entity : IEntity
    {
        public int id { get; set; }
        public DateTime? createdate { get; set; }
        public DateTime? updatedate { get; set; }
        public string createdby { get; set; }
        public string updatedby { get; set; }
    }
}
