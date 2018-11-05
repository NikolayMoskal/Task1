using Task1.SeatClasses;

namespace Task1.Airplanes.CivilPlanes
{
    public abstract class CivilPlane : Airplane
    {
        public abstract int SeatCount { get; }
    }
}
