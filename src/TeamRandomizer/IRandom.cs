﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamRandomizer
{
    public interface IRandom
    {
        int Next(int minValue, int maxValue);
    }
}
