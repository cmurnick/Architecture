using Architecture.Employee;
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

            HumanResources hrDept = new HumanResources ( "White", "hr", "Mary Garland", 4);

            Sales SalesDept = new Sales("Sales", "Craig", 3);

            var departments = new List<DepartmentBase>();

           departments.Add(hrDept);
            departments.Add(SalesDept);

            //hrDept.Meet("meetingPlace");
            //SalesDept.Meet("meetingPlace");


            foreach (DepartmentBase dept in departments)
            {
               
                Console.WriteLine($"{ dept.toString()}");
                dept.Meet("meetingPlace");
            }

           


            hrDept.AddPolicy ("Harassment", "don't do it");
            Console.ReadLine();


            EngineerEmployee ee = new EngineerEmployee()
            {
                FirstName = "Caitlin",
                LastName = "Murnick",
                Salary = 100000


            };


            AssemblyLine Aee = new AssemblyLine()
            {
                FirstName = "Pride",
                LastName = "Scanlan",
                Hourly = 15
            };

            List<EngineerEmployee> elist = new List<EngineerEmployee>()
            {
                //Aee,
                ee
            };
         
            //foreach(var employee in elist)
            //{
            //    Console.WriteLine(employee.LastName);
               
            //}
            //Console.ReadLine();

            
           
        }
    }
}
