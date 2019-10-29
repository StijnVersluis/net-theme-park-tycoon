using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
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

        // A tick is a 'think' and as seen in the Start() methode happens at 1000ms intervals
        private void Tick()
        {
            /*
             * Test script to make everyone go to the python
             */
            // Get the python from the park inventory
            BuildableObject python = this.park.ParkInventory.GetByName("Python");

            // Does the inventory not contain python? (User hasn't purchased it yet)
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
                        Reason = "I feel compeled to go to the Python",
                    };

                    guest.Desires.Enqueue(wants);
                }
            }
            /*
             * End of test script to make everyone go to the python
             */
        }

        internal void Start()
        {
            if (timer != null)
                return;

            timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(DoTick);
            timer.Interval = 1000; // number of milliseconds between each tick
            timer.Start();
        }
    }
}
