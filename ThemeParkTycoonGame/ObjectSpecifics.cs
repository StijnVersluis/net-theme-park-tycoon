using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame
{
    public static class ObjectSpecifics
    {
        private static List<ObjectSpecific> objectSpecifics;

        private static void CreateIfNotExists()
        {
            if(objectSpecifics != null)
                return;

            objectSpecifics = new List<ObjectSpecific>()
            {
                new ObjectSpecific()
                {
                    Name = "14down",
                    Category = ObjectSpecific.Types.Drink,
                    StatisticBoosts = new List<StatBoost>()
                    {
                        new StatBoost()
                        {
                            BoostMultiplier = 1.5f,
                            StatType = StatTypes.All[3], // TODO: No, get an identifier or something
                        }
                    }
                }
            };
        }

        public static List<ObjectSpecific> All
        {
            get
            {
                CreateIfNotExists();

                return objectSpecifics;
            }
        }
    }
}
