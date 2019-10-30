using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Shop : BuildableObject, IDesirable
    {
        public string[] DesireReasons;
        public List<Product> ProductsForSale { get; }

        public Shop()
            : base()
        {
            DesireReasons = new string[]
            {
                "{0} looks nice",
                "I think I'll have lunch at {0}",
            };
        }

        public string GetRandomDesireReason()
        {
            int amountDesireReasons = DesireReasons.Length;

            if (amountDesireReasons == 0)
                return null;

            var randomIndex = NumberGenerator.Next(amountDesireReasons);
            return DesireReasons[randomIndex];
        }
    }
}
