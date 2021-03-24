using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.DtoModel.Models
{
    public class GroupViewModel : Entity
    {
        public string groupname { get; set; }
        public virtual ICollection<PersonViewModel> persons { get; set; }
    }
}
