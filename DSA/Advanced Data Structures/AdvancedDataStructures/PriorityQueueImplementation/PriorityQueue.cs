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
                if (this.data[childIndex].CompareTo(this.data[parentIndex]) >= 0)
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
            lastIndex--;

            int parentIndex = 0;
            while (true)
            {
                int leftChildIndex = 2 * parentIndex + 1;
                if (leftChildIndex > lastIndex)
                {
                    break;
                }
               
                int rightChildIndex = 2 * parentIndex + 2;
                if (rightChildIndex <= lastIndex && 
                    this.data[rightChildIndex].CompareTo(this.data[leftChildIndex]) < 0)
                {
                    leftChildIndex = rightChildIndex;
                }

                if (this.data[leftChildIndex].CompareTo(this.data[parentIndex]) >= 0)
                {
                    break;
                }

                T value = this.data[leftChildIndex];
                this.data[leftChildIndex] = this.data[parentIndex];
                this.data[parentIndex] = value;
                parentIndex = leftChildIndex;
            }

            return firstItem;
        }

        public T Peek()
        {
            T firstItem = this.data[0];
            return firstItem;
        }
    }
}
