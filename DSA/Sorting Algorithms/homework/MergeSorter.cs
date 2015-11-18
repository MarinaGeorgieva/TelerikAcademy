namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class MergeSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            IList<T> collectionB = new T[collection.Count];
            this.TopDownSplitMerge(collection, 0, collection.Count, collectionB);
        }

        private void TopDownSplitMerge(IList<T> collectionA, int start, int end, IList<T> collectionB)
        {
            if (end - start < 2)
            {
                return;
            }

            int middle = (start + end) / 2;

            this.TopDownSplitMerge(collectionA, start, middle, collectionB);
            this.TopDownSplitMerge(collectionA, middle, end, collectionB);
            this.TopDownMerge(collectionA, start, middle, end, collectionB);
            this.CopyCollection(collectionA, start, end, collectionB);
        }

        private void TopDownMerge(IList<T> collectionA, int start, int middle, int end, IList<T> collectionB)
        {
            int leftStart = start;
            int rightStart = middle;

            for (int i = start; i < end; i++)
            {
                if (leftStart < middle && (rightStart >= end || collectionA[leftStart].CompareTo(collectionA[rightStart]) <= 0))
                {
                    collectionB[i] = collectionA[leftStart];
                    leftStart++;
                }
                else
                {
                    collectionB[i] = collectionA[rightStart];
                    rightStart++;
                }
            }
        }

        private void CopyCollection(IList<T> collectionA, int start, int end, IList<T> collectionB)
        {
            for (int k = start; k < end; k++)
            {
                collectionA[k] = collectionB[k];
            }
        }
    }
}
