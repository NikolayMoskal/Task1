using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.NarrowBodyPlanes
{
    [RegionalPlane]
    public class An140 : NarrowBodyPlane, ITurboProp
    {
        private string _hullNumber;
        public override string ModificationName => "100";
        public override double WingSpan => 25.505;
        public override WingType WingType => WingType.HighWingPlane;
        public override int CrewCount => 2;
        public override int EmptyMass => 13100;
        public override int MaxWeight => 21500;
        public override double FuelUsage => 550;
        public override int MaxDistance => 1300;
        public override int CruiseSpeed => 533;
        public override int EngineCount => 2;
        public override string EngineModel => "ТВЗ-117ВМА-СБМ1";
        public override string Vendor => "Мотор Сич";
        public override double MaxThrust => 130;
        public override double Bsfc => 0.209;
        public override double FuselageWidth => 2.76;
        public override int SeatCount => 52;
        public override int PortholeCount => 52;
        public override int MaxLuggageWeight => 20;
        public override int RowSeatsCount => 4;
        public override int EconomyClassSeatCount => 52;
        public override double EconomyClassSeatStep => 78;
        public Direction RotateDirection => Direction.Left;
        public double PressureRatio => 9.4;

        public An140(string hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}