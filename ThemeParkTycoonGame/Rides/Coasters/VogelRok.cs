using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Rides.Coasters
{
    public class VogelRok : Ride
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
        public override string Name => "Vogel Rok";
        public override Image Image => Properties.Resources.efteling_vogelrok;
        public override decimal Cost => 15000;
    }
}
