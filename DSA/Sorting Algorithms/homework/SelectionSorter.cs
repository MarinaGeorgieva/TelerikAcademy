namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                int minElementIndex = i;

                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[minElementIndex]) < 0)
                    {
                        minElementIndex = j;
                    }
                }

                if (minElementIndex != i)
                {
                    this.Swap(collection, i, minElementIndex);
                }
            }
        }

        private void Swap(IList<T> collection, int left, int right)
        {
            T oldValue = collection[left];
            collection[left] = collection[right];
            collection[right] = oldValue;
        }
    }
}
