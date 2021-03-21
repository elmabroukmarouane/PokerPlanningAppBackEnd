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
        public int roleid { get; set; }
        public string email { get; set; }
        public virtual RoleViewModel role { get; set; }
    }
}
