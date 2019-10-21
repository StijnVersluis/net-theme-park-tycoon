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
    public partial class MarketplaceForm : Form
    {
        private Park park;

        public MarketplaceForm(Park park)
        {
            InitializeComponent();

            this.park = park;

            Marketplace marketplace = Marketplace.Instance;
            List<Ride> buyableRides = marketplace.GetBuyableRides(park.ParkInventory);

            // Prepare a list to add all the images to for rides.
            ridesListView.LargeImageList = new ImageList();
            ridesListView.LargeImageList.ImageSize = new Size(64, 64);

            for (int i=0; i < buyableRides.Count; i++)
            {
                Ride ride = buyableRides[i];

                ridesListView.LargeImageList.Images.Add(ride.Image);

                ListViewItem rideListViewItem = new ListViewItem();
                rideListViewItem.Group = ridesListView.Groups[0];
                rideListViewItem.Text = string.Format("{0}\r\n(${1})", ride.Name, ride.Cost);
                // Reference the image by it's index (weird that Microsoft designed it this way)
                rideListViewItem.ImageIndex = i;
                rideListViewItem.Tag = ride;

                ridesListView.Items.Add(rideListViewItem);
            }
        }

        // Called when double clicked (check out the Activation property, it's set to TwoClick)
        private void ridesListView_ItemActivate(object sender, EventArgs e)
        {
            if (ridesListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedRideItem = ridesListView.SelectedItems[0];

                // Cast the Tag (object) back to Ride (we know there's a Ride in there)
                Ride ride = selectedRideItem.Tag as Ride;

                if(park.ParkWallet.Balance >= ride.Cost)
                {
                    park.ParkInventory.Rides.Add(ride);
                }
                else
                {
                    MessageBox.Show(string.Format("You do not have enough money to buy {0}!", ride.Name));
                }
            }
        }
    }
}
