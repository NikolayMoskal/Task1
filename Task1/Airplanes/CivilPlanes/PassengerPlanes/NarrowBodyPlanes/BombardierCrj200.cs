using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.NarrowBodyPlanes
{
    [RegionalPlane]
    public class BombardierCrj200 : NarrowBodyPlane, ITurboFan
    {
        private int _hullNumber;
        public override string ModificationName => "ER";
        public override double WingSpan => 21.21;
        public override WingType WingType => WingType.LowWingPlane;
        public override int CrewCount => 4;
        public override int EmptyMass => 13500;
        public override int MaxWeight => 24041;
        public override double FuelUsage => 1120;
        public override int MaxDistance => 3045;
        public override int CruiseSpeed => 785;
        public override int EngineCount => 2;
        public override string EngineModel => "CF34-3B1";
        public override string Vendor => "General Electric";
        public override double MaxThrust => 41.01;
        public override double Bsfc => 0.678;
        public override double FuselageWidth => 2.69;
        public override int SeatCount => 50;
        public override int PortholeCount => 50;
        public override int MaxLuggageWeight => 15;
        public override int RowSeatsCount => 4;
        public override int EconomyClassSeatCount => 50;
        public override double EconomyClassSeatStep => 71.12;
        public double PressureRatio => 21;
        public double BypassRatio => 6.2;

        public BombardierCrj200(int hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}