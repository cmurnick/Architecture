
using Architecture.Departments;
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

            HumanResources hrDept = new HumanResources ( "White", "hr", "Mary Garland", 4, true);

            Sales SalesDept = new Sales("Sales", "Craig", 3, true);

            var departments = new List<DepartmentBase>();

           departments.Add(hrDept);
            departments.Add(SalesDept);

            
            foreach (DepartmentBase dept in departments)
            {
               
                Console.WriteLine($"{ dept.toString()}");
                dept.Meet("meetingPlace");

                double Basebudget = 500.00;
                dept.SetBudget(Basebudget);
                
                
            }

            hrDept.AddPolicy ("Harassment", "don't do it");
            Console.ReadLine();

            //var SalesTeammate = new List<EmployeeName>
            //{
            //    new EmployeeName = "Jason Hoster"; 

            //}

            
           
        }
    }
}
