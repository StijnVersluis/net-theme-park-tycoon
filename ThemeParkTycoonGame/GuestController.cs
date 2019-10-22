using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame
{
    public class GuestController
    {
        private List<Guest> targets;
        private Park park;
        private System.Timers.Timer timer;

        // Get the drink from ObjectSpecifics.All, make peeps want it. Sell it at python (because testing dont need shops yet)

        // Provide which guests this controller handles
        public GuestController(Park park, List<Guest> targets)
        {
            this.park = park;
            this.targets = targets;
        }

        protected void DoTick(object source, System.Timers.ElapsedEventArgs e)
        {
            Tick();
        }

        private void Tick()
        {
            BuildableObject python = this.park.ParkInventory.GetByName("Python");

            if (python == null)
                return;

            // Go to Python, ride it and get bonus        
            foreach (Guest guest in this.targets)
            {
                if(guest.Desires.Count < 1)
                {
                    Desire wants = new Desire()
                    {
                        Object = python,
                        Specific = null, // Just want to ride
                        Reason = "I feel compeled to go to the Python",
                    };

                    guest.Desires.Enqueue(wants);
                }
            }
        }

        internal void Start()
        {
            if (timer != null)
                return;

            timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(DoTick);
            timer.Interval = 1000; // ms
            timer.Start();
        }
    }
}
