using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Airplanes;
using Task1.Airplanes.CivilPlanes.PassengerPlanes;
using Task1.Airplanes.CivilPlanes.PassengerPlanes.NarrowBodyPlanes;
using Task1.Airplanes.CivilPlanes.PassengerPlanes.WideBodyPlanes;

namespace Task1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var airplanes = new List<Airplane>()
            {
                new AirbusA300(hullNumber: 220),
                new AirbusA320(hullNumber: 111),
                new Tu154(hullNumber: 80567)
            };

            Console.WriteLine("Max weight of all airplanes is {0} kg", airplanes
                .Select(x => x.MaxWeight)
                .Sum());

            Console.WriteLine();
            Console.WriteLine("The seating capacity of all airplanes is {0} liters-per-hour", airplanes
                .Where(x => x is PassengerPlane)
                .Cast<PassengerPlane>()
                .Select(x => x.EconomyClassSeatCount)
                .Sum());

            Console.WriteLine();
            Console.WriteLine("Airplanes by descending of max distance:");
            airplanes
                .OrderByDescending(x => x.MaxDistance)
                .ToList()
                .ForEach(x => Console.WriteLine("{0}: {1} km", x, x.MaxDistance));

            Console.WriteLine();
            Console.WriteLine("Selection airplanes by query:");
            airplanes
                .Where(x => x.FuelUsage > 2000 && x.FuelUsage < 4000)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
