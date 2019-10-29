using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThemeParkTycoonGame.Core;

namespace ThemeParkTycoonGame.Fancy.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Park park;

        public MainWindow()
        {
            InitializeComponent();

            this.park = new Park();

            // In het WinForms project gebruikte we een Mdi parent
            // ofwel: schermen in 1 parent scherm.
            //
            // Hier worden de nadelen van dat ontwerp opgesomd:
            // https://en.wikipedia.org/wiki/Multiple-document_interface#Disadvantages
            //
            // In plaats van een Mdi parent gaan we gebruik maken van tabbladen:
            // https://www.wpf-tutorial.com/tabcontrol/using-the-tabcontrol/

            // Give the park information to the ParkControl
            parkControl.Park = this.park;

            // This allows us to bind to every property in a park (like EntryFee, Name, Guests, etc)
            this.DataContext = this.park;

            // Don't need this because of binding:
            // Hook to the park namechange to update the titlebar
            //park.NameChanging += Park_NameChanging;

            // Change the park name to be something fun for the user
            park.Name = "Loopy Landscapes";

            // Make sure this window can be dragged
            this.MouseDown += MainWindow_MouseDown;
        }

        private void MainWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
