using System.Collections.Generic;
using Task1.Engines.TurboJetEngines;
using Task1.Weapons;

namespace Task1.Airplanes.MilitaryPlanes.Fighters
{
    public class Su27 : Fighter, ITurboFan
    {
        private string _hullNumber;
        public override string ModificationName => "СМ";
        public override double WingSpan => 14.698;
        public override WingType WingType => WingType.Biplane;
        public override int CrewCount => 1;
        public override int EmptyMass => 16870;
        public override int MaxWeight => 33000;
        public override double FuelUsage => 2500;
        public override int MaxDistance => 3790;
        public override int CruiseSpeed => 850;
        public override int EngineCount => 2;
        public override string EngineModel => "АЛ-31Ф";
        public override string Vendor => "НПО Сатурн";
        public override double MaxThrust => 75.217;
        public override double Bsfc => 0.75;
        public override double FuselageWidth => 2.0;
        public override ICollection<Weapon> Weapons => new List<Weapon>()
        {
            new Weapon(WeaponType.Cannon, 30, "ГШ-30-1"),
            new Weapon(WeaponType.Rocket, 65, "Р-8"),
            new Weapon(WeaponType.Rocket, 80, "Х-29"),
            new Weapon(WeaponType.Rocket, 80, "С-8"),
            new Weapon(WeaponType.AerialBomb, 250, "КАБ-500")
        };
        public double PressureRatio => 23;
        public double BypassRatio => 0.571;

        public Su27(string hullNumber)
        {
            _hullNumber = hullNumber;
        }
    }
}