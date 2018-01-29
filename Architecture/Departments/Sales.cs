using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Departments
{
    class Sales : DepartmentBase
    {
        public Sales(string name, string supervisor, int employees) : base(name, supervisor, employees)
        {
            var _policies = new Dictionary<string, string>();
        }
    }
}
