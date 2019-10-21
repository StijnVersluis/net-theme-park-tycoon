using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame
{
    public class Marketplace
    {
        private static Marketplace instance;

        public List<Ride> AvailableRides;
        public List<Shop> AvailableShops;

        // Marketplace is a singleton. This constructor is therefor private (so only GetInstance can make an instance)
        private Marketplace()
        {
            // Configure the rides that are available here
            AvailableRides = new List<Ride>()
            {
                new Ride("Baron 1898", Properties.Resources.efteling_baron1898, 25000),
                new Ride("Goliath", Properties.Resources.walibi_goliath, 25000),
                new Ride("Python", Properties.Resources.efteling_python, 10000),
                new Ride("Robin Hood", Properties.Resources.walibi_robin_hood, 15000),
                new Ride("Vogel Rok", Properties.Resources.efteling_vogelrok, 15000),
            };

            // Configure shops that are available here
            AvailableShops = new List<Shop>()
            {

            };
        }

        // Marketplace is a singleton, this is the way to get an instance
        public static Marketplace GetInstance()
        {
            if (instance == null)
                instance = new Marketplace();

            return instance;
        }
    }
}
