using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_IEnumerableExtensions
{
    class IEnumerableExtensionsTest
    {
        static void Main(string[] args)
        {
            IEnumerable<int> collectionOfInts = new List<int>() { 4, 2, 1, 5, 3, 7, 6 };

            Console.WriteLine("Sum: {0} \nProduct: {1} \nAverage: {2} \nMin element: {3} \nMax element: {4}", 
                collectionOfInts.Sum(), collectionOfInts.Product(), collectionOfInts.Average(), 
                collectionOfInts.Min(), collectionOfInts.Max());

            Console.WriteLine();

            IEnumerable<double> collectionOfDoubles = new List<double>() { 4.6, 2.8, 1.3, 5.2, 3.4, 7.7, 6.5 };

            Console.WriteLine("Sum: {0} \nProduct: {1} \nAverage: {2} \nMin element: {3} \nMax element: {4}",
                collectionOfDoubles.Sum(), collectionOfDoubles.Product(), collectionOfDoubles.Average(),
                collectionOfDoubles.Min(), collectionOfDoubles.Max());
        }
    }
}
