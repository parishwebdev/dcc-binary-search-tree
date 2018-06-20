using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree bst = new Tree(50);
            bst.Add(40);
            bst.Add(60);
            bst.Add(62);
            bst.Add(58);
            bst.Add(42);
            bst.Add(38);

            bool nodeToFind = bst.Search(62, bst.root);
            Console.WriteLine(nodeToFind);
            Console.ReadLine();
        }
    }
}
