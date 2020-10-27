using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree!");
            BST<int> bst =new BST<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
        }
    }
}
