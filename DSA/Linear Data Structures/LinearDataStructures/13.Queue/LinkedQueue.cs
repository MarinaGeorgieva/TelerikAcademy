namespace Queue
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedQueue<T> : IEnumerable<T>
    {
        private LinkedList<T> elements;

        public LinkedQueue()
        {
            this.elements = new LinkedList<T>();
        }

        public int Count
        {
            get { return this.elements.Count; }
        }

        public void Enqueue(T element)
        {
            this.elements.AddLast(element);
        }

        public T Dequeue()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            T value = this.elements.First.Value;
            this.elements.RemoveFirst();
            return value;
        }

        public T Peek()
        {
            if (this.elements.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }

            var value = this.elements.First.Value;
            return value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var element in this.elements)
            {
                yield return element;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
