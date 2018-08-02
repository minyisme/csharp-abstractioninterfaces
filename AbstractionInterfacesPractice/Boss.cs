using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfacesPractice
{ 
    public class Boss : Employee
    {
        public Boss(string name) : base(name)
        {
        }

        public override int GetSalary()
        {
            return 6;
        }
    }
}
