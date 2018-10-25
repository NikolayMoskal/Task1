using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class Airplane
    {
        public int EmptyMass { get; set; }
        public int MaxTakeoffWeight { get; set; }
        public double FuselageWidth { get; set; }
        public int MaxDistance { get; set; }
        public int CruiseSpeed { get; set; }
        public double WingSpan { get; set; }
        public Engine Engine { get; protected set; }
        public WingType WingType { get; protected set; }

        public Monoplane Monoplane
        {
            get => default(Monoplane);
            set
            {
            }
        }
    }
}
