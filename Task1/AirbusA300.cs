namespace Task1
{
    public class AirbusA300 : WideBodyPlane
    {
        public override int PlaceCount { get => 361; }


        public override double FuelValue { get => 0.79; }

        public override int EmptyMass { get => 78200; }

        public override int MaxTakeoffWeight { get => 165000; }

        public override double FuselageWidth { get => 5.64; }

        public override int MaxDistance { get => 7000; }

        public override int CruiseSpeed { get => 875; }

        public override double WingSpan { get => 44.84; }

        public override Engine Engine { get => new TurboFan(); }

        public override WingType WingType { get => new LowWingPlane(); }

        public override double Bsfc => base.Bsfc;
    }
}
