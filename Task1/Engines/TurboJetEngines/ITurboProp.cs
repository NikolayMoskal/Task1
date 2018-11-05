namespace Task1.Engines.TurboJetEngines
{
    public interface ITurboProp : ITurboJetEngine
    {
        Direction RotateDirection { get; }
    }
    
    public enum Direction
    {
        Left,
        Right
    }
}