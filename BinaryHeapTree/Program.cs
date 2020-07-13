using System;
using System.Collections.Generic;

namespace BinaryHeapTree
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapTree<int> heap = new HeapTree<int>();

            heap.Insert(1);
            heap.Insert(10);
            heap.Insert(13);
            heap.Insert(3);
            heap.Insert(9);
            heap.Insert(2);
            ;
            
        }
    }
}
