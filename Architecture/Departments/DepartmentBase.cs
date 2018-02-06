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
        private string _employeeName;
        public string EmployeeName
        {
            get; 
        }

        // You can create properties, if needed

        
        
        // Constructor method
        public DepartmentBase(string name, string supervisor, int employees)
        {
            Name = name;
            Supervisor = supervisor;
            Employees = employees;
        }

        public string toString()
        {
            return $"{Name} {Supervisor} {Employees}";
        }

        public virtual void Meet(string meetingPlace)
        {
            meetingPlace = "toilet";
        }

        public virtual void SetBudget(double budget)
        {
           budget = 5.00;
           var basebudget = budget;
           
            
        }


       
    }
}
