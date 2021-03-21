using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.DtoModel.Models
{
    public class PersonViewModel : Entity
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime birthdate { get; set;}
        public virtual Group group { get; set; }
        public virtual ICollection<User> users { get; set; }
    }
}
