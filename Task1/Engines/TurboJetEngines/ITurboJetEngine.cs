namespace Task1.Engines.TurboJetEngines
{
    public interface ITurboJetEngine : IEngine
    {
        double PressureRatio { get; }
    }
}
