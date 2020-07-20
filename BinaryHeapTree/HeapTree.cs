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

        public T Pop()
        {
            T value = heap[0];
            swap(0, heap.Count - 1);
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown();
            return value;
        }

        private void HeapifyDown()
        {
            int parrentIndex = 0;
            
            while(parrentIndex < heap.Count )
            {
                //compare left and right
                int left = (parrentIndex * 2) + 1;
                int right = (parrentIndex * 2) + 2;

                int indexToSwap;
                
                if(left > heap.Count - 1|| right > heap.Count - 1)
                {
                    break;
                }

                if(heap[left].CompareTo(heap[right]) < 0)
                {
                    indexToSwap = left;
                }
                else
                {
                    indexToSwap = right;
                }

                if(heap[parrentIndex].CompareTo(heap[indexToSwap]) > 0)
                {
                    swap(parrentIndex, indexToSwap);
                }

                parrentIndex = indexToSwap;

            }
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
