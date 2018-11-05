using System.Collections.Generic;
using Task1.Engines.TurboJetEngines;
using Task1.Weapons;

namespace Task1.Airplanes.MilitaryPlanes.AttackAirplanes
{
    public class Su25 : AttackAirplane, ITurboJetEngine
    {
        private string _hullNumber;
        public override string ModificationName => "К";
        public override double WingSpan => 14.36;
        public override WingType WingType => WingType.HighWingPlane;
        public override int CrewCount => 1;
        public override int EmptyMass => 9315;
        public override int MaxWeight => 17600;
        public override double FuelUsage => 2100;
        public override int MaxDistance => 1950;
        public override int CruiseSpeed => 750;
        public override int EngineCount => 2;
        public override string EngineModel => "Р-95Ш";
        public override string Vendor => "УМПО";
        public override double MaxThrust => 40.2;
        public override double Bsfc => 0.86;
        public override double FuselageWidth => 1.9;
        public override ICollection<Weapon> Weapons => new List<Weapon>()
        {
            new Weapon(WeaponType.Cannon, 30, "ГШ-30-2"),
            new Weapon(WeaponType.Rocket, 65, "Р-8"),
            new Weapon(WeaponType.Rocket, 80, "Х-25"),
            new Weapon(WeaponType.Rocket, 80, "С-8"),
            new Weapon(WeaponType.AerialBomb, 250, "ФАБ-500")
        };
        public double PressureRatio => 8.66;

        public Su25(string hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}