using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility_HW
{
    internal class Mechanic : GarageHandler
    {
        // the Mehanic checks the engine and gear box
        public override void RequestHandler(Car car)
        {

            if(car.EngineFixed == false)
            {
                car.EngineFixed = true;
                LogReport += "Fixed Engine \n";
            }

            if(car.GearFixed == false)
            {
                LogReport += "Fixed Gear \n";
                car.GearFixed = true;
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
