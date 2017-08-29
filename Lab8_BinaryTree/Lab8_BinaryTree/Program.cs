using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            String buffer = "";

            /* int nodes
             * 1 = A
             * 2 = B
             * 3 = C
             * 4 = D
             * 5 = E
             * 6 = F
             * 7 = G
             * 8 = H
            */
            Node<int> tree = new Node<int>(1);
            tree.Left = new Node<int>(2);
            tree.Right = new Node<int>(3);
            tree.Left.Left = new Node<int>(4);
            tree.Left.Right = new Node<int>(5);
            tree.Right.Left = new Node<int>(6);
            tree.Right.Right = new Node<int>(7);
            tree.Left.Right.Right = new Node<int>(8);

            /* string nodes (for easier reading) */
            Node<string> tree1 = new Node<string>("A");
            tree1.Left = new Node<string>("B");
            tree1.Right = new Node<string>("C");
            tree1.Left.Left = new Node<string>("D");
            tree1.Left.Right = new Node<string>("E");
            tree1.Right.Left = new Node<string>("F");
            tree1.Right.Right = new Node<string>("G");
            tree1.Left.Right.Right = new Node<string>("H");

            Console.WriteLine("Test int nodes");
            BinTree<int> myTree = new BinTree<int>(tree);
            myTree.PreOrder(ref buffer);
            Console.WriteLine("PreOrder: {0}", buffer);
            buffer = null;

            myTree.InOrder(ref buffer);
            Console.WriteLine("InOrder: {0}", buffer);
            buffer = null;

            myTree.PostOrder(ref buffer);
            Console.WriteLine("PostOrder: {0}", buffer);
            buffer = null;

            Console.WriteLine();

            Console.WriteLine("Test string nodes");
            BinTree<string> myTree1 = new BinTree<string>(tree1);
            myTree1.PreOrder(ref buffer);
            Console.WriteLine("PreOrder: {0}", buffer);
            buffer = null;

            myTree1.InOrder(ref buffer);
            Console.WriteLine("InOrder: {0}", buffer);
            buffer = null;

            myTree1.PostOrder(ref buffer);
            Console.WriteLine("PostOrder: {0}", buffer);
            buffer = null;

            Console.ReadKey();
        }
    }
}
