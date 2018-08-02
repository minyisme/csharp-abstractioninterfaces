using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfacesPractice
{
    public class WorkerBee : Employee
    {
        public WorkerBee(string Name) : base(Name)
        {
        }

        public override int GetSalary()
        {
            return 5;   
        }
    }
}
