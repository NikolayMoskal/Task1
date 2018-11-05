namespace Task1.Weapons
{
    public class Weapon
    {
        private WeaponType _weaponType;
        private double _caliber;
        private string _model;

        public Weapon(WeaponType weaponType, double caliber, string model)
        {
            _weaponType = weaponType;
            _caliber = caliber;
            _model = model;
        }
    }
}