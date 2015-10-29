namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T> : IEnumerable<T>
    {
        private const int InitialCapacity = 10;

        private T[] elements;
        private int index;
        private int capacity;

        public Stack() : this(InitialCapacity)
        {
        }

        public Stack(int capacity)
        {
            this.Capacity = capacity;
            this.elements = new T[capacity];
            this.index = -1;
        }

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public int Count
        {
            get
            {
                return this.index + 1;
            }
        }

        public void Push(T element)
        {
            if (this.Count == this.Capacity)
            {
                IncreaseCapacity();
            }

            index++;
            this.elements[index] = element;
        }  
        
        public T Pop()
        {
            if (this.Count < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            
            this.index--;
            T element = this.elements[this.index + 1];
            return element;
        }     
        
        public T Peek()
        {
            if (this.Count < 1)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return this.elements[this.index];
        } 

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count; i++)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void IncreaseCapacity()
        {
            this.Capacity *= 2;
            T[] newElements = new T[this.Capacity];
            Array.Copy(this.elements, newElements, this.elements.Length);
            this.elements = newElements;
        }
    }
}
