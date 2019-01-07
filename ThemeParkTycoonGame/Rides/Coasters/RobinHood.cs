using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Rides.Coasters
{
    public class Goliath : Ride
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
        public override string Name => "Goliath";
        public override Image Image => Properties.Resources.walibi_goliath;
        public override decimal Cost => 25000;
    }
}
