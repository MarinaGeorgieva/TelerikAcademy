namespace DefiningClassesProblem5_7
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private T[] list;
        private int count;

        public GenericList(int capacity)
        {
            this.list = new T[capacity];
            this.count = 0;
        }        

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.list[index];
            }

            set
            {
                if (index < 0 || index >= this.Count)
                {
                    throw new IndexOutOfRangeException();
                }

                this.list[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Count >= this.list.Length)
            {
                AutoGrow();
            }

            this.list[count] = element;
            this.count++;
        }

        public void InsertAt(int index, T element)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException();
            }

            if (this.Count >= this.list.Length - 1)
            {
                AutoGrow();
            }
         
            this.count++;

            T[] copyArray = new T[this.Count];
            for (int i = 0; i < index; i++)
            {
                copyArray[i] = this.list[i];
            }
            copyArray[index] = element;

            for (int i = index + 1; i < this.Count; i++)
            {
                copyArray[i] = this.list[i - 1];
            }

            this.list = new T[copyArray.Length];
            for (int i = 0; i < this.Count; i++)
            {
                this.list[i] = copyArray[i];
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= this.list.Length)
            {
                throw new IndexOutOfRangeException();
            }

            T removed = list[index];
            
            for (int i = index; i < this.Count - 1; i++)
            {
                this.list[i] = this.list[i + 1];
            }

            this.count--;
        }

        public void Clear()
        {
            this.count = 0;
        }

        public int IndexOf(T element)
        {
            int index = -1;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.list[i].CompareTo(element) == 0)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        public T Min()
        {
            T minElement = this.list[0];

            for (int i = 1; i < this.list.Length; i++)
            {
                if (this.list[i].CompareTo(minElement) < 0)
                {
                    minElement = this.list[i];
                }
            }

            return minElement;
        }

        public T Max()
        {
            T maxElement = this.list[0];

            for (int i = 1; i < this.list.Length; i++)
            {
                if (this.list[i].CompareTo(maxElement) > 0)
                {
                    maxElement = this.list[i];
                }
            }

            return maxElement;
        }

        private void AutoGrow()
        {
            int newSize = this.list.Length * 2;
            T[] newList = new T[newSize];

            for (int i = 0; i < this.Count; i++)
            {
                newList[i] = this.list[i];
            }

            this.list = newList;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < this.list.Length; i++)
            {
                result.Append(this.list[i]);
                if (i != this.list.Length - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }
    }
}
