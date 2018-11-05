using Task1.Airplanes.DoubleDeckPlanes;
using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.WideBodyPlanes
{
    public class AirbusA300 : WideBodyPlane, ITurboFan, IDoubleDeckPlane
    {
        private int _hullNumber;
        public override int CrewCount => 2;
        public override int EmptyMass => 88626;
        public override int MaxWeight => 171700;
        public override double FuselageWidth => 5.64;
        public override int MaxDistance => 7500;
        public override int CruiseSpeed => 875;
        public override int EngineCount => 2;
        public override string EngineModel => "JT9D-59A";
        public override string Vendor => "Pratt & Whitney";
        public override double MaxThrust => 235.76;
        public override double Bsfc => 0.646;
        public override string ModificationName { get; }
        public override double WingSpan => 44.84;
        public override WingType WingType => WingType.LowWingPlane;
        public override double FuelUsage => 1800;
        public override int EconomyClassSeatCount => 345;
        public override double EconomyClassSeatWidth => 86.36;
        public override int PortholeCount => 345;
        public override int MaxLuggageWeight => 30;
        public override int RowSeatsCount => 9;
        public double PressureRatio => 23.4;
        public double BypassRatio => 5.0;
        public int DoubleDeckSeatCount => 22;
        public override int SeatCount => 345;

        public AirbusA300(int hullNumber)
        {
            this._hullNumber = hullNumber;
        }
    }
}