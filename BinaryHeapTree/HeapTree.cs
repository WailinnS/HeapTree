using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Text;

namespace BinaryHeapTree
{
    // MinHeap
    public class HeapTree<T> where T : IComparable<T>
    {
        public List<T> heap;
        public HeapTree()
        {
            heap = new List<T>();
        }
        public void Insert(T data)
        {

            //add at the end of the list.
            heap.Add(data);
            HeapifyUp();


        }

        public void Pop()
        {

        }

        //min-heap
        private void HeapifyUp()
        {
            int index = heap.Count - 1;
            //compare temp with its parrent;
            while (index > 0)
            {
                //if the current index is greater than its parrent
                int parentIndex = (index - 1) / 2;

                if (heap[index].CompareTo(heap[parentIndex]) < 0)
                {
                    swap(index, parentIndex);
                }
                index = parentIndex;
            }
        }

        private void swap(int firstIndex, int secondIndex)
        {
            T temp = heap[firstIndex];
            heap[firstIndex] = heap[secondIndex];
            heap[secondIndex] = temp;
        }
    }
}
