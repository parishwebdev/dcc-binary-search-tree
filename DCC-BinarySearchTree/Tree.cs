using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCC_BinarySearchTree
{
    class Tree
    {
        public Node root;

        public Tree(int initial)
        {
            root = new Node(initial);
        }

        public void Add(int value)
        {
            if (root == null)
            {
                Node nextNode = new Node(value);
                root = nextNode;
                return;
            }
            Node focusNode = root;
            bool isAdded = false;

            while (!isAdded)
            {
                if (focusNode.value > value)
                {
                    if (focusNode.leftNode == null)
                    {
                        Node nextNode = new Node(value);
                        focusNode.leftNode = nextNode;
                        isAdded = true;
                    }
                    else
                    {
                        focusNode = focusNode.leftNode;
                    }
                }
                if(focusNode.value < value)
                {
                    if (focusNode.rightNode == null)
                    {
                        Node nextNode = new Node(value);
                        focusNode.rightNode
                            = nextNode;
                        isAdded = true;
                    }
                    else
                    {
                        focusNode = focusNode.rightNode;
                    }
                }
            }

        }

        public bool Search(int keyValue, Node startNode)
        {
            Node focusNode = startNode;
            while (focusNode != null)
            {
                if (focusNode.value == keyValue)
                {
                    return true;
                }
                if (focusNode.value > keyValue)
                {
                    focusNode = focusNode.leftNode;

                }
                else
                {
                    focusNode = focusNode.rightNode;
                }
            }
            return false;
        }

    }
}
