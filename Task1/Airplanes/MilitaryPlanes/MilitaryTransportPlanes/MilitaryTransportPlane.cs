﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public abstract class MilitaryTransportPlane : MilitaryPlane
    {
        public abstract double CargoCompartmentVolume { get; }
    }
}