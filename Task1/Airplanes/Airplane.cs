using Task1.Engines;

namespace Task1.Airplanes
{
    public abstract class Airplane : IAircraft, IEngine
    {
        public abstract string ModificationName { get; }
        public abstract double WingSpan { get; }
        public abstract WingType WingType { get; }
        public abstract int CrewCount { get; }
        public abstract int EmptyMass { get; }
        public abstract int MaxWeight { get; }
        public abstract double FuselageWidth { get; }
        public abstract double FuelUsage { get; }
        public abstract int MaxDistance { get; }
        public abstract int CruiseSpeed { get; }
        public abstract int EngineCount { get; }
        public abstract string EngineModel { get; }
        public abstract string Vendor { get; }
        public abstract double MaxThrust { get; }
        public abstract double Bsfc { get; }
    }
}
