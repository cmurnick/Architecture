using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Departments
{
    class IT : DepartmentBase
    {
        public IT(string name, string supervisor, int employees) : base(name, supervisor, employees)
        {
        }
    }
}
