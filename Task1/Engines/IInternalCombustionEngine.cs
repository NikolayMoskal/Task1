namespace Task1.Engines
{
    public interface IInternalCombustionEngine : IEngine
    {
        double Torque { get; }
    }
}
