using System.Drawing;

namespace ThemeParkTycoonGame
{
    public abstract class BuildableObject
    {
        public abstract string Name { get; }
        public abstract Image Image { get; }
        public virtual decimal EntryFee { get; set; }
        public virtual decimal Cost { get; }
    }
}