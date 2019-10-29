using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Forms
{
    public static class Rides
    {
        private static List<Ride> rides;

        private static void CreateIfNotExists()
        {
            if(rides != null)
                return;

            rides = new List<Ride>()
            {
                new Ride("Baron 1898", Properties.Resources.efteling_baron1898, 25000),
                new Ride("Goliath", Properties.Resources.walibi_goliath, 25000),
                new Ride("Python", Properties.Resources.efteling_python, 10000, new List<StatBoost>()
                {
                    new StatBoost()
                    {
                        StatType =  StatTypes.All[2]
                    }
                }),
                new Ride("Robin Hood", Properties.Resources.walibi_robin_hood, 15000),
                new Ride("Vogel Rok", Properties.Resources.efteling_vogelrok, 15000),
            };
        }

        public static List<Ride> All
        {
            get
            {
                CreateIfNotExists();

                return rides;
            }
        }
    }
}
