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

        static void Main(string[] args)
        {
            dictionaryTest();
            Console.ReadKey();
        }

        private static void listTest()
        {
            var myList = new List<string>();
            myList.Add("John");
            myList.Add("Mike");
            foreach (var myListElement in myList)
            {
                Console.WriteLine(myListElement.IndexOf('h'));
            }
        }

        private static void dictionaryTest()
        {
            var myDictionary = new Dictionary<string, int>();
            myDictionary.Add("One", 1);
            myDictionary.Add("Two", 2);
            Console.WriteLine(myDictionary.ContainsKey("One"));
            Console.WriteLine(myDictionary["One"]);
            //myDictionary.Add("One", 123);
            myDictionary["One"] = 123;
            int result;
            bool found = myDictionary.TryGetValue("Three", out result);
            Console.WriteLine(found);
            Console.WriteLine(result);
            Console.ReadKey();
            Dump(myDictionary);
        }

        private static void Dump(List<MyListObject> myList)
        {
            if (myList.Count == 0)
                Console.WriteLine("List is empty");
            else
            {
                for (var i = 0; i < myList.Count; i++)
                {
                    Console.WriteLine("Element at {0} : {1}", i, myList[i].Content);
                }
            }
        }
        private static void Dump<TKey, TValue>(Dictionary<TKey, TValue> myDictionary)
        {
            foreach (var keyValuePair in myDictionary)
            {
                Console.WriteLine("Element key : {0} - value : {1}", keyValuePair.Key, keyValuePair.Value);
            }
        }
    }
}
