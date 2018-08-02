﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfacesPractice
{
    public class EvenNumberProvider : INumberProvider
    {
        public int[] GetNumbers()
        {
            return new int[] { 2, 4, 6, 8, 10 };
        }
    }
}
