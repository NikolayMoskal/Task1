namespace Task1.Airplanes
{
    public interface IAircraft : IMachine
    {
        int MaxDistance { get; }
        int CruiseSpeed { get; }
        double FuselageWidth { get; }
    }
}
