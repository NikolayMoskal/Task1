namespace Task1
{
    public abstract class PassengerPlane : CivilPlane
    {
        public const int FuelConst = 32;
        public abstract int PlaceCount { get; }
        public abstract double FuelValue { get; }
        public virtual double Bsfc { get => FuelConst * FuelValue; }
    }
}
