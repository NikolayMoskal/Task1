using System.Collections.Generic;
using Task1.Engines.TurboJetEngines;
using Task1.Weapons;

namespace Task1.Airplanes.MilitaryPlanes.Bombers
{
    public class Tu95 : Bomber, ITurboProp
    {
        private string _hullNumber;
        public override string ModificationName => "М";
        public override double WingSpan => 50.04;
        public override WingType WingType => WingType.HighWingPlane;
        public override int CrewCount => 9;
        public override int EmptyMass => 84300;
        public override int MaxWeight => 182000;
        public override double FuelUsage => 2650;
        public override int MaxDistance => 13200;
        public override int CruiseSpeed => 750;
        public override int EngineCount => 4;
        public override string EngineModel => "НК-12М";
        public override string Vendor => "СНТК Кузнецова";
        public override double MaxThrust => 295;
        public override double Bsfc => 0.165;
        public override double FuselageWidth => 2.68;
        public override ICollection<Weapon> Weapons => new List<Weapon>()
        {
            new Weapon(WeaponType.Cannon, 23, "АМ-23"),
            new Weapon(WeaponType.AerialBomb, 1500, "ФАБ-500")
        };
        public double PressureRatio => 9.5;
        public Direction RotateDirection => Direction.Right;

        public Tu95(string hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}