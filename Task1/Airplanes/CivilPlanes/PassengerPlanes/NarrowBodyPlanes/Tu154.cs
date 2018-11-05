using Task1.Engines.TurboJetEngines;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.NarrowBodyPlanes
{
    public class Tu154 : NarrowBodyPlane, ITurboFan
    {
        private int _hullNumber;
        public override int CrewCount => 4;
        public override int EmptyMass => 51000;
        public override double FuelUsage => 6200;
        public override int MaxWeight => 100000;
        public override double FuselageWidth => 3.8;
        public override int MaxDistance => 2650;
        public override int CruiseSpeed => 900;
        public override int EngineCount => 3;
        public override string EngineModel => "Д-30КУ-154 II";
        public override string Vendor => "Сатурн";
        public override double MaxThrust => 105.72;
        public override double Bsfc => 0.498;
        public override string ModificationName => "М";
        public override double WingSpan => 37.55;
        public override WingType WingType => WingType.LowWingPlane;
        public override int SeatCount => 180;
        public override int PortholeCount => 180;
        public override int MaxLuggageWeight => 30;
        public override int RowSeatsCount => 7;
        public override int EconomyClassSeatCount => 180;
        public override double EconomyClassSeatStep => 81.28;
        public double PressureRatio => 15.45;
        public double BypassRatio => 2.5;

        public Tu154(int hullNumber)
        {
            this._hullNumber = hullNumber;
        }
    }
}
