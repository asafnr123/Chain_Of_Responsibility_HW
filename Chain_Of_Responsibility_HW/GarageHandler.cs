using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility_HW
{
    internal abstract class GarageHandler
    {
        public static string LogReport { get; set; }
        protected GarageHandler next;
        protected bool carIsFixed = false;


        public GarageHandler() { }


        public abstract void RequestHandler(Car car);

        public bool CheckIfCarFixed(Car car)
        {
            if (car.GotEnoughOil == true && car.GotEnoughWater == true && car.GearFixed == true && car.EngineFixed == true && car.RadioFixed == true && car.CarCorderFixed == true)
            {
                car.GotFixed = true;
                return true;
            }
            else
                return false;
        }
        public GarageHandler SetNext(GarageHandler next)
        {
            this.next = next;
            return this.next;
        }

        /// <summary>
        /// Infrom the customer that his car is ready and then show him what work was done
        /// 
        /// </summary>
        public void CarIsReady()
        {
            Console.WriteLine("Your car is ready Sir \n");
            Console.WriteLine("**What was done** \n" + LogReport + "\n");
            LogReport = null;
        }

    }
}
