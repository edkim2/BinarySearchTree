using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Node node = new Node(0);
            tree.Add(ref node, 50);
            tree.Add(ref node, 75);
            tree.Add(ref node, 35);
            tree.Add(ref node, 10);
            tree.Add(ref node, 80);
            Console.WriteLine(tree);
            Console.ReadLine();
        }
    }
}
