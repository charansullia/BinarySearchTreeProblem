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
            binarySearch.Add(22);
            binarySearch.Add(40);
            binarySearch.Add(60);
            binarySearch.Add(95);
            binarySearch.Add(65);
            binarySearch.Add(63);
            binarySearch.Add(67);
            binarySearch.Add(11);
            binarySearch.Add(3);
            binarySearch.Add(16);
            binarySearch.Display();
            binarySearch.GetSize();
            Console.ReadKey();
        }
    }
}
        
    


    

