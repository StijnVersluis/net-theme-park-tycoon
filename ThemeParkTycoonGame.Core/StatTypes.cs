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
                new StatType("Maintenance Required", null, GameObjectType.BuildableObject, 0, 1),
                new StatType("Waiting Time", 0, GameObjectType.BuildableObject),
                new StatType("Entertained", null, GameObjectType.Guest, 0, 40),
                new StatType("Hunger", null, GameObjectType.Guest, 0, 20),
                new StatType("Thirst", null, GameObjectType.Guest, 0, 20),
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

        public static List<StatType> GetByTarget(GameObjectType target)
        {
            return All.Where(st => st.Target == target).ToList();
        }
    }
}
