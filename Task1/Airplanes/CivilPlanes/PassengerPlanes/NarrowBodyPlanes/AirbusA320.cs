using Task1.Engines.TurboJetEngines;
using Task1.SeatClasses;

namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.NarrowBodyPlanes
{
    public class AirbusA320 : NarrowBodyPlane, IFirstClass, ITurboFan
    {
        private int _hullNumber;
        public override int MaxWeight => 78000;
        public override double FuselageWidth => 3.95;
        public override int MaxDistance => 6150;
        public override int CruiseSpeed => 840;
        public override int EngineCount => 2;
        public override string EngineModel => "CFM56-5B";
        public override string Vendor => "CFMI";
        public override double MaxThrust => 133;
        public override double Bsfc => 0.646;
        public override string ModificationName => "100";
        public override double WingSpan => 34.1;
        public override int CrewCount => 2;
        public override int EmptyMass => 37230;
        public override double FuelUsage => 2700;
        public override WingType WingType => WingType.LowWingPlane;
        public override int EconomyClassSeatCount => 138;
        public override double EconomyClassSeatStep => 81.28;
        public override int PortholeCount => 150;
        public override int MaxLuggageWeight => 30;
        public override int RowSeatsCount => 6;
        public int FirstClassRoomCount => 12;
        public double FirstClassSeatStep => 91.44;
        public double PressureRatio => 31.2;
        public double BypassRatio => 6.0;
        public override int SeatCount => 150;

        public AirbusA320(int hullNumber)
        {
            this._hullNumber = hullNumber;
        }
    }
}