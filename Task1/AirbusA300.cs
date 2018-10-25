using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class AirbusA300 : WideBodyPlane
    {
        public AirbusA300(int placeCount, int distance) : this()
        {
            PlaceCount = placeCount;
            MaxDistance = distance;
        }

        public AirbusA300()
        {
            EmptyMass = 78200;
            CruiseSpeed = 850;
            WingSpan = 44.84;
            MaxTakeoffWeight = 165000;
            FuselageWidth = 5.64;
            Engine = new TurboFan();
            WingType = new LowWingPlane();
        }
    }
}
