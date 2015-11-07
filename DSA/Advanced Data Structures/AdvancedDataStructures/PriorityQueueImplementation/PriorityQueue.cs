namespace PriorityQueueImplementation
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Enqueue(T item)
        {
            this.data.Add(item);
            int childIndex = this.data.Count - 1;
            while (childIndex > 0)
            {
                int parentIndex = (childIndex - 1) / 2;
                if (this.data[childIndex].CompareTo(this.data[parentIndex]) <= 0)
                {
                    break;
                }

                T value = this.data[childIndex];
                this.data[childIndex] = this.data[parentIndex];
                this.data[parentIndex] = value;
                childIndex = parentIndex;
            }
        }

        public T Dequeue()
        {
            if (this.data.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty!");
            }

            int lastIndex = this.data.Count - 1;
            T firstItem = this.data[0];
            this.data[0] = this.data[lastIndex];
            this.data.RemoveAt(lastIndex);

            MaxHeapify(this.data, 0);

            return firstItem;
        }

        public T Peek()
        {
            T firstItem = this.data[0];
            return firstItem;
        }

        private void MaxHeapify(List<T> data, int parentIndex)
        {
            int leftChildIndex = 2 * parentIndex + 1;
            int rightChildIndex = 2 * parentIndex + 2;
            int largest = parentIndex;

            if (leftChildIndex < data.Count && data[leftChildIndex].CompareTo(data[largest]) > 0)
            {
                largest = leftChildIndex;
            }

            if (rightChildIndex < data.Count && data[rightChildIndex].CompareTo(data[largest]) > 0)
            {
                largest = rightChildIndex;
            }

            if (largest != parentIndex)
            {
                T value = data[parentIndex];
                data[parentIndex] = data[largest];
                data[largest] = value;
                MaxHeapify(data, largest);
            }
        }
    }
}
