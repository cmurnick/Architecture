using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Architecture
{
    class Program
    {
        static void Main(string[] args)
        {
            HumanResources hr1 = new HumanResources ("White", "hr", "Mary Garland", 4);
            HumanResources hr2 = new HumanResources("Asian", "hr", "Jason Hoster", 3);
            HumanResources hr3 = new HumanResources("Black", "hr", "Hadleigh Tweedall", 5);

            var hrList = new List<HumanResources>
            {
                hr1,
                hr2,
                hr3
            };

            foreach (var hrPerson in hrList)
            {
                Console.WriteLine(hrPerson.toString());

            }
            Console.ReadLine();
            



            //HumanResources myHR = new HumanResources("HR", "Mary", 2, "White");
            //Console.WriteLine($"my department, {myHR.name} " )
            //}

        }
    }
}
