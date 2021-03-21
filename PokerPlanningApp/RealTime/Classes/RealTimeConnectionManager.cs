using PokerPlanningApp.RealTime.Interfaces;
using Infrastructure.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokerPlanningApp.RealTime.Classes
{
    public class RealTimeConnectionManager<TEntity> : IRealTimeConnectionManager<TEntity> where TEntity : Entity
    {
        private static IDictionary<TEntity, HashSet<string>> entityMap = new Dictionary<TEntity, HashSet<string>>();
        public ICollection<TEntity> ListOnlineUsers
        {
            get
            {
                return entityMap.Keys;
            }
        }

        public void AddConnection(TEntity entity, string connectionId)
        {
            lock(entityMap)
            {
                if(!entityMap.ContainsKey(entity))
                {
                    entityMap[entity] = new HashSet<string>();
                }
                entityMap[entity].Add(connectionId);
            }
        }

        public HashSet<string> GetConnections(TEntity entity)
        {
            var connection = new HashSet<string>();
            try
            {
                lock (entityMap)
                {
                    connection = entityMap[entity];
                }
            }
            catch
            {
                connection = null;
            }
            return connection;
        }

        public void RemoveConnection(string connectionId)
        {
            lock (entityMap)
            {
                foreach(var entity in entityMap.Keys)
                {
                    if(entityMap.ContainsKey(entity))
                    {
                        if (entityMap[entity].Contains(connectionId))
                        {
                            entityMap[entity].Remove(connectionId);
                            break;
                        }
                    }
                }
            }
        }
    }
}
