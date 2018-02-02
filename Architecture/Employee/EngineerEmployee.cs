using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Employee
{
    public class EngineerEmployee : employee, IFullTime
    {
        public decimal Salary { get; set; }
    }
}
