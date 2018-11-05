using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.NarrowBodyPlanes
{
    [RegionalPlane]
    public class An148 : NarrowBodyPlane, ITurboFan
    {
        private string _hullNumber;
        public override string ModificationName => "100A";
        public override double WingSpan => 28.91;
        public override WingType WingType => WingType.HighWingPlane;
        public override int CrewCount => 4;
        public override int EmptyMass => 22490;
        public override int MaxWeight => 38550;
        public override double FuelUsage => 1550;
        public override int MaxDistance => 1070;
        public override int CruiseSpeed => 800;
        public override int EngineCount => 2;
        public override string EngineModel => "Д-436-148";
        public override string Vendor => "Мотор Сич";
        public override double MaxThrust => 135;
        public override double Bsfc => 0.62;
        public override double FuselageWidth => 3.5;
        public override int SeatCount => 80;
        public override int PortholeCount => 80;
        public override int MaxLuggageWeight => 20;
        public override int RowSeatsCount => 4;
        public override int EconomyClassSeatCount => 80;
        public override double EconomyClassSeatWidth => 76.2;
        public double PressureRatio => 25.2;
        public double BypassRatio => 4.95;
        
        public An148(string hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}