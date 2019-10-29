using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Forms
{
    public class Inventory
    {
        public delegate void InventoryChangedEvent(object sender, InventoryChangedEventArgs e);
        public event InventoryChangedEvent InventoryChanged;

        // Returns a list with both shops and rides
        public List<BuildableObject> All
        {
            get
            {
                List<BuildableObject> all = new List<BuildableObject>();

                foreach (Shop item in Shops)
                    all.Add(item);

                foreach (Ride item in Rides)
                    all.Add(item);

                return all;
            }
        }

        public ObservableCollection<Shop> Shops;
        public ObservableCollection<Ride> Rides;

        public Inventory()
        {
            Shops = new ObservableCollection<Shop>();
            Rides = new ObservableCollection<Ride>();

            Shops.CollectionChanged += Object_CollectionChanged;
            Rides.CollectionChanged += Object_CollectionChanged;
        }

        public BuildableObject GetByName(string itemName)
        {
            foreach (Shop item in Shops)
                if (item.Name == itemName)
                    return item;

            foreach (Ride item in Rides)
                if (item.Name == itemName)
                    return item;

            return null;
        }

        private void Object_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (InventoryChanged != null)
            {
                InventoryChangedEventArgs eventArgs = new InventoryChangedEventArgs(this);

                InventoryChanged.Invoke(this, eventArgs);
            }
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

    public class InventoryChangedEventArgs : EventArgs
    {
        public Inventory Inventory;

        public InventoryChangedEventArgs(Inventory inventory)
        {
            this.Inventory = inventory;
        }
    }
}
