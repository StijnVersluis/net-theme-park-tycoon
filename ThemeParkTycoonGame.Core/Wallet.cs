using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class Wallet
    {
        public const string DEFAULT_PAYMENT_REASON = "Paid to an unknown entity";

        public delegate void BalanceChangedEvent(object sender, BalanceChangedEventArgs e);
        public event BalanceChangedEvent BalanceChanged;

        private decimal balance;
        public decimal Balance {
            get
            {
                return balance;
            }
            private set
            {
                DoBalanceChange(value);
            }
        }

        public List<PaymentLog> History { get; private set; }

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

        public Wallet(decimal balance = 0)
        {
            this.Balance = balance;
        }

        public void RegisterPayment(decimal amount, string reason = null)
        {
            if (reason == null)
                reason = DEFAULT_PAYMENT_REASON;

            this.Balance -= amount;

            this.History.Add(new PaymentLog()
            {
                Amount = amount,
                Reason = reason
            });
        }
    }

    public class PaymentLog
    {
        public decimal Amount { get; set; }
        public string Reason { get; set; }
    }

    public class BalanceChangedEventArgs : EventArgs
    {
        public decimal OldBalance;
        public decimal Balance;
    }
}
