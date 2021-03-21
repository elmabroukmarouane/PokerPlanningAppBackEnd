using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.RealTime.Interfaces
{
    public interface IRealTimeConnectionManager<TEntity> where TEntity : Entity
    {
        void AddConnection(TEntity entity, string connectionId);
        void RemoveConnection(string connectionId);
        HashSet<string> GetConnections(TEntity entity);
        ICollection<TEntity> ListOnlineUsers { get; }
    }
}
