namespace Task1.Airplanes.MilitaryPlanes.MilitaryTransportPlanes
{
    public abstract class MilitaryTransportPlane : MilitaryPlane, ITransportable
    {
        public abstract double CargoCompartmentVolume { get; }
    }
}
