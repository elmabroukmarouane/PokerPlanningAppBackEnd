using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.RealTime.Hubs.Interface
{
    public interface IRealTimeHub
    {
        Task SendToAll(object[] entities);
        Task SendToSpecifiOnes(object[] entities, IList<string> specificUsersIds);
        IList<string> GetConnectedUsersList();

    }
}
