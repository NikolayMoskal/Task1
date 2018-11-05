using Task1.SeatClasses;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes
{
    public abstract class PassengerPlane : CivilPlane, IEconomyClass
    {
        public abstract int PortholeCount { get; }
        public abstract int MaxLuggageWeight { get; }
        public abstract int RowSeatsCount { get; }
        public abstract int EconomyClassSeatCount { get; }
        public abstract double EconomyClassSeatStep { get; }
    }
}
