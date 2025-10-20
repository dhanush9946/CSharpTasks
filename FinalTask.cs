using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Employee
    {
        public int Id;
        public string Name;
        public int Salary;
        public string Department;
        public int Age;
    }
    class Program1
    {
        public static void Main1()
        {
            List<Employee> employee = new List<Employee>()
            {
                new Employee{Id=1,Name="mob",Salary=10001,Department="IT",Age=23},
                new Employee{Id=2,Name="tob",Salary=30001,Department="HR",Age=44},
                new Employee{Id=3,Name="cob",Salary=15000,Department="Finance",Age=25},
                new Employee{Id=4,Name="rob",Salary=40001,Department="IT",Age=35},
                new Employee{Id=5,Name="cob",Salary=20000,Department="Finance",Age=45}
            };
            var allemployee = employee;

            foreach(var emp in allemployee)
            {
                Console.WriteLine($"{emp.Id}-{emp.Name}-{emp.Salary}-{emp.Department}-{emp.Age}");
            }

            var ageabove = employee.Where(x => x.Age > 30);

            foreach(var emp in ageabove)
            {
                Console.WriteLine($"{emp.Name}-{emp.Age}");
            }


            var descendingsalary = employee.OrderByDescending(x => x.Salary);
            foreach(var emp in descendingsalary)
            {
                Console.WriteLine($"{emp.Name}-{emp.Salary}");
            }

            var groupeddepartment = employee.GroupBy(x => x.Department);
            foreach(var group in groupeddepartment)
            {
                Console.WriteLine($"{group.Key}");
                foreach(var em in group)
                {
                    Console.WriteLine($"{em.Name}");
                }
            }

            var highestsalary = employee.OrderByDescending(x => x.Salary).First();
            Console.WriteLine($"Salary:{highestsalary.Salary}");

            var count = employee.Count(x => x.Department == "IT");
            Console.WriteLine($"IT Department:{count}");
        }

        
    }
}
