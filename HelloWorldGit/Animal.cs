using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldGit
{
    class Animal
    {
        private double age;
        private string name;

        public double Age
        {
            get
            {
                //Console.WriteLine("Run the getter");
                return this.age;
            }
            set
            {
                this.age = value;
                //Console.WriteLine("Run the setter");
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
