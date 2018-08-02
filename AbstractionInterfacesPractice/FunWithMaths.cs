using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfacesPractice
{
    public class FunWithMaths
    {
        public int MultiplyNumbers(INumberProvider iNumberProvider)
        {
            // Easier way to do below
            //return iNumberProvider.GetNumbers().Aggregate(1, (a, b) => a * b);
            int mult = 1;
            foreach (int i in iNumberProvider.GetNumbers())
            {
                mult *= i;
            }
            return mult;
        }
    }
}
