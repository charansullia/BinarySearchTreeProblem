using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.RightTree = null;
            this.LeftTree = null;
        }
        int LeftCount = 0, RightCount = 0;
        bool result = false;
        public void Add(T data)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(data)) > 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(data);
                else
                    this.LeftTree.Add(data);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(data);
                else
                    this.RightTree.Add(data);
            }
        }
        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.LeftCount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.RightTree != null)
            {
                this.RightCount++;
                this.RightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.LeftCount + this.RightCount));
        }
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                IfExists(element, node.LeftTree);
            if (element.CompareTo(node.NodeData) > 0)
                IfExists(element, node.RightTree);
            return result;
        }
    }
}












   

    


















