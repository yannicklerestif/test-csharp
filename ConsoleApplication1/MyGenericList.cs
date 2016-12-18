using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyGenericList<T>
    {
        private class MyNode
        {
            public T Data { get; set; }
            T Next { get; set; }
            T Previous { get; set; }

            public MyNode(T data)
            {
                Data = data;
            }
        }

        MyNode Head { get; set; }
        MyNode Tail { get; set; }
        
        MyGenericList()
        {
            Head = null;
            Tail = null;
        }

        public void Insert(T newElement)
        {
            MyNode newNode = new MyNode(newElement);

            MyNode oldHead = Head;

        }

        public void WriteAll()
        {
            
        }

    }
}
