using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public static class StatTypes
    {
        private static List<StatType> stats;

        private static void CreateIfNotExists()
        {
            if(stats != null)
                return;

            stats = new List<StatType>()
            {
                new StatType("ride_maintenance", "Maintenance Required", null, GameObjectType.BuildableObject, 0, 1),
                new StatType("ride_wait_time", "Waiting Time", 0, GameObjectType.BuildableObject),
                new StatType("want_for_ride", "Wanting to go on a ride", null, GameObjectType.Guest, 0, 100),
                new StatType("enthousiasm", "Enthousiasm", null, GameObjectType.Guest, 0, 40),
                new StatType("hunger", "Hunger", null, GameObjectType.Guest, 0, 20),
                new StatType("thirst", "Thirst", null, GameObjectType.Guest, 0, 20),
            };
        }

        public static List<StatType> All
        {
            get
            {
                CreateIfNotExists();

                return stats;
            }
        }

        public static List<StatType> FindByTarget(GameObjectType target)
        {
            return All.Where(st => st.Target == target).ToList();
        }

        public static StatType GetByUniqueId(string uniqueId)
        {
            return All.Where(st => st.UniqueId == uniqueId).First();
        }
    }
}
