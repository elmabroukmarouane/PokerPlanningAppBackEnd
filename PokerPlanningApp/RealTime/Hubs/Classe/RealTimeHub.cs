using PokerPlanningApp.RealTime.Hubs.Interface;
using PokerPlanningApp.RealTime.Interfaces;
using Infrastructure.Models.Classes;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.RealTime.Hubs.Classe
{
    public class RealTimeHub : Hub, IRealTimeHub
    {
        IHubContext<RealTimeHub> _hubContext;
        private IList<string> ConnectedUsers { get; set; }
        public RealTimeHub(
            IHubContext<RealTimeHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public override async Task OnConnectedAsync()
        {
            ConnectedUsers.Add(Context.ConnectionId);
            await base.OnConnectedAsync();
        }

        public IList<string> GetConnectedUsersList()
        {
            return ConnectedUsers;
        }

        public async Task SendToAll(object[] entities)
        {
            await _hubContext.Clients.All.SendCoreAsync("SendToAll", entities);
        }

        public async Task SendToSpecifiOnes(object[] entities, IList<string> specificUsersIds)
        {
            foreach (var userId in specificUsersIds)
            {
                await _hubContext.Clients.Client(userId).SendCoreAsync("SendToSpecifiOnes", entities);
            }
        }
    }
}
