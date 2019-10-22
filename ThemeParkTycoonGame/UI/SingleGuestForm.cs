using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeParkTycoonGame.UI.Controls;

namespace ThemeParkTycoonGame.UI
{
    public partial class SingleGuestForm : Form, IPositionSelf
    {
        Guest guest;

        public SingleGuestForm(Guest guest)
        {
            InitializeComponent();

            this.guest = guest;

            guest.ActionChanged += (s, ev) =>
            {
                RefreshDesires();
            };

            // Set the title to this guests name
            this.Text = string.Format("{0} (Entered park @ {1})", guest.Name, guest.TimeEntered);

            //MessageBox.Show("TODO: The ride history is to be shown here.", "Under construction!");
            //RefreshRideHistory();
            RefreshDesires();
            RefreshStats();
        }

        private void RefreshDesires()
        {
            if (desiresPanel.InvokeRequired)
                return;

            // clear the panel
            desiresPanel.Controls.Clear();

            int numDesires = 0;

            foreach (Desire desire in this.guest.Desires)
            {
                DesireLabel label = new DesireLabel(desire);
                label.Top = numDesires++ * label.Height;

                desiresPanel.Controls.Add(label);
            }
        }

        private void RefreshStats()
        {
            // clear the panel
            statsPanel.Controls.Clear();

            int numSliders = 0;

            foreach (Stat stat in this.guest.CurrentStats)
            {
                StatSlider slider = new StatSlider(stat);
                slider.Top = numSliders++ * slider.Height;

                statsPanel.Controls.Add(slider);
            }
        }

        void IPositionSelf.LoadPosition(int maxX, int maxY)
        {
            this.Left = (int)(maxX * .5);
            this.Top = (int)(maxY * .5);
        }

        bool IPositionSelf.PositionChallenged(int maxX, int maxY, Form challengingForm)
        {
            throw new NotImplementedException();
        }
    }
}
