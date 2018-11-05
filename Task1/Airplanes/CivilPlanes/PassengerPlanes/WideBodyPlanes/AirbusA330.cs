using Task1.Engines.TurboJetEngines;
using Task1.SeatClasses;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.WideBodyPlanes
{
    public class AirbusA330 : WideBodyPlane, ITurboFan, IBusinessClass
    {
        private int _hullNumber;
        public override string ModificationName => "200";
        public override double WingSpan => 60.3;
        public override int CrewCount => 2;
        public override int EmptyMass => 120600;
        public override int MaxWeight => 242000;
        public override double FuelUsage => 2150;
        public override int MaxDistance => 13400;
        public override int CruiseSpeed => 871;
        public override int EngineCount => 2;
        public override string EngineModel => "CF6-80E1";
        public override string Vendor => "General Electric";
        public override double MaxThrust => 320;
        public override double Bsfc => 0.564;
        public override double FuselageWidth => 5.64;
        public override int SeatCount => 246;
        public override int PortholeCount => 250;
        public override int MaxLuggageWeight => 40;
        public override int RowSeatsCount => 8;
        public override int EconomyClassSeatCount => 210;
        public override double EconomyClassSeatStep => 81.28;
        public double PressureRatio => 25.2;
        public double BypassRatio => 5.92;
        public int BusinessClassSeatCount => 36;
        public int BusinessClassSeatStep => 152;

        public AirbusA330(int hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}