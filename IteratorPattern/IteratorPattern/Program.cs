using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleAggregate car = new Vehicles.Car();
            IVehicleAggregate motercycle = new Vehicles.Motercycle();

            IVehicleIterator carIterator = car.CreateIterator();
            IVehicleIterator motercycleIterator = motercycle.CreateIterator();

            PrintVehicles(carIterator);
            PrintVehicles(motercycleIterator);
        }

        static void PrintVehicles(IVehicleIterator iterator)
        {
            iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(iterator.Next());
            }
        }
    }
}
