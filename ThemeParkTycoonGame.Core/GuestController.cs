using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThemeParkTycoonGame.Core
{
    public class GuestController
    {
        public const int TICK_TIMEOUT = 1500;
        public const float CHANCE_ENTER_PARK = 0.5f;

        private List<Guest> targets;
        private Park park;
        private System.Timers.Timer timer;
        private bool hasTicked;

        // Get the drink from ObjectSpecifics.All, make peeps want it. Sell it at python (because testing dont need shops yet)

        // Provide which guests this controller handles
        public GuestController(Park park, List<Guest> targets)
        {
            this.park = park;
            this.targets = targets;

            // Show an exception if someone forgot to call 'DoTick' in their code
            StartWarningCountdown();
        }

        public void DoTick(int interval)
        {
            Tick(interval);
        }

        // A tick is a 'think' and as seen in the Start() methode happens at 1000ms intervals
        private void Tick(int interval)
        {
            hasTicked = true;

            /*
             * Test script to make everyone go to the python
             */
            // Get the python from the park inventory
            //BuildableObject python = this.park.ParkInventory.GetByName("Python");

            //// Does the inventory not contain python? (User hasn't purchased it yet)
            //if (python == null)
            //    return;

            //// Go to Python, ride it and get bonus        
            //foreach (Guest guest in this.targets)
            //{
            //    if(guest.Desires.Count < 1)
            //    {
            //        Desire wants = new Desire()
            //        {
            //            Object = python,
            //            Reason = "I feel compeled to go to the Python",
            //        };

            //        guest.Desires.Enqueue(wants);
            //    }
            //}
            /*
             * End of test script to make everyone go to the python
             */
            // Based on the weather, a certain chance of a guest coming inside
            if (shouldGuestEnter())
            {
                // Add a random guest to the park
                this.park.AddGuest(getNewRandomGuest());
            }


            // They get a random wallet amount to go spend in the park

            // They pay immediately for the park

            // They then go to their first preferred ride or stall based on their stats:

            // Hunger > 50   =   +desire to eat     +a bit desire to ride intense rides
            // Nauseous > 50 =   -desire to ride intense rides  +desire for bathroom
        }

        private bool shouldGuestEnter()
        {
            double nextGuestEnterParkChance = NumberGenerator.NextDouble();

            // Lower/increase the chance based on weather
            nextGuestEnterParkChance *= this.park.CurrentWeather.Multiplier;

            if(nextGuestEnterParkChance < CHANCE_ENTER_PARK)
            {
                return true;
            }

            Debug.WriteLine("Did not let a new guest enter park. It wasn't their day");
            Debug.WriteLine(this.park.CurrentWeather.Multiplier);
            Debug.WriteLine(nextGuestEnterParkChance);
            Debug.WriteLine("====");

            return false;
        }

        private Guest getNewRandomGuest()
        {
            List<Stat> stats = new List<Stat>();
            Guest guest = new Guest()
            {
                CurrentStats = stats,
                // Chosen at random bring between 50 and 150 cash into the park
                Wallet = new Wallet(NumberGenerator.Next(50, 150)),
            };

            var statTypes = StatTypes.GetByTarget(GameObjectType.Guest);

            // When a guest enters, their stats are randomly generated
            foreach (var statType in statTypes)
            {
                stats.Add(new Stat()
                {
                    Type = statType,
                    Value = statType.GetBaseValue(guest)
                });
            }

            return guest;
        }

        internal void StartWarningCountdown()
        {
            if (timer != null)
                return;

            hasTicked = false;
            timer = new System.Timers.Timer();
            timer.Elapsed += WarningTimer_Elapsed;
            timer.Interval = TICK_TIMEOUT; // number of milliseconds between each tick
            timer.Start();
        }

        private void WarningTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(!hasTicked)
                throw new Exception("Tick timed out! This means you didn't call 'GuestController.DoTick()' anywhere! You should call DoTick at least every " + TICK_TIMEOUT + "milliseconds.");
        }
    }
}
