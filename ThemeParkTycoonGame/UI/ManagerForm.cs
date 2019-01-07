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
    public partial class ManagerForm : Form
    {
        const string PREFIX = "Theme Park Tycoon - ";

        private Park park;

        public ManagerForm()
        {
            InitializeComponent();

            park = new Park();

            // Hook to the park namechange to update the titlebar
            park.NameChanging += Park_NameChanging;

            // Change the park name to be something fun for the user
            park.Name = "Loopy Landscapes";
        }

        private void Park_NameChanging(object sender, NameChangingEventArgs e)
        {
            this.Text = PREFIX + e.ParkName;
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // When the manager form loads, open the following screens by default:
            parkConfigurationToolStripButton.PerformClick(); // pretend to click on the park button.
            guestsToolStripButton.PerformClick(); // pretend to click on the guests button.
            weatherToolStripButton.PerformClick(); 

            buyRideToolStripButton.PerformClick();

            debugToolStripButton.PerformClick(); 
        }

        /*
         * TODO: Make sure the forms can only open once
         */

        private void guestsToolStripButton_Click(object sender, EventArgs e)
        {
            GuestsForm form = new GuestsForm(park);

            // Make this form a child of this ManagerForm (it will appear inside it, like with Paint.NET or old Windows software)
            form.MdiParent = this;

            form.Show();
        }

        private void parkConfigurationToolStripButton_Click(object sender, EventArgs e)
        {
            ParkConfigurationForm form = new ParkConfigurationForm(park);
            form.MdiParent = this;
            form.Show();
        }

        private void debugToolStripButton_Click(object sender, EventArgs e)
        {
            DebugForm form = new DebugForm(park);
            form.MdiParent = this;
            form.Show();
        }

        private void weatherToolStripButton_Click(object sender, EventArgs e)
        {
            WeatherForm form = new WeatherForm(park);
            form.MdiParent = this;
            form.Show();
        }

        private void buyRideToolStripButton_Click(object sender, EventArgs e)
        {
            BuyRidesForm form = new BuyRidesForm(park);
            form.MdiParent = this;
            form.Show();
        }
    }
}
