using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Airplane
    {
        public abstract int EmptyMass { get; }
        public abstract double FuelUsage { get; }
        public abstract int MaxTakeoffWeight { get; }
        public abstract double FuselageWidth { get; }
        public abstract int MaxDistance { get; }
        public abstract int CruiseSpeed { get; }
        public abstract double WingSpan { get; }
        public abstract Engine Engine { get; }
        public abstract WingType WingType { get; }
    }
}
