using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.DtoModel.Models
{
    public class IssueViewModel : Entity
    {
        public string number { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string assignedto { get; set; }
        public int weight { get; set; }
    }
}
