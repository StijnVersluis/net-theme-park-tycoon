using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Forms
{
    public class Guest : GameObject
    {
        public delegate void ActionChangedEvent(object sender, ActionChangedEventArgs e);
        public event ActionChangedEvent ActionChanged;

        public string Name;
        public Wallet Wallet;
        public DateTime? TimeEntered;
        public string CurrentAction { get; private set; }
        public ObservableQueue<Desire> Desires;

        public Guest()
            :base()
        {
            // When a guest is first created, give them a random name!
            Name = NameGenerator.NextName();

            // Give this guest a wallet with 100 bucks
            Wallet = new Wallet();
            Wallet.Balance = 100;

            // Give a guest basics stats
            foreach (StatType statType in StatTypes.GetByTarget(GameObjectType.Guest))
            {
                float asd = statType.GetBaseValue(this);

                CurrentStats.Add(new Stat()
                {
                    Type = statType,
                    Value = asd
                });
            }

            Desires = new ObservableQueue<Desire>();
            Desires.CollectionChanged += Guest_DesiresChanged;
        }

        private void Guest_DesiresChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            string oldAction = this.CurrentAction;

            this.CurrentAction = (e.NewItems[0] as Desire).Reason;

            if (ActionChanged != null)
                ActionChanged.Invoke(this, new ActionChangedEventArgs(oldAction, this.CurrentAction));
        }

        public override string ToString()
        {
            return Name;
        }

        public class ActionChangedEventArgs : EventArgs
        {
            public string OldAction;
            public string Action;

            public ActionChangedEventArgs(string oldAction, string currentAction)
            {
                OldAction = oldAction;
                Action = currentAction;
            }
        }
    }
}
