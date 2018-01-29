using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture
{
    public class DepartmentBase
    {
        public string Name { get; set; }
        public string Supervisor { get; set; }
        public int Employees { get; set; }

        // You can create properties, if needed

        
        
        // Constructor method
        public DepartmentBase(string name, string supervisor, int employees)
        {
            Name = name;
            Supervisor = supervisor;
            Employees = employees;
        }
    }
}
