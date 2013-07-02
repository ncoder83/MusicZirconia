using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicGenerator.Common
{
    public class PriorityQueue<T>
    {
        private C5.IntervalHeap<T> heap;

        public PriorityQueue(IComparer<T> comparer)
        {
            heap = new C5.IntervalHeap<T>(comparer);
        }

        public bool IsEmpty { get { return heap.IsEmpty; } }

        public int Count { get { return heap.Count; } }

        public T Dequeue()
        {
            T item = heap.FindMin();
            heap.DeleteMin();
            return item;
        }

        public T Peek()
        {
            return heap.FindMin();
        }

        public void Enqueue(T item)
        {
            heap.Add(item);
        }
    }
}
