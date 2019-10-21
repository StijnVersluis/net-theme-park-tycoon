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

            park.ParkWallet.BalanceChanged += Wallet_BalanceChanged;
        }

        private void Wallet_BalanceChanged(object sender, BalanceChangedEventArgs e)
        {
            RefreshBalance(e.Balance);
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
