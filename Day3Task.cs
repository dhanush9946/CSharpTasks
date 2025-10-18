using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Animal
    {
        public string Name;
        public int age;

        public virtual void Speak()
        {
            Console.WriteLine($"Name:{Name}, age:{age}");
        }
    }
    class Dog : Animal
    {
        public  string breed;

       

        public override void Speak()
        {
            Console.WriteLine($"Name:{Name},age:{age},breed:{breed}");
        }
    }
    class Cat : Animal
    {

        public string Name;

        public Cat(string name)
        {
            Name = name;
        }
        public void Meow()
        {
            Console.WriteLine($"{Name} is Meowing");
        }
    }
    class Abc
    {
        public static void Main1()
        {
            Animal a = new Animal();
            a.Name = "Jack";
            a.age = 5;
            a.Speak();

            Dog b = new Dog();
            b.breed = "GermanSheppered";
            b.Name = "Mikku";
            b.age = 3;
            b.Speak();

            Cat c=new Cat("Mittu");
            c.Meow();

            
            
        }
    }
}
