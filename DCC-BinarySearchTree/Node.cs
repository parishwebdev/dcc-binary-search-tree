using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_BinarySearchTree
{
    class Node
    {
        public int value;
        public Node leftNode;
        public Node rightNode;

        public Node(int initial)
        {
            value = initial;
            leftNode = null;
            rightNode = null;
        }
    }
}
