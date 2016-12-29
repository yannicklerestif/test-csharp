using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyListObject : IEquatable<MyListObject>
    {
        public string Content { get; set; }

        public MyListObject(string content)
        {
            Content = content;
        }

        public bool Equals(MyListObject other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Content.Equals(other.Content);
        }

    }
}
