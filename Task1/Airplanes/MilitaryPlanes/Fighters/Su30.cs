using System.Collections.Generic;
using Task1.Engines.TurboJetEngines;
using Task1.Weapons;

namespace Task1.Airplanes.MilitaryPlanes.Fighters
{
    public class Su30 : Fighter, ITurboFan
    {
        public override string ModificationName => "СМ";
        public override double WingSpan => 14.7;
        public override WingType WingType => WingType.Biplane;
        public override int CrewCount => 1;
        public override int EmptyMass => 18800;
        public override int MaxWeight => 34500;
        public override double FuelUsage => 2500;
        public override int MaxDistance => 5200;
        public override int CruiseSpeed => 1400;
        public override int EngineCount => 2;
        public override string EngineModel => "АЛ-31ФП";
        public override string Vendor => "НПЦ Салют";
        public override double MaxThrust => 122.58;
        public override double Bsfc => 0.75;
        public override double FuselageWidth => 1.8;
        public double PressureRatio => 23;
        public double BypassRatio => 0.56;
        public override ICollection<Weapon> Weapons => new List<Weapon>()
        {
            new Weapon(WeaponType.Rocket, 230.0, "Р-27"),
            new Weapon(WeaponType.Rocket, 80, "С-8"),
            new Weapon(WeaponType.Cannon, 30, "ГШ-30-1"),
            new Weapon(WeaponType.AerialBomb, 250, "КАБ-1500")
        };
    }
}
