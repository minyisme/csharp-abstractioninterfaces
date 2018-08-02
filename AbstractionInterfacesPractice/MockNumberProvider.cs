﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfacesPractice
{
    public class MockNumberProvider : INumberProvider
    {
        public int[] GetNumbers()
        {
            return new int[] { 1, 2, 3 };
        }
    }
}
