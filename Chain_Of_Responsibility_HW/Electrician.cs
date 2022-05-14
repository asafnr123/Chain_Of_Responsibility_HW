using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility_HW
{
    internal class Electrician : GarageHandler
    {
        //electrician fixed radio and car coder
        public override void RequestHandler(Car car)
        {
            if (car.RadioFixed == false)
            {
                LogReport += "Replaced Radio \n";
                car.RadioFixed = true;
            }

            if (car.CarCorderFixed == false)
            {
                LogReport += "Fixed Coder";
                car.CarCorderFixed = true;
            }

            //Return True if car got fixed
            if (CheckIfCarFixed(car))
                CarIsReady();
            else
            {
                if (next != null)
                    next.RequestHandler(car);
            }
        }
    }
}
