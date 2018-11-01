namespace Task1
{
    public class AirbusA320 : NarrowBodyPlane
    {
        public override int PlaceCount { get => 180; }

        public override double FuelValue { get => 0.72; }

        public override int MaxTakeoffWeight { get => 77000; }

        public override double FuselageWidth { get => 3.95; }

        public override int MaxDistance { get => 6150; }

        public override int CruiseSpeed { get => 840; }

        public override double WingSpan { get => 34.1; }

        public override int EmptyMass { get => 77000; }

        public override double FuelUsage { get => 2400; }

        public override Engine Engine { get => new TurboFan(); }

        public override WingType WingType { get => new LowWingPlane(); }
    }
}
