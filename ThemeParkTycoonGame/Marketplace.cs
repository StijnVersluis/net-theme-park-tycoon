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

        private List<Ride> purchasableRides;
        private List<Shop> purchasableShops;

        // Marketplace is a singleton, this is the way to get an instance
        public static Marketplace Instance
        {
            get
            {
                // Make an instance only once
                if (instance == null)
                    instance = new Marketplace();

                // Then always return that instance
                return instance;
            }
        }

        // Marketplace is a singleton. This constructor is therefor private (so only GetInstance can make an instance)
        private Marketplace()
        {
            // Configure the rides that are available here
            purchasableRides = new List<Ride>()
            {
                new Ride("Baron 1898", Properties.Resources.efteling_baron1898, 25000),
                new Ride("Goliath", Properties.Resources.walibi_goliath, 25000),
                new Ride("Python", Properties.Resources.efteling_python, 10000),
                new Ride("Robin Hood", Properties.Resources.walibi_robin_hood, 15000),
                new Ride("Vogel Rok", Properties.Resources.efteling_vogelrok, 15000),
            };

            // Configure shops that are available here
            purchasableShops = new List<Shop>()
            {

            };
        }

        // Takes the current inventory, so already purchased rides can be hidden
        internal List<Ride> GetBuyableRides(Inventory currentInventory)
        {
            List<Ride> buyableRides = new List<Ride>();

            foreach (Ride item in purchasableRides)
            {
                if (!currentInventory.Contains(item))
                {
                    buyableRides.Add(item);
                }
            }

            return buyableRides;
        }

        // Takes the current inventory, so already purchased rides can be hidden
        internal List<Shop> GetBuyableShops(Inventory currentInventory)
        {
            List<Shop> buyableShops = new List<Shop>();

            foreach (Shop item in purchasableShops)
            {
                if (!currentInventory.Contains(item))
                {
                    buyableShops.Add(item);
                }
            }

            return buyableShops;
        }
    }
}
