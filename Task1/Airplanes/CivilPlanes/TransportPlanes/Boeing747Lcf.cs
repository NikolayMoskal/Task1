using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.TransportPlanes
{
    public class Boeing747Lcf : TransportPlane, ITurboFan
    {
        private string _hullNumber;
        public override string ModificationName => "Large Cargo Freighter Dreamlifter";
        public override double WingSpan => 64.4;
        public override int CrewCount => 2;
        public override int EmptyMass => 180530;
        public override int MaxWeight => 364240;
        public override double FuelUsage => 2600;
        public override int MaxDistance => 7800;
        public override int CruiseSpeed => 878;
        public override int EngineCount => 4;
        public override string EngineModel => "PW4062";
        public override string Vendor => "Pratt & Whitney";
        public override double MaxThrust => 282;
        public override double Bsfc => 0.582;
        public override double FuselageWidth => 8.38;
        public override int SeatCount => 2;
        public override double CargoCompartmentVolume => 1840;
        public double PressureRatio => 32.3;
        public double BypassRatio => 5.0;

        public Boeing747Lcf(string hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}