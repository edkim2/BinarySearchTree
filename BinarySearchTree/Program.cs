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
            tree.Insert(50);
            tree.Insert(70);
            tree.Insert(77);
            tree.Insert(44);
            tree.Insert(5);
            tree.Insert(12);
            tree.Insert(23);
            tree.Search(1);
            Console.ReadLine();
        }
    }
}
