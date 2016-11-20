using System;
using BinarySearchTree;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var bst = new BinarySearchTree<int>();

            //int[] arr = {8,3,10,1,6,14,4,7,13};
            int[] arr = { 4, 2, 5, 1, 3, 7, 6, 8 };
            //int[] arr = {5, 2, 18, -4, 3, 21, 19, 25};

            foreach (var item in arr)
                bst.Add(item);

            bst.Remove(5);

            foreach (var item in bst)
                Console.Write(item + " ");

            Console.WriteLine("\nTap to continue...");
            Console.ReadKey(true);
        }
    }
}
