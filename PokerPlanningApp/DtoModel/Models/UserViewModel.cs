using PokerPlanningApp.DtoModel.Models;
using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.DtoModel.Models
{
    public class UserViewModel : Entity
    {
        public string email { get; set; }
        public string password { get; set; }
        public virtual Role role { get; set; }
        public virtual Person person { get; set; }
    }
}
