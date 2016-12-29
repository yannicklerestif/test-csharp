using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyGenericList<T>
    {
        private class MyNode<U>
        {
            public U Data { get; set; }
            public MyNode<U> Next { get; set; }

            public MyNode(U data)
            {
                Data = data;
            }
        }

        MyNode<T> Head { get; set; }
        
        public MyGenericList()
        {
            Head = null;
        }

        public void Insert(T newElement)
        {
            var oldHead = Head;
            Head = new MyNode<T>(newElement);
            Head.Next = oldHead;
        }

        public void remove()
        {
            if (Head == null)
                return;
            Head = Head.Next;
        }

        public void Dump()
        {
            if(Head == null)
                Console.WriteLine("List is empty");

            int count = 0;
            var current = Head;
            do
            {
                Console.WriteLine("Element #{0} : {1}", count, current.Data);
                count++;
                current = current.Next;
            } while (current != null);
        }

    }
}
