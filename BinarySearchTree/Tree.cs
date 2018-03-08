using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        // member variables
        Node root;
        // constructor
        public Tree()
        {
            root = null;
        }

        // member methods
        public void Add(ref Node root, int value)
        {
            if (root == null)
            {
                Node newNode = new Node(value);
                root = newNode;
                return;
            }
            
            else
            {
                if (root == null)
                {
                    root = new Node(value);
                }

                else if (root.value < value)
                {
                    Add(ref root.left, value);
                }
                
                else if (root.value > value)
                {
                    Add(ref root.right, value);
                }
            }     
        }
    }
}
