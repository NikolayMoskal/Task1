using Task1.Airplanes.DoubleDeckPlanes;
using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.TransportPlanes
{
    public class An124 : TransportPlane, ITurboFan, IDoubleDeckPlane
    {
        private string _hullNumber;
        public override string ModificationName => "100";
        public override double WingSpan => 73.3;
        public override int CrewCount => 8;
        public override int EmptyMass => 178400;
        public override int MaxWeight => 392000;
        public override double FuelUsage => 2450;
        public override int MaxDistance => 4800;
        public override int CruiseSpeed => 850;
        public override int EngineCount => 4;
        public override string EngineModel => "Д-18Т";
        public override string Vendor => "ЗМБК Прогресс";
        public override double MaxThrust => 229.85;
        public override double Bsfc => 0.546;
        public override double FuselageWidth => 6.4;
        public override int SeatCount => 8;
        public override double CargoCompartmentVolume => 1050;
        public double PressureRatio => 23.5;
        public double BypassRatio => 5.6;
        public int DoubleDeckSeatCount => 21;

        public An124(string hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}