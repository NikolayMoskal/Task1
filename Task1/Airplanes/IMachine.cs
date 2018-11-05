namespace Task1.Airplanes
{
    public interface IMachine
    {
        int CrewCount { get; }
        int EmptyMass { get; }
        int MaxWeight { get; }
        double FuelUsage { get; }
    }
}
