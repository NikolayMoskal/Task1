namespace Task1
{
    public class AirbusA320 : AirbusA300
    {
        public override int PlaceCount { get => 180; }

        public override double FuelValue { get => 0.72; }

        public override int MaxTakeoffWeight { get => 77000; }

        public override double FuselageWidth { get => 3.95; }

        public override int MaxDistance { get => 6150; }

        public override int CruiseSpeed { get => 840; }

        public override double WingSpan { get => 34.1; }

        public override double Bsfc => base.Bsfc;
    }
}
