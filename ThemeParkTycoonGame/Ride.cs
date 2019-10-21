using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame
{
    public class Ride : BuildableObject
    {
        public List<Stat> StatisticBoosts;

        public Ride()
        {
            // Default to free rides without a name or image, nor any statistic boosts
            Name = "Untitled Ride";
            Image = Properties.Resources.unavailable_481;
            Cost = 0;
            EntryFee = 0;
            StatisticBoosts = new List<Stat>();
        }

        public Ride(string name, System.Drawing.Image image, decimal cost)
            :this() // This causes the defaults in the default constructor to be set
        {
            Name = name;
            Image = image;
            Cost = cost;
        }
    }
}
