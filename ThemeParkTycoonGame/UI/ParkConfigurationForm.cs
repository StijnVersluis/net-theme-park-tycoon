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
    public partial class ParkConfigurationForm : Form
    {
        private Park park;

        public ParkConfigurationForm(Park park)
        {
            InitializeComponent();

            this.park = park;

            RefreshBalance(park.ParkWallet.Balance);
            RefreshInventory(park.ParkInventory);

            park.ParkWallet.BalanceChanged += Wallet_BalanceChanged;
            park.ParkInventory.InventoryChanged += Inventory_Changed;
        }

        private void RefreshInventory(Inventory parkInventory)
        {
            List<BuildableObject> objects = parkInventory.All;

            objectsListView.LargeImageList = new ImageList();
            objectsListView.LargeImageList.ImageSize = new Size(64, 64);

            for (int i = 0; i < objects.Count; i++)
            {
                BuildableObject ride = objects[i];

                objectsListView.LargeImageList.Images.Add(ride.Image);

                ListViewItem rideListViewItem = new ListViewItem();
                rideListViewItem.Group = objectsListView.Groups[0];
                rideListViewItem.Text = string.Format("{0}\r\n(${1})", ride.Name, ride.Cost);
                rideListViewItem.ImageIndex = i;
                rideListViewItem.Tag = ride;

                objectsListView.Items.Add(rideListViewItem);
            }
        }

        private void Wallet_BalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            RefreshBalance(e.Balance);
        }

        private void Inventory_Changed(object sender, InventoryChangedEventArgs e)
        {
            RefreshInventory(e.Inventory);
        }

        private void RefreshBalance(decimal balance)
        {
            balanceTextBox.Text = balance.ToString("N2");
        }

        private void entryFeeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            this.park.EntryFee = entryFeeNumericUpDown.Value;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.park.DoNameChange(nameTextBox.Text);
        }

        private void ParkConfigurationForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = park.Name;
        }
    }
}
