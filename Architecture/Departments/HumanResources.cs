using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Architecture.Departments;


namespace Architecture
{
    public class HumanResources : DepartmentBase
    {
        public string Race { get; set; }
        public string LanguageSpoken { get; set; }

        private Dictionary<string, string> _policies = new Dictionary<string, string>();

       public HumanResources(string race,string name, string supervisor, int employees) : base(name, supervisor, employees)
        {
            race = Race;
            toString();
        }
        public void AddPolicy(string title, string text)
        {
            _policies.Add(title, text); 

            foreach(KeyValuePair<string, string> policy in _policies)
            {
                Console.WriteLine($"{policy.Value}");
            }
        }

        public string toString()
        {
            return $"{Name} {Supervisor} {Employees}";
        }
    }
}
