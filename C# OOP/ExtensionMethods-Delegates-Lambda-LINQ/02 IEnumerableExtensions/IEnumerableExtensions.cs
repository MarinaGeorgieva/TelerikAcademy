﻿// Problem 2. IEnumerable extensions

// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: 
// sum, product, min, max, average.

namespace _02_IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T sum = (dynamic)0;

            foreach (var item in collection)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T product = (dynamic)1;

            foreach (var item in collection)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T min = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection) where T : IComparable
        {
            T max = collection.First();

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> collection) where T : IComparable
        {
            double average = (dynamic)collection.Sum() / collection.Count();

            return average;
        }
    }
}
