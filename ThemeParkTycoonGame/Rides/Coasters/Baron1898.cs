using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Rides.Coasters
{
    public class Baron1898 : Ride
    {
        public override List<Stat> StatisticBoosts
        {
            get
            {
                return new List<Stat>()
                {
                    // TODO: Have stat-boosts for guests so they want to spend more money or something
                };
            }
        }
        public override string Name => "Baron 1898";
        public override Image Image => Properties.Resources.efteling_baron1898;
        public override decimal Cost => 25000;
    }
}
