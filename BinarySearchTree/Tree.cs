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
        public Node root;

        // constructor
        public Tree()
        {

        }

        public Tree(int value)
        {
            root = new Node(value);
        }

        // member methods
        public void AddRoot(int value)
        {
            root = new Node(value);
        }

        public void Insert(int input)
        {
            Node replacementNode = new Node(input);
            if (root == null)
            {
                AddRoot(input);
            }
            else if (root.Right == null)
            {
                if (replacementNode.NumberInNode >= root.NumberInNode)
                {
                    root.Right = replacementNode;
                    replacementNode.Parent = root;
                }
            }
            else if (replacementNode.NumberInNode >= root.NumberInNode)
            {
                Add(root.Right, replacementNode);
            }
            else if (root.Left == null)
            {
                if (replacementNode.NumberInNode < root.NumberInNode)
                {
                    root.Left = replacementNode;
                    replacementNode.Parent = root;
                }
            }
            else if (replacementNode.NumberInNode < root.NumberInNode)
            {
                Add(root.Left, replacementNode);
            }
        }
        public void Add(Node node, Node replacementNode)
        {
            if (replacementNode.NumberInNode >= node.NumberInNode && node.Right == null)
            {
                node.Right = replacementNode;
                replacementNode.Parent = node;
            }
            else if (replacementNode.NumberInNode >= node.NumberInNode)
            {
                Add(node.Right, replacementNode);
            }
            else if (replacementNode.NumberInNode < node.NumberInNode && node.Left == null)
            {
                node.Left = replacementNode;
                replacementNode.Parent = node;
            }
            else if (replacementNode.NumberInNode < node.NumberInNode)
            {
                Add(node.Left, replacementNode);
            }
        }
        public bool Search(Node node, int value)
        {
            if (node == null)
            {
                return false;
            }
            if (node.value == value)
            {
                return true;
            }
            else if (node.value < value)
            {
                return Search(node.left, value);
            }
            else if (node.value > value)
            {
                return Search(node.right, value);
            }
            return false;
        }

        public void Display(Node node)
        {
            if (node == null)
                return;
            if (node == node.left)
            {
                Console.WriteLine("Left" + node.value);
            }
            else
            {
                Console.WriteLine("Right" + node.value);
            }
        }
    }
}
