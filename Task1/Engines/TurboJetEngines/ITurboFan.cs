namespace Task1.Engines.TurboJetEngines
{
    public interface ITurboFan : ITurboJetEngine
    {
        double BypassRatio { get; }
    }
}
