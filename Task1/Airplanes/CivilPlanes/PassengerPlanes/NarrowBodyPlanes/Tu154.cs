namespace Task1
{
    public class Tu154 : NarrowBodyPlane
    {
        public override int PlaceCount { get => 164; }

        public override double FuelValue { get => 1.02; }

        public override int EmptyMass { get => 51000; }

        public override double FuelUsage { get => 6200; }

        public override int MaxTakeoffWeight { get => 100; }

        public override double FuselageWidth { get => 3.8; }

        public override int MaxDistance { get => 2650; }

        public override int CruiseSpeed { get => 900; }

        public override double WingSpan { get => 37.55; }

        public override Engine Engine { get => new TurboFan(); }

        public override WingType WingType { get => new LowWingPlane(); }
    }
}
