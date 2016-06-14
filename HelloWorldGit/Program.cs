using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modification on desktop pc
            //second line of mod on desktop pc
            //Second Test
            //Git Testing
            Console.WriteLine("Hello world!");
            Animal Cat = new Animal();
            Cat.Age = 3;
            Console.WriteLine(Cat.Age);
            Dog Spot = new Dog();
            Spot.Name = "Spot";
            Spot.Age = 4;
            Console.WriteLine(Spot.Name + " is " + Spot.Age + " years old.");
        }
    }
}
