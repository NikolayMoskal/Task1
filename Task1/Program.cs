using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Airplane> airplanes = new List<Airplane>()
            {
                new AirbusA300(),
                new AirbusA320(),
                new Tu154()
            };

            Console.WriteLine("Max takeoff weight of all airplanes is {0} kg", airplanes
                .Select(x => x.MaxTakeoffWeight)
                .Sum());

            Console.WriteLine();
            Console.WriteLine("The seating capacity of all airplanes is {0} liters-per-hour", airplanes
                .Select(x => x)
                .Where(x => x is PassengerPlane)
                .Select(x => (x as PassengerPlane).PlaceCount)
                .Sum());

            Console.WriteLine();
            Console.WriteLine("Airplanes by descending of max distance {0}");
            airplanes
                .Select(x => x)
                .OrderByDescending(x => x.MaxDistance)
                .ToList()
                .ForEach(x => Console.WriteLine("{0}: {1} km", x, x.MaxDistance));

            Console.WriteLine();
            Console.WriteLine("Selection airplanes by query:");
            airplanes
                .Select(x => x)
                .Where(x => x.FuelUsage > 2000 && x.FuelUsage < 4000)
                .ToList()
                .ForEach(x => Console.WriteLine(x));
        }
    }
}
