using System.Drawing;

namespace ThemeParkTycoonGame.Core
{
    public abstract class BuildableObject : GameObject
    {
        public string Name;
        public Image Image;
        public decimal EntryFee;
        public decimal Cost;
    }
}