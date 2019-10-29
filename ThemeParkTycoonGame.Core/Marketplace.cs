using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Marketplace
    {
        private static Marketplace instance;

        private List<Ride> purchasableRides;
        private List<Ride> purchasedRides;
        private List<Shop> purchasableShops;
        private List<Shop> purchasedShops;

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
            purchasableRides = Rides.All;
            purchasedRides = new List<Ride>();

            // Configure shops that are available here
            purchasableShops = new List<Shop>()
            {

            };
            purchasedShops = new List<Shop>();
        }

        public void Buy(BuildableObject rideOrShop, Wallet fromWallet, Inventory toInventory)
        {
            if (fromWallet.Balance < rideOrShop.Cost)
            {
                throw new ArgumentException("Wallet does not have enough money! Check balance in the UI before calling this method.");
            }

            if (toInventory.Contains(rideOrShop))
            {
                throw new ArgumentException("Inventory already contains this item! Check if player owns the item before calling this method.");
            }

            if(rideOrShop is Ride)
            {
                Ride ride = rideOrShop as Ride;

                toInventory.Rides.Add(ride);
                purchasedRides.Add(ride);
            }
            else if(rideOrShop is Shop)
            {
                Shop shop = rideOrShop as Shop;

                toInventory.Shops.Add(shop);
                purchasedShops.Add(shop);
            }

            // Always deduct the money
            fromWallet.Balance -= rideOrShop.Cost;
        }

        // Takes the current inventory, so already purchased rides can be hidden
        public List<Ride> GetBuyableRides(Inventory currentInventory)
        {
            List<Ride> buyableRides = new List<Ride>();

            foreach (Ride item in purchasableRides)
            {
                // If the player already has the item
                if (currentInventory.Contains(item))
                    continue;

                // If the item has already been purchased
                if (purchasedRides.Contains(item))
                    continue;

                buyableRides.Add(item);
            }

            return buyableRides;
        }

        // Takes the current inventory, so already purchased rides can be hidden
        public List<Shop> GetBuyableShops(Inventory currentInventory)
        {
            List<Shop> buyableShops = new List<Shop>();

            foreach (Shop item in purchasableShops)
            {
                // If the player already has the item
                if (currentInventory.Contains(item))
                    continue;

                // If the item has already been purchased
                if (purchasedShops.Contains(item))
                    continue;

                buyableShops.Add(item);
            }

            return buyableShops;
        }
    }
}
