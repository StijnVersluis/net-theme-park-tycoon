using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThemeParkTycoonGame.UI
{
    public partial class DebugForm : Form
    {
        private Park park;

        public DebugForm(Park park)
        {
            InitializeComponent();

            this.park = park;
        }

        private void addGuestButton_Click(object sender, EventArgs e)
        {
            this.park.AddGuest(new Guest());
        }

        private void changeWeatherButton_Click(object sender, EventArgs e)
        {
            this.park.DoChangeWeather();
        }

        private void generateMoneyButton_Click(object sender, EventArgs e)
        {
            this.park.ParkWallet.Balance += 1000;
        }
    }
}
