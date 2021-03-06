﻿using System;

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
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(65);
            bst.Insert(63);
            bst.Insert(67);
            bst.Display();
            bst.Size();
            Console.WriteLine("The element 63 exists in the BST: " + bst.Search(63, bst));
        }
    }
}
