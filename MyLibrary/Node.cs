using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Node
    {
        public short Value { get; set; }
        public Node? Next { get; set; }

        public Node(short value)
        {
            Value = value;
            Next = null;
        }
    }
}
