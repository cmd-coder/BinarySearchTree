using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace BinarySearchTree
{
    class BST<T>where T:IComparable<T>
    {
        public T NodeData { get; set; }
        public BST<T> Left { get; set; }
        public BST<T> Right { get; set; }
        public BST(T nodedata)
        {
            NodeData = nodedata;
            Left = null;
            Right = null;
        }

        public void Insert(T item)
        {
            T currentValue = NodeData;
            if(currentValue.CompareTo(item)>0)
            {
                leftCount++;
                if(Left==null)
                {
                    Left = new BST<T>(item);
                }
                else
                {
                    Left.Insert(item);
                }
            }
            else
            {
                rightCount++;
                if (Right == null)
                {
                    Right = new BST<T>(item);
                }
                else
                {
                    Right.Insert(item);
                }
            }
        }

        int leftCount = 0;
        int rightCount = 0;
        public void Display()
        {
            if(Left!=null)
            {
                Left.Display();
            }
            Console.WriteLine(NodeData);
            if (Right != null)
            {
                Right.Display();
            }
        }

        bool flag = false;
        public bool Search(T item, BST<T> tree)
        {
            if(tree==null)
                return false;
            if(tree.NodeData.Equals(item))
            {
                flag = true;
            }
            else if(tree.NodeData.CompareTo(item)<0)
            {
                Search(item, tree.Right);
            }
            else
            {
                Search(item, tree.Left);
            }
            return flag;
        }

        public void Size()
        {
            Console.WriteLine("The size of the BST is: " + (1 + leftCount + rightCount));
        }
    }
}
