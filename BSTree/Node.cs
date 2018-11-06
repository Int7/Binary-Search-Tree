using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class Node
    {
        public Node(int _value)
        {
            value = _value;
        }
        public int value;
        public Node Lchild;
        public Node Rchild;
    }
}
