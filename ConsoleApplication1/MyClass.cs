using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyClass : MyInterface
    {
        public static void SomeMethod()
        {
            Console.WriteLine("Executing some static method");
        }

        public string SomeMethod(string someParam)
        {
            throw new NotImplementedException();
        }
    }

}