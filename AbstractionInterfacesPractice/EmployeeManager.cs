using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionInterfacesPractice
{
    public class EmployeeManager
    {
        public int GetTotalSalary(Employee[] employees)
        {
            var sum = 0;

            foreach (Employee employee in employees)
            {
                sum += employee.GetSalary();
            }

            // more efficient way to do the above foreach loop
            //employees.Select(employee => employee.GetSalary()).Sum();
            return sum;
        }
    }
}
