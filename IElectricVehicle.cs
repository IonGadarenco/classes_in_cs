﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_in_cs
{
    internal interface IElectricVehicle
    {
        int ChargeLevel { get; }
        void Charge();
    }
}
