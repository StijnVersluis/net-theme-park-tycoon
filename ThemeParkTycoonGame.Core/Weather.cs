using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Weather
    {
        public static Weather[] WeatherTypes;
        private static Random numberGenerator;

        public string Name;
        public Image Image;

        public Weather(string name, Image image)
        {
            Name = name;
            Image = image;
        }

        private static void CreateWeatherTypes()
        {
            numberGenerator = new Random();

            WeatherTypes = new Weather[]
            {
                new Weather("Sunny", Properties.Resources.weather_sun_48),
                new Weather("Rainy", Properties.Resources.weather_rain_48),
                new Weather("Stormy", Properties.Resources.weather_storm_48),
                new Weather("Snow", Properties.Resources.weather_snow_48),
            };
        }

        private static void CreateWeatherTypesIfNotExists()
        {
            if (WeatherTypes != null)
            {
                // If we've already set the weather types, then stop.
                return;
            }

            CreateWeatherTypes();
        }

        public static Weather GetRandom()
        {
            CreateWeatherTypesIfNotExists();

            return WeatherTypes[numberGenerator.Next(0, WeatherTypes.Length)];
        }
    }
}
