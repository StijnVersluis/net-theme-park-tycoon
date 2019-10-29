using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Forms.UI
{
    public partial class DebugForm : Form, IPositionSelf
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
    
        // Should position this form. Occurs right after showing the form
        void IPositionSelf.LoadPosition(int maxX, int maxY)
        {
            this.Left = maxX;
            this.Top = maxY;
        }

        // Should position this form and return true (self moved). Or should return false (other form should move)
        bool IPositionSelf.PositionChallenged(int maxX, int maxY, Form challengingForm)
        {
            throw new NotImplementedException();
        }
    }
}
