﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class UnitFactory
    {
        public Unit GetUnit(string unitType)
        {
            if (unitType == "temperature")
            {
                return new Temperature();
            } else if (unitType == "length")
            {
                return new Length();
            } else if (unitType == "mass")
            {
                return new Mass();
            } else if (unitType == "speed")
            {
                return new Speed();
            } else if (unitType == "surface area")
            {
                return new SurfaceArea();
            }
            else
            {
                return null;
            }
        }
    }
}
