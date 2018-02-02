using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Employee
{
    public class AssemblyLine : employee, IPartTime
    {
        public double Hourly { get; set; }
    }
}
