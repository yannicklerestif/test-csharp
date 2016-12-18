using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Person
    {
        private string name;

        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Agett { get; set; }

        public Person()
        {
            Console.WriteLine("Person() called");
        }

        public Person(string name) : this()
        {
            Console.WriteLine("Person(name) called");
            this.name = name;
        }

        ~Person()
        {
            Console.WriteLine("~Person() called");
        }

        public void SayHi()
        {
            Console.WriteLine("Hello ! I'm " + this.Name);
            Console.WriteLine("My age is " + this.Agett);
        }
    }
}
