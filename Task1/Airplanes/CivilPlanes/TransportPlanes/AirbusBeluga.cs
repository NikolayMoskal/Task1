using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.TransportPlanes
{
    public class AirbusBeluga : TransportPlane, ITurboFan
    {
        private int _hullNumber;
        public override string ModificationName => "A300-600ST";
        public override double WingSpan => 44.84;
        public override int CrewCount => 2;
        public override int EmptyMass => 86500;
        public override int MaxWeight => 155000;
        public override double FuelUsage => 2500;
        public override int MaxDistance => 2779;
        public override int CruiseSpeed => 750;
        public override int EngineCount => 2;
        public override string EngineModel => "CF6-80C2A8";
        public override string Vendor => "General Electric";
        public override double MaxThrust => 275.6;
        public override double Bsfc => 0.642;
        public override double FuselageWidth => 3.95;
        public override int SeatCount => 2;
        public override double CargoCompartmentVolume => 1500;
        public double PressureRatio => 31.8;
        public double BypassRatio => 5.31;

        public AirbusBeluga(int hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}