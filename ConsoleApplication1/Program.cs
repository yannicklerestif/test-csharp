using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static int MyFunction(int someVar, out int someOtherVar)
        {
            someOtherVar = someVar * 1111;
            return someVar * 1000;
        }

        static void MyFunction(object o)
        {
            Console.WriteLine("MyFunction(object) called with " + o);
        }

        static void MyFunction(string s)
        {
            Console.WriteLine("MyFunction(string) called with " + s);
        }

        static void FileOperations()
        {
            string fileName = "C:/Users/Yannick/test.txt";
            string fileContent = null;
            using (var stream = File.Open(fileName, FileMode.OpenOrCreate))
            {
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    fileContent = reader.ReadToEnd();
                }
            }
            Console.WriteLine(fileContent);
            Console.ReadKey();

            using (var writeStream = File.Open(fileName, FileMode.Append))
            {
                using (var streamWriter = new StreamWriter(writeStream, Encoding.UTF8))
                {
                    streamWriter.Write("\r\nSome more text, written at {0}", DateTime.Now);
                }
            }

        }

        static void MyGenericFunction<T>(T obj)
        {
            Console.WriteLine(obj.ToString());
            Console.WriteLine(typeof(T));
        }

        static void Main(string[] args)
        {
            MyGenericFunction("abcd");
            Console.ReadKey();
        }
    }
}
