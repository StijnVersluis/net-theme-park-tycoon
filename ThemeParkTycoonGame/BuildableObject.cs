using System.Drawing;

namespace ThemeParkTycoonGame
{
    public abstract class BuildableObject
    {
        public abstract string Name { get; }
        public abstract Image Image { get; }
        public decimal EntryFee { get; set; }
        public decimal Cost { get; }
    }
}