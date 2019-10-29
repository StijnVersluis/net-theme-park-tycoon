using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Forms
{
    public class Wallet
    {
        public delegate void BalanceChangedEvent(object sender, BalanceChangedEventArgs e);
        public event BalanceChangedEvent BalanceChanged;

        private decimal balance;
        public decimal Balance {
            get
            {
                return balance;
            }
            set
            {
                DoBalanceChange(value);
            }
        }

        private void DoBalanceChange(decimal balance)
        {
            // Check if someone is handling this event
            if (BalanceChanged != null)
            {
                BalanceChanged.Invoke(this, new BalanceChangedEventArgs()
                {
                    OldBalance = this.Balance,
                    Balance = balance
                });
            }

            this.balance = balance;
        }
    }

    public class BalanceChangedEventArgs : EventArgs
    {
        public decimal OldBalance;
        public decimal Balance;
    }
}
