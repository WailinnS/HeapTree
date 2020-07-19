using System;
using System.Collections.Generic;

namespace BinaryHeapTree
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapTree<int> heapTree = new HeapTree<int>();
            /*
                heap.Insert(1);
                heap.Insert(10);
                heap.Insert(13);
                heap.Insert(3);
                heap.Insert(9);
                heap.Insert(2);
                var value = heap.Pop();
            */
            Random numGen = new Random();

            for (int i = 0; i < 10; i++)
            {
                heapTree.Insert(numGen.Next(101));
                Console.Write($"{heapTree.heap[i]} ");
            }

            List<int> heapNumbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                heapNumbers.Add(heapTree.Pop());
                Console.WriteLine($"{heapNumbers[i]} ");
            }


            ;
            
        }
    }
}
