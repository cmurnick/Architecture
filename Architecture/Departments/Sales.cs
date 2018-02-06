using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Departments
{
    class Sales : DepartmentBase, ISecurity
    {
        public bool GoToSecurity { get; set; }

        public Sales(string name, string supervisor, int employees, bool security) : base(name, supervisor, employees)
        {
            security = GoToSecurity;
            var _policies = new Dictionary<string, string>();
            
        }

        //public void InterfaceMethod()
        //{
        //    Console.WriteLine($"People in {name} need to")
        //}

        public override void Meet(string meetingPlace)
        {
            meetingPlace = "Detention";
            Console.WriteLine($"We are in {meetingPlace}");
        }

        public override void SetBudget(double budget)
        {

            var amount = budget + 10000.00;
            Console.WriteLine($"this department has {amount} to spend");
        }

    
    }
}
