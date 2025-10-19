using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    class Program5
    {
        public static void Main5()
        {
            List<Person> people = new List<Person>()
            {
                new Person { Name = "Arjun", Age = 22, City = "Kannur" },
                new Person { Name = "Meera", Age = 28, City = "Kochi" },
                new Person { Name = "Rahul", Age = 30, City = "Kannur" },
                new Person { Name = "Divya", Age = 24, City = "Kozhikode" },
                new Person { Name = "Anu", Age = 27, City = "Kannur" }
            };

            var result = from p in people
                         where p.Age>25 && p.City=="Kannur"
                         select new{p.Name,p.Age};

            Console.WriteLine("People above 25 from Kannur");

            foreach (var person in result)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
    }

}
