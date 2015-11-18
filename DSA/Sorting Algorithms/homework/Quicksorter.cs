namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            this.QuickSort(collection, 0, collection.Count - 1);
        }

        private void QuickSort(IList<T> collection, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int p = this.Partition(collection, left, right);
            this.QuickSort(collection, left, p - 1);
            this.QuickSort(collection, p + 1, right);
        }

        private int Partition(IList<T> collection, int left, int right)
        {
            T pivot = collection[right];
            int start = left;

            for (int index = left; index < right; index++)
            {
                if (collection[index].CompareTo(pivot) <= 0)
                {
                    this.Swap(collection, start, index);
                    start++;
                }                
            }

            this.Swap(collection, start, right);

            return start;
        }

        private void Swap(IList<T> collection, int left, int right)
        {
            T oldValue = collection[left];
            collection[left] = collection[right];
            collection[right] = oldValue;
        }
    }
}
