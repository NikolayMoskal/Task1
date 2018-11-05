using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Airplanes;
using Task1.Airplanes.CivilPlanes.PassengerPlanes;
using Task1.Airplanes.CivilPlanes.PassengerPlanes.NarrowBodyPlanes;
using Task1.Airplanes.CivilPlanes.PassengerPlanes.WideBodyPlanes;
using Task1.Airplanes.CivilPlanes.TransportPlanes;
using Task1.Company;

namespace Task1
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var airplanes = new AirplaneCompany(new List<IAircraft>());
            airplanes.Add(new Tu154(111));
            airplanes.Add(new An124("UR-PSFTY"));
            airplanes.Add(new AirbusA300(220));
            airplanes.Add(new AirbusA320(115));
            airplanes.Add(new An148("PR-YGHUJ"));

            Console.WriteLine("Max weight of all airplanes is {0} kg", airplanes.CalculateAllMaxWeight());
            Console.WriteLine();
            
            Console.WriteLine("The seating capacity of all airplanes is {0} liters-per-hour", airplanes.CalculateAllSeatingCapacity());
            Console.WriteLine();
            
            Console.WriteLine("Airplanes by descending of max distance:");
            airplanes.SortByMaxDistance();
            Console.WriteLine();
            
            Console.WriteLine("Selection airplanes by query:");
            airplanes.SelectByQuery(x => x.FuelUsage > 2000 && x.FuelUsage < 4000);
        }
    }
}
