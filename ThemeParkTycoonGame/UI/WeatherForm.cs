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
    public partial class WeatherForm : Form
    {
        private Park park;

        public WeatherForm(Park park)
        {
            InitializeComponent();

            this.park = park;

            this.park.WeatherChanged += Park_WeatherChanged;

            RefreshWeather(park.CurrentWeather);
        }

        private void Park_WeatherChanged(object sender, WeatherChangedEventArgs e)
        {
            RefreshWeather(e.Weather);
        }

        private void RefreshWeather(Weather weather)
        {
            weatherLabel.Text = weather.Name;
            weatherPictureBox.Image = weather.Image;

            weatherLabel.Location = new Point((int)(weatherPictureBox.Location.X + (weatherPictureBox.Size.Width * .5) - (weatherLabel.Size.Width * .5)), weatherLabel.Location.Y);
        }
    }
}
