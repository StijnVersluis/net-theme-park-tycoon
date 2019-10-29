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

namespace ThemeParkTycoonGame.Fancy.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // In het WinForms project gebruikte we een Mdi parent
            // ofwel: schermen in 1 parent scherm.
            //
            // Hier worden de nadelen van dat ontwerp opgesomd:
            // https://en.wikipedia.org/wiki/Multiple-document_interface#Disadvantages
            //
            // In plaats van een Mdi parent gaan we gebruik maken van tabbladen:
            // https://www.wpf-tutorial.com/tabcontrol/using-the-tabcontrol/
        }
    }
}
