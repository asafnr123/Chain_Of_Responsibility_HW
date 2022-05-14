using System;

namespace Chain_Of_Responsibility_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Mazda", 2008, false, true, false, true, true, false);
            Car c2 = new Car("Toyota", 2004, true, true, false, true, false, true);
            Car c3 = new Car("Kia", 2014, false, true, false, false, false, true);
            Car c4 = new Car("Honda", 2014, false, true, true, false, true, true);


            GarageHandler worker = new GarageWorker();
            GarageHandler mechanic = new Mechanic();
            GarageHandler electrician = new Electrician();

            worker.SetNext(mechanic).SetNext(electrician);

            worker.RequestHandler(c1);
            worker.RequestHandler(c2);
            worker.RequestHandler(c3);
            worker.RequestHandler(c4);
        }
    }
}
