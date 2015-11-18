namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            bool found = false;

            foreach (var element in this.Items)
            {
                if (element.CompareTo(item) == 0)
                {
                    found = true;
                }
            }

            return found;
        }

        public bool BinarySearch(T item)
        {
            bool found = false;

            int min = 0;
            int max = this.Items.Count - 1;

            while (min.CompareTo(max) <= 0)
            {
                int middle = min + ((max - min) / 2);

                if (this.Items[middle].CompareTo(item) == 0)
                {
                    found = true;
                    break;
                }
                else if (this.Items[middle].CompareTo(item) < 0)
                {
                    min = middle + 1;
                }
                else
                {
                    max = middle - 1;
                }
            }

            return found;
        }

        // Fisher–Yates shuffle algorithm with complexity O(n)
        public void Shuffle()
        {
            Random random = new Random();
            for (int index = 0; index < this.Items.Count - 1; index++)
            {
                int randomIndex = random.Next(index, this.Items.Count);
                T oldValue = this.Items[randomIndex];
                this.Items[randomIndex] = this.Items[index];
                this.Items[index] = oldValue;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
