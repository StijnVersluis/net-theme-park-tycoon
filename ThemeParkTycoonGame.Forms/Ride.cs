using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Forms
{
    public class Ride : BuildableObject
    {
        public List<StatBoost> StatisticBoosts;

        public Ride()
        {
            // Default to free rides without a name or image, nor any statistic boosts
            Name = "Untitled Ride";
            Image = Properties.Resources.unavailable_481;
            Cost = 0;
            EntryFee = 0;
            StatisticBoosts = new List<StatBoost>();
        }

        public Ride(string name, System.Drawing.Image image, decimal cost, List<StatBoost> statBoosts = null)
            :this() // This causes the defaults in the default constructor to be set
        {
            Name = name;
            Image = image;
            Cost = cost;

            if(statBoosts != null)
                StatisticBoosts = statBoosts;
        }
    }
}
