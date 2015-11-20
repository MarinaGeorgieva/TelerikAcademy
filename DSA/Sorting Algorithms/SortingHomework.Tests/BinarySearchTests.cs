namespace SortingHomework.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BinarySearchTests
    {
        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWithEmptyCollection()
        {
            var collection = new SortableCollection<int>();
            var found = collection.BinarySearch(21);

            Assert.IsFalse(found, "Element is found in empty collection!");
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWhenSearchedElementIsFound()
        {
            var collection = new SortableCollection<int>(new int[] { 6, 1, 4, 2, 3, 21, -5, 8 });
            collection.Sort(new MergeSorter<int>());
            var found = collection.BinarySearch(21);

            Assert.IsTrue(found, "Element is not found in collection!");
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWhenSearchedElementIsFirst()
        {
            var collection = new SortableCollection<int>(new int[] { 6, 1, 4, 2, 3, 21, -5, 8 });
            collection.Sort(new MergeSorter<int>());
            var found = collection.BinarySearch(6);

            Assert.IsTrue(found, "Element is not found in collection!");
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWhenSearchedElementIsLast()
        {
            var collection = new SortableCollection<int>(new int[] { 6, 1, 4, 2, 3, 21, -5, 8 });
            collection.Sort(new MergeSorter<int>());
            var found = collection.BinarySearch(8);

            Assert.IsTrue(found, "Element is not found in collection!");
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWhenSearchedElementIsInTheMiddle()
        {
            var collection = new SortableCollection<int>(new int[] { 6, 1, 4, 2, 3, 21, -5, 8, 5 });
            collection.Sort(new MergeSorter<int>());
            var found = collection.BinarySearch(4);

            Assert.IsTrue(found, "Element is not found in collection!");
        }

        [TestMethod]
        public void BinarySearchShouldWorkCorrectlyWhenSearchedElementIsNotFound()
        {
            var collection = new SortableCollection<int>(new int[] { 6, 1, 4, 2, 3, -5, 8 });
            collection.Sort(new MergeSorter<int>());
            var found = collection.BinarySearch(21);

            Assert.IsFalse(found, "Element is found in collection!");
        }
    }
}
