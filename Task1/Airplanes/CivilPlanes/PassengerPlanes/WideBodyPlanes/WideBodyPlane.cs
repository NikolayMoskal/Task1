namespace Task1.Airplanes.CivilPlanes.PassengerPlanes.WideBodyPlanes
{
    public abstract class WideBodyPlane : PassengerPlane
    {
        public int Aisles => 2;
        public override WingType WingType => WingType.HighWingPlane;
    }
}
