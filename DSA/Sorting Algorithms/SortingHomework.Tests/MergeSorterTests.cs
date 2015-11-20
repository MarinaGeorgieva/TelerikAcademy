namespace SortingHomework.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class MergeSorterTests
    {
        [TestMethod]
        public void MergeSortShouldWorkCorrectlyWithEmptyCollection()
        {
            var collection = new SortableCollection<int>();
            collection.Sort(new MergeSorter<int>());

            Assert.AreEqual(0, collection.Items.Count, "Collection is not empty after sorting!");
        }

        [TestMethod]
        public void MergeSortShouldWorkCorrectlyWithSortedCollection()
        {
            var collection = new SortableCollection<int>(new[] { -6, 1, 3, 4, 5, 8, 13, 27 });
            collection.Sort(new MergeSorter<int>());

            Assert.AreEqual(-6, collection.Items[0], "Collection is not sorted correctly!");
            Assert.AreEqual(1, collection.Items[1], "Collection is not sorted correctly!");
            Assert.AreEqual(3, collection.Items[2], "Collection is not sorted correctly!");
            Assert.AreEqual(4, collection.Items[3], "Collection is not sorted correctly!");
            Assert.AreEqual(5, collection.Items[4], "Collection is not sorted correctly!");
            Assert.AreEqual(8, collection.Items[5], "Collection is not sorted correctly!");
            Assert.AreEqual(13, collection.Items[6], "Collection is not sorted correctly!");
            Assert.AreEqual(27, collection.Items[7], "Collection is not sorted correctly!");
        }

        [TestMethod]
        public void MergeSortShouldCorrectlySortUnsortedCollection()
        {
            var collection = new SortableCollection<int>(new[] { 5, 3, 8, 27, 1, 4, -6, 13 });
            collection.Sort(new MergeSorter<int>());

            Assert.AreEqual(-6, collection.Items[0], "Collection is not sorted correctly!");
            Assert.AreEqual(1, collection.Items[1], "Collection is not sorted correctly!");
            Assert.AreEqual(3, collection.Items[2], "Collection is not sorted correctly!");
            Assert.AreEqual(4, collection.Items[3], "Collection is not sorted correctly!");
            Assert.AreEqual(5, collection.Items[4], "Collection is not sorted correctly!");
            Assert.AreEqual(8, collection.Items[5], "Collection is not sorted correctly!");
            Assert.AreEqual(13, collection.Items[6], "Collection is not sorted correctly!");
            Assert.AreEqual(27, collection.Items[7], "Collection is not sorted correctly!");
        }

        [TestMethod]
        public void MergeSortShouldCorrectlySortDescendingCollection()
        {
            var collection = new SortableCollection<int>(new[] { 27, 13, 8, 5, 4, 3, 1, -6 });
            collection.Sort(new MergeSorter<int>());

            Assert.AreEqual(-6, collection.Items[0], "Collection is not sorted correctly!");
            Assert.AreEqual(1, collection.Items[1], "Collection is not sorted correctly!");
            Assert.AreEqual(3, collection.Items[2], "Collection is not sorted correctly!");
            Assert.AreEqual(4, collection.Items[3], "Collection is not sorted correctly!");
            Assert.AreEqual(5, collection.Items[4], "Collection is not sorted correctly!");
            Assert.AreEqual(8, collection.Items[5], "Collection is not sorted correctly!");
            Assert.AreEqual(13, collection.Items[6], "Collection is not sorted correctly!");
            Assert.AreEqual(27, collection.Items[7], "Collection is not sorted correctly!");
        }

        [TestMethod]
        public void MergeSortShouldSortCorrectlyBigCollection()
        {
            int[] numbers = new int[10000];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = 10000 - i;
            }

            var collection = new SortableCollection<int>(numbers);
            collection.Sort(new MergeSorter<int>());

            for (int i = 0; i < collection.Items.Count; i++)
            {
                Assert.AreEqual(i + 1, collection.Items[i], "Collection is not sorted correctly!");
            }
        }
    }
}
