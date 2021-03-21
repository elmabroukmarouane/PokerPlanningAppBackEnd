using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.DtoModel.Models
{
    public class RoleViewModel : Entity
    {
        public Roles role { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public ICollection<UserViewModel> users { get; set; }
    }
}
