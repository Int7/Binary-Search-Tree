using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree tree = new BSTree();
            List<int> list = new List<int> { 1, 2, 3 };
            foreach (int value in list)
            {
                tree.Insert(value);
            }
            //int x;

        }
    }
}
