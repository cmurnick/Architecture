using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Architecture.Departments;


namespace Architecture
{
    public class HumanResources : DepartmentBase, IKeyCard
    {
        public string Race { get; set; }
        public string LanguageSpoken { get; set; }
        public string Location { get; set; }
        public bool NeedsKeyCard { get; set; }

        private Dictionary<string, string> Policies = new Dictionary<string, string>();

       public HumanResources(string race,string name, string supervisor, int employees, bool keycard) : base(name, supervisor, employees)
        {
            race = Race;
            keycard = NeedsKeyCard;
            toString();
            
        }

        public void AddPolicy(string title, string text)
        {
            Policies.Add(title, text);

            foreach (KeyValuePair<string, string> policy in Policies)
            {
                Console.WriteLine($"{policy.Key} {policy.Value}");
            }
        }

       

        public override void Meet(string meetingPlace)
        {
           meetingPlace =  "Science Room";
            Console.WriteLine($"We are in the {meetingPlace}");
         
        }

        public override void SetBudget(double budget)
        {
            var amount = budget + 20000.00;
            Console.WriteLine($"this department has {amount} to spend");
        }
    }
}
