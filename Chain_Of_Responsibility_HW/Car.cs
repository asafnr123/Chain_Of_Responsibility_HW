using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_Of_Responsibility_HW
{
    internal class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public bool GotEnoughOil { get; set; }
        public bool GotEnoughWater { get; set; }
        public bool GotFixed { get; set; } = false;
        public bool GearFixed { get; set; }
        public bool EngineFixed { get; set; }
        public bool RadioFixed { get; set; }
        public bool CarCorderFixed { get; set; }

        public Car(string model, int year, bool isOilGood, bool enoughWater, bool gear, bool engine, bool radio, bool carCoder)
        {
            Model = model;
            Year = year;
            GotEnoughOil = isOilGood;
            GotEnoughWater = enoughWater;
            GearFixed = gear;
            EngineFixed = engine;
            RadioFixed = radio;
            CarCorderFixed = carCoder;
        }

        
    }
}
