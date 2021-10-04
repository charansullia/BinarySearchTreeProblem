using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Add(30);
            binarySearch.Add(70);
            binarySearch.Display();
            Console.ReadKey();
        }
    }
}
        
    


    

