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

namespace ThemeParkTycoonGame.Forms.Screens
{
    public partial class GuestsForm : Form, IPositionSelf
    {
        private Park park;

        public GuestsForm(Park park)
        {
            InitializeComponent();

            this.park = park;

            park.GuestEntered += Park_GuestEntered;
        }

        private void Park_GuestEntered(object sender, GuestEnteredEventArgs e)
        {
            RefreshGuestList();

            e.Guest.Inventory.InventoryChanged += Guest_InventoryChanged;
            e.Guest.ActionChanged += Guest_ActionChanged;
        }

        private void Guest_ActionChanged(object sender, Guest.ActionChangedEventArgs e)
        {
            RefreshGuestList();
        }

        private void Guest_InventoryChanged(object sender, InventoryChangedEventArgs e)
        {
            RefreshGuestList();
        }

        private void RefreshGuestList()
        {
            guestsListView.Items.Clear();

            // Action column
            var actionColumn = guestsListView.Columns[2].Index;

            // When a guest enters, update this form
            foreach (Guest guest in park.Guests)
            {
                string[] columnData = new string[] { guest.Name, guest.Wallet.Balance.ToString("N2"), guest.CurrentDesire.Reason, guest.TimeEntered.ToString() };
                ListViewItem newItem = new ListViewItem(columnData);
                newItem.Tag = guest;

                guest.ActionChanged += (s, ev) =>
                {
                    if (!guestsListView.InvokeRequired)
                        newItem.SubItems[actionColumn].Text = ev.Action;
                };

                guestsListView.Items.Add(newItem);
            }

            toolStripStatusLabel.Text = string.Format("Total guests: {0}", guestsListView.Items.Count);
        }

        // Called when double clicked (check out the Activation property, it's set to TwoClick)
        private void guestsListView_ItemActivate(object sender, EventArgs e)
        {
            if (guestsListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedGuestItem = guestsListView.SelectedItems[0];

                // Cast the Tag (object) back to Guest (we know there's a guest in there)
                Guest guest = selectedGuestItem.Tag as Guest; 

                SingleGuestForm form = new SingleGuestForm(guest);
                form.MdiParent = this.MdiParent;
                form.Show();
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
