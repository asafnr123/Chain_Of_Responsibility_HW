using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility_HW
{
    internal class GarageWorker : GarageHandler
    {
        //GarageWorker job is to check oil and water
        public override void RequestHandler(Car? car)
        {
            LogReport = $"Model: {car.Model} \n" +
                $"Year: {car.Year} \n";

            if (car.GotEnoughWater == false)
            {
                LogReport += "Filled Water \n";
                car.GotEnoughWater = true;
            }

            if (car.GotEnoughOil == false)
            {
                LogReport += "Filled Oil \n";
                car.GotEnoughOil = true;
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
