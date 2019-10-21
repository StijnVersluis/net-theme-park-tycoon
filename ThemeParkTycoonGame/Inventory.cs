using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame
{
    public class Inventory
    {
        public List<Shop> Shops;
        public List<Ride> Rides;

        public Inventory()
        {
            Shops = new List<Shop>();
            Rides = new List<Ride>();
        }

        // Checks whether we already have a ride
        public bool Contains(BuildableObject ride)
        {
            foreach (Ride inventoryRide in Rides)
            {
                if(ride == inventoryRide)
                {
                    return true;
                }
            }

            return false;
        }

        // Checks whether we already have a shop
        public bool Contains(Shop shop)
        {
            foreach (Shop inventoryShop in Shops)
            {
                if (shop == inventoryShop)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
