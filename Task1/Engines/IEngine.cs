namespace Task1.Engines
{
    public interface IEngine
    {
        int EngineCount { get; }
        string EngineModel { get; }
        string Vendor { get; }
        double MaxThrust { get; }
        double Bsfc { get; }
    }
}
