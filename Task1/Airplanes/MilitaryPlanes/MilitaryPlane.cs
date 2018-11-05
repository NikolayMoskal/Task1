using System.Collections.Generic;
using Task1.Weapons;

namespace Task1.Airplanes.MilitaryPlanes
{
    public abstract class MilitaryPlane : Airplane
    {
        public abstract ICollection<Weapon> Weapons { get; }
    }
}
