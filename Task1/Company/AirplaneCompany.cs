using System;
using System.Collections.Generic;
using System.Linq;
using Task1.Airplanes;
using Task1.Airplanes.CivilPlanes.PassengerPlanes;

namespace Task1.Company
{
    public class AirplaneCompany
    {
        public ICollection<IAircraft> Aircrafts { get; }

        public int CalculateAllMaxWeight() => Aircrafts
            .Select(x => x.MaxWeight)
            .Sum();

        public int CalculateAllSeatingCapacity() => Aircrafts
            .Where(x => x is PassengerPlane)
            .Cast<PassengerPlane>()
            .Select(x => x.SeatCount)
            .Sum();
        
        public void SortByMaxDistance() => Aircrafts
            .OrderByDescending(x => x.MaxDistance)
            .ToList()
            .ForEach(x => Console.WriteLine("{0}: {1} km", x, x.MaxDistance));

        public void SelectByQuery(Func<IAircraft, bool> predicate) => Aircrafts
            .Where(predicate)
            .ToList()
            .ForEach(Console.WriteLine);

        public AirplaneCompany(ICollection<IAircraft> aircrafts)
        {
            Aircrafts = aircrafts ?? new List<IAircraft>(0);
        }

        public void Add(Airplane airplane) => Aircrafts.Add(airplane);
        
        
    }
}