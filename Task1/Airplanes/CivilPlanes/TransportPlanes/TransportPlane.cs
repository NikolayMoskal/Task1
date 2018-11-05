namespace Task1.Airplanes.CivilPlanes.TransportPlanes
{
    public abstract class TransportPlane : CivilPlane, ITransportable
    {
        public abstract double CargoCompartmentVolume { get; }
        public override WingType WingType => WingType.HighWingPlane;
    }
}
